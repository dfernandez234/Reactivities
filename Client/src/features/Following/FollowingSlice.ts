import { createAsyncThunk, createSlice } from "@reduxjs/toolkit";
import { updateFollowingThunk } from "./FollowingThunk";

interface state{
    errors: any;
    isLoading: boolean;
}

const initialState:state ={
    errors: null,
    isLoading: false
}

export const updateFollowing = createAsyncThunk('following/updateFollowing', updateFollowingThunk);


const FollowingSlice = createSlice({
    name: "following_slice",
    initialState,
    reducers: {

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
    }
})

export default FollowingSlice.reducer;