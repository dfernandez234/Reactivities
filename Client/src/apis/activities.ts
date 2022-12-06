import axios, { AxiosError } from "axios";
import { resolve } from "path";
import { useEffect } from "react";
import { useNavigate } from "react-router-dom";
import { toast } from 'react-toastify';

const sleep = (milliseconds:number) => {
  return new Promise(resolve => setTimeout(resolve, milliseconds))
}

const activities_api = axios.create({
    baseURL: 'https://localhost:7238/',
    timeout: 3000,
    headers: {
        "content-type": "application/json",
    },
});

const AxiosInterceptor = ({ children }:any) => {
    const navigate = useNavigate();
    useEffect(() => {
      const resInterceptor = async (response:any) => {
        await sleep(1500);
        return response;
      };
  
      const errInterceptor = (error:AxiosError) => {

        const {data, status, config}:any = error.response!; 
        if(status === 400){
          if(typeof data === 'string'){
            toast(data);
          }

          if(config.method === 'get' && data.errors.hasOwnProperty('Id')){
            console.log("Made it");
            navigate('/not-found');
          }

          if(data.errors){
            const modalStateErrors = [];
            for(const key in data.errors){
              if(data.errors[key]){
                modalStateErrors.push(data.errors[key])
              }
            }
            throw modalStateErrors.flat();
          }else{
            toast.error(data);
          }
        }
        if(status === 401){

        }
        if (status === 404) {
          navigate("/not-found");
        }
        if(status === 500){
          navigate("/server-error");
        }
  
        return Promise.reject(error);
      };
  
      const interceptor = activities_api.interceptors.response.use(
        resInterceptor,
        errInterceptor
      );
  
      return () => activities_api.interceptors.response.eject(interceptor);
    }, []);
  
    return children;
  };


export default activities_api;
export { AxiosInterceptor }



