import { createAsyncThunk, createSlice } from "@reduxjs/toolkit";
import { getFollowingsThunk, updateFollowingThunk } from "./FollowingThunk";
import { Profile } from "../../models/profile";

interface state{
    errors: any;
    isLoading: boolean;
    followings: Profile[];
}

const initialState:state ={
    errors: null,
    isLoading: false,
    followings: []
}

export const updateFollowing = createAsyncThunk('following/updateFollowing', updateFollowingThunk);
export const getFollowings = createAsyncThunk('following/getFollowings', getFollowingsThunk);

const FollowingSlice = createSlice({
    name: "following_slice",
    initialState,
    reducers: {
        clearFollowings: (state) => {
            state.followings = [];
        }
    },

    extraReducers: builder => {
        builder.addCase(updateFollowing.pending, (state, action) => {
            state.isLoading = true;
        })
        builder.addCase(updateFollowing.rejected, (state, action) => {
            state.isLoading = false;
            window.location.reload();
        })
        builder.addCase(updateFollowing.fulfilled, (state, action) => {
            state.isLoading = false;
            window.location.reload();
        })

        builder.addCase(getFollowings.pending, (state, action) => {
            state.isLoading = true;
        })
        builder.addCase(getFollowings.rejected, (state, action) => {
            console.log(action.payload);
            state.isLoading = false;
        })
        builder.addCase(getFollowings.fulfilled, (state, action) => {
            state.followings = action.payload.data;
            state.isLoading = false;
        })
    }
})

export default FollowingSlice.reducer;
export const {clearFollowings} = FollowingSlice.actions;