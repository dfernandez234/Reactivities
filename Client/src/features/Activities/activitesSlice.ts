import { createAsyncThunk, createSlice } from "@reduxjs/toolkit";
import { toast } from "react-toastify";
import {Profile } from "../../models/profile"
import { IActivity } from "../../models/activity";
import { createActivityThunk, deleteActivityThunk, getSingleActivityThunk, toggleActivityCancelThunk, updateActivityThunk, updateAttendanceThunk } from "./activitiesThunk";

interface activitiesState{
    EditingActivity: IActivity | null,
    isLoading: boolean,
    isEditing: boolean,
    isCreating: boolean,
}

const initialState:activitiesState = {
    EditingActivity:null,
    isLoading: false,
    isEditing: false,
    isCreating: false,
}


export const updateActivity = createAsyncThunk('activities/update', updateActivityThunk);
export const createActivity = createAsyncThunk('activities/create', createActivityThunk);
export const deleteActivity = createAsyncThunk('activities/delete', deleteActivityThunk);
export const updateAttendance = createAsyncThunk('activities/updateAttendance', updateAttendanceThunk);
export const toggleCancelActivity = createAsyncThunk('activities/toggleCancelActivity', toggleActivityCancelThunk);

export const getSingleActivity = createAsyncThunk('activities/getSingle', getSingleActivityThunk) as any;

const ActivitiesSlice = createSlice({
    name:'activities-slice',
    initialState,
    reducers:{
        clearValues: () => {
            return initialState;
        },

        toggleEditing: (state) => {
            if(state.isCreating)
                state.isCreating = false;
            if(state.isEditing)
                return;
            if(!state.isEditing)
                state.isEditing = true;
        },

        toggleCreating: (state) => {

            if(state.isEditing){
                state.isEditing = false;
            }
            if(state.isCreating){
                return;
            }
            if(!state.isCreating){
                state.isCreating = true;
            }
        }
    },
    extraReducers: builder => {

        //get single
        builder.addCase(getSingleActivity.pending, (state) => {
            state.isLoading = true;
        })

        builder.addCase(getSingleActivity.rejected, (state, action) => {
            state.isLoading = false;
            const err:string = action.payload as string;
            console.log(`${err}`);
        })

        builder.addCase(getSingleActivity.fulfilled, (state, action) => {
            state.EditingActivity = action.payload.response.data;

            if(state.EditingActivity){
                state.EditingActivity.isGoing = state.EditingActivity.attendees.some(
                    a => a.username === action.payload.username
                );
                state.EditingActivity.isHost = state.EditingActivity.hostUsername === action.payload.username;
                state.EditingActivity.host = state.EditingActivity.attendees.find(x => x.username === state.EditingActivity?.hostUsername);
            }
            //state.EditingActivity.date = state.EditingActivity.date.slice(0, -4)+'Z';
            state.isLoading = false;
        })

        //create
        builder.addCase(createActivity.pending, (state) => {
            state.isLoading = true;
        })

        builder.addCase(createActivity.rejected, (state, action) => {
            state.isLoading = false;
            const err:string = action.payload as string;
            toast.error(`${err}`);
        })

        builder.addCase(createActivity.fulfilled, (state, action) => {
            state.isLoading = false;
            toast.success("Activity Created Succesfully!");
        })

        //update
        builder.addCase(updateActivity.pending, (state) => {
            state.isLoading = true;
        })

        builder.addCase(updateActivity.rejected, (state, action) => {
            state.isLoading = false;
            const err:string = action.payload as string;
            toast.error(`${err}`);
        })

        builder.addCase(updateActivity.fulfilled, (state, action) => {
            state.EditingActivity = action.payload;
            window.location.reload();
            state.isLoading = false;
        })

        //delete
        builder.addCase(deleteActivity.pending, (state) => {
            state.isLoading = true;
        })

        builder.addCase(deleteActivity.rejected, (state, action) => {
            state.isLoading = false;
            const err:string = action.payload as string;
            console.log(`${err}`);
        })

        builder.addCase(deleteActivity.fulfilled, (state, action) => {
            state.isLoading = false;
        })

        //update attendance
        builder.addCase(updateAttendance.pending, (state) => {
            state.isLoading = true;
        })

        builder.addCase(updateAttendance.rejected, (state, action) => {
            state.isLoading = false;
            const err:string = action.payload as string;
            console.log(`${err}`);
        })

        builder.addCase(updateAttendance.fulfilled, (state, action) => {
            state.isLoading = false;
        })

        //toggle cancel
        builder.addCase(toggleCancelActivity.pending, (state) => {
            state.isLoading = true;
        })

        builder.addCase(toggleCancelActivity.rejected, (state, action) => {
            const err:string = action.payload as string;
            console.log(`${err}`);
            state.isLoading = false;
        })

        builder.addCase(toggleCancelActivity.fulfilled, (state) => {
            state.isLoading = false;
        })
    }
})

export const {toggleEditing, toggleCreating} = ActivitiesSlice.actions; 
export default ActivitiesSlice.reducer