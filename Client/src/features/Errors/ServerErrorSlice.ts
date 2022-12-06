import { createSlice, PayloadAction } from "@reduxjs/toolkit";
import { ServerError } from "../../models/serverError";

interface serverErrorState{
    error: ServerError;
}

const initialState:serverErrorState = {
    error: {
        detail: '',
        instance: '',
        status: 0,
        title: '',
        type: ''
    }
}

export const ServerErrorSlice = createSlice({
    name:'serverError_slice',
    initialState,
    reducers:{
        setError:(state, action:PayloadAction<ServerError>) => {
            state.error = {...action.payload};
        }
    }
});

export default ServerErrorSlice.reducer;
export const {setError} = ServerErrorSlice.actions;