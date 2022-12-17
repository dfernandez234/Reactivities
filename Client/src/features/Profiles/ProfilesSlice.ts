import { createAsyncThunk, createSlice, PayloadAction } from "@reduxjs/toolkit";
import { Action } from "@remix-run/router";
import { Profile } from "../../models/profile";
import { DeletePhotoThunk, GetUserInfoThunk, UploadPhotoThunk } from "./ProfilesThunk";
import { store } from "../../app/store";
import { getUserFromLocalStorage } from "../../utils/getUserFromLocalStorage";
import { photo } from "../../models/photo";

interface profileState{
    profile: Profile | null,
    isLoading: boolean,
    isCurrentUser: boolean
}

const initialState : profileState = {
    profile: null,
    isLoading: false,
    isCurrentUser: false
}


export const getProfileInfo = createAsyncThunk('profiles/getInfo', GetUserInfoThunk);
export const uploadPhoto = createAsyncThunk('profiles/uploadPhoto', UploadPhotoThunk);
export const deletePhoto = createAsyncThunk('profiles/deletePhoto', DeletePhotoThunk);

const profilesSlice = createSlice({
    name: 'profile_slice',
    initialState,
    reducers: {
        changeName: (state) => {
            state.profile!.username = "Changed";            
        },

        isCurrentUserCheck: (state, action:PayloadAction<any>) => {
            if(action.payload === getUserFromLocalStorage().username){
                state.isCurrentUser = true;
            }else{
                state.isCurrentUser = false;
            }
        }
    },
    extraReducers: builder => {

        builder.addCase(getProfileInfo.pending , (state) => {
            state.isLoading = true;
        })  

        builder.addCase(getProfileInfo.rejected, (state, Action:any) => {
            console.log(Action.payload.data);
            state.isLoading = false;
        })

        builder.addCase(getProfileInfo.fulfilled, (state, Action) => {
            console.log(Action.payload);
            state.profile = Action.payload.data;
            state.isLoading = false;
        })

        
        builder.addCase(uploadPhoto.pending , (state) => {
            state.isLoading = true;
        })  

        builder.addCase(uploadPhoto.rejected, (state, Action:any) => {
            console.log(Action.payload.data);
            state.isLoading = false;
        })

        builder.addCase(uploadPhoto.fulfilled, (state, Action) => {
            const Photo:photo = {...Action.payload.data}
            state.profile?.photos?.push(Photo);
            if(Photo.isMain){
                state.profile!.image = Photo.url;
            }
            state.isLoading = false;
        })

        builder.addCase(deletePhoto.pending , (state) => {
            state.isLoading = true;
        })  

        builder.addCase(deletePhoto.rejected, (state, Action:any) => {
            console.log(Action.payload.data);
            state.isLoading = false;
        })

        builder.addCase(deletePhoto.fulfilled , (state, Action) => {
            if(state.profile){
                state.profile.photos = state.profile.photos?.filter((photo:photo) => photo.id !== Action.payload.ImageId);
            }
            state.isLoading = false;
        })  

    }
});

export default profilesSlice.reducer;
export const {changeName, isCurrentUserCheck} = profilesSlice.actions