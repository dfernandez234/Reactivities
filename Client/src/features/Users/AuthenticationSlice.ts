import { createAsyncThunk, createSlice } from "@reduxjs/toolkit";
import { User } from "../../models/users";
import { addUserToLocalStorage, getUserFromLocalStorage, removeUserFromLocalStorage } from "../../utils/getUserFromLocalStorage";
import { getCurrentUserThunk, loginThunk, registerThunk } from "./AuthenticationThunk";
import { removeActivityIdFromLocalStorage } from "../../utils/getActivityFromLocalStorage";

interface AuthenticationState{
    user: User | null,
    errors: any | null
    loading: boolean,
    success: boolean,
}

const initialState: AuthenticationState = {
    user: getUserFromLocalStorage(),
    errors: null,
    loading: false,
    success: false
};

export const login = createAsyncThunk('authentication/login', loginThunk);
export const register = createAsyncThunk('authentication/register', registerThunk);
export const getCurrentUser = createAsyncThunk('authentication/getSingle', getCurrentUserThunk);

const AuthenticationSlice = createSlice({
    name:"authSlice",
    initialState,
    reducers:{
        logout: (state) => {
            state.user = null;
            state.errors = null;
            removeUserFromLocalStorage();
            removeActivityIdFromLocalStorage();
        },

        clearInputs: (state) => {
            state.user = null;
            state.errors = null;
        }
    },

    extraReducers: builder => {
        //login
        builder.addCase(login.pending, (state) => {
            state.loading = true;
        })
        builder.addCase(login.rejected, (state) => {
            state.errors = {Message: "Invalid Email or Password", Status: 401}
            state.success = false;
            state.loading = false;
        })
        builder.addCase(login.fulfilled, (state, action) => {
            state.user = action.payload;
            addUserToLocalStorage(action.payload);
            state.success = true;
            state.loading = false;
        })

        //register
        builder.addCase(register.pending, (state) => {
            state.loading = true;
        })
        builder.addCase(register.rejected, (state, action) => {
            state.success = false;
            state.loading = false;
            state.errors = action.payload;
        })
        builder.addCase(register.fulfilled, (state, action) => {
            state.user = action.payload;
            addUserToLocalStorage(action.payload);
            state.success = true;
            state.loading = false;
        })
    }
});

export const {logout, clearInputs} = AuthenticationSlice.actions; 
export default AuthenticationSlice.reducer