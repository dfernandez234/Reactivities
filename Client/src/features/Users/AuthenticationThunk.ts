import axios from "../../apis/activities";
import { LoginRequest, registerRequest } from "../../models/users";
import { closeModalSmall } from "../UI/uiSlice";

export const loginThunk = async (loginRequest:LoginRequest, thunkAPI:any) => {
    try{
        const response = await axios['post']('authentication/login', loginRequest);
        thunkAPI.dispatch(closeModalSmall());
        return response.data;
    }catch(err){
        const error = err as any;
        if (!error.response) {
            throw err;
        }
        let sum = error.response.data;
        return thunkAPI.rejectWithValue(`Something Went Wrong: ${sum.msg}`);
    }
}

export const registerThunk = async (registerRequest:registerRequest, thunkAPI:any) => {
    try{
        const response = await axios['post']('authentication/register', registerRequest);
        return response.data;
    }catch(err){
        return thunkAPI.rejectWithValue(err);
    }
}

export const getCurrentUserThunk = async () => {
   const response = await axios['get']('authentication');
   return response.data;
}