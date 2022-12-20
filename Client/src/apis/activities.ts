import axios, { AxiosError, AxiosResponse } from "axios";
import { useEffect } from "react";
import { useLocation, useNavigate } from "react-router-dom";
import { toast } from 'react-toastify';
import { getUserFromLocalStorage } from "../utils/getUserFromLocalStorage";
import { PaginatedResult } from "../models/pagination";

const sleep = (milliseconds:number) => {
  return new Promise(resolve => setTimeout(resolve, milliseconds))
}

const activities_api = axios.create({
    baseURL: 'https://localhost:7238/',
    //timeout: 10000
});

activities_api.interceptors.request.use(
  function(config:any) {
    const user = getUserFromLocalStorage(); 
    if (user) {
      config.headers["Authorization"] = 'Bearer ' + user.token;
    }
    return config;
  },
  function(error) {
    return Promise.reject(error);
  }
)

const AxiosInterceptor = ({ children }:any) => {
    const navigate = useNavigate();
    const location = useLocation();

    useEffect(() => {
      const resInterceptor = async (response:any) => {
        await sleep(1500);

        const pagination = response.headers['pagination'];
        if(pagination){
          response.data = new PaginatedResult(response.data, JSON.parse(pagination));
          return response as AxiosResponse<PaginatedResult<any>>
        }
        return response;
      };
  
      const errInterceptor = async (error:AxiosError) => {
        await sleep(1500);
        const {data, status, config}:any = error.response!; 
        if(status === 400){
          if(typeof data === 'string'){
            toast.error(data);
          }

          if(config.method === 'get' && data.errors.hasOwnProperty('Id')){
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
          const pathname = location.pathname;
          if(pathname !== '/login'){
            toast.error("Please login to view this content");
            navigate('/Landing');
          }
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
    }, [navigate, location.pathname]);
  
    return children;
  };


export default activities_api;
export { AxiosInterceptor }



