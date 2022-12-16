import { createAsyncThunk, createSlice } from "@reduxjs/toolkit";
import { Action } from "@remix-run/router";
import { Profile } from "../../models/profile";
import { GetUserInfoThunk } from "./ProfilesThunk";

interface profileState{
    profile: Profile | null,
    isLoading: boolean
}

const initialState : profileState = {
    profile: null,
    isLoading: false
}


export const getProfileInfo = createAsyncThunk('profiles/getInfo', GetUserInfoThunk);

const profilesSlice = createSlice({
    name: 'profile_slice',
    initialState,
    reducers: {
        changeName: (state) => {
            state.profile!.username = "Changed";            
        }
    },
    extraReducers: builder => {

        builder.addCase(getProfileInfo.pending , (state) => {
            state.isLoading = true;
        })  

        builder.addCase(getProfileInfo.rejected, (state, Action:any) => {
            console.log(Action.payload.data);
        })

        builder.addCase(getProfileInfo.fulfilled, (state, Action) => {
            console.log(Action.payload);
            state.profile = Action.payload.data;
            state.isLoading = false;
        })
    }
});

export default profilesSlice.reducer;
export const {changeName} = profilesSlice.actions