import { createAsyncThunk, createSlice } from "@reduxjs/toolkit";
import { IActivity } from "../../models/activity";
import { createActivityThunk, deleteActivityThunk, getSingleActivityThunk, updateActivityThunk } from "./activitiesThunk";

interface activitiesState{
    Activities: IActivity[],
    EditingActivity: IActivity,
    isLoading: boolean,
    isEditing: boolean,
    isCreating: boolean,
}

const initialState:activitiesState = {
    Activities: [],
    EditingActivity:{
        id: "",
        title: "",
        date: "",
        description: "",
        category: "",
        city: "",
        venue: "",
    },
    isLoading: false,
    isEditing: false,
    isCreating: false,
}


export const updateActivity = createAsyncThunk('activities/update', updateActivityThunk);
export const createActivity = createAsyncThunk('activities/create', createActivityThunk);
export const deleteActivity = createAsyncThunk('activities/delete', deleteActivityThunk);

export const getSingleActivity = createAsyncThunk('activities/getSingle', getSingleActivityThunk) as any;

const ActivitiesSlice = createSlice({
    name:'activities-slice',
    initialState,
    reducers:{
        clearValues: () => {
            return initialState;
        },

        toggleEditing: (state) => {
            if(state.isCreating){
                state.isCreating = false;
            }
            state.isEditing = !state.isEditing;
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
            state.EditingActivity = action.payload.data;
            state.EditingActivity.date = state.EditingActivity.date.slice(0, -4)+'Z';
            state.isLoading = false;
        })

        //create
        builder.addCase(createActivity.pending, (state) => {
            state.isLoading = true;
        })

        builder.addCase(createActivity.rejected, (state, action) => {
            state.isLoading = false;
            const err:string = action.payload as string;
            console.log(`${err}`);
        })

        builder.addCase(createActivity.fulfilled, (state, action) => {
            state.isLoading = false;
        })

        //update
        builder.addCase(updateActivity.pending, (state) => {
            state.isLoading = true;
        })

        builder.addCase(updateActivity.rejected, (state, action) => {
            state.isLoading = false;
            const err:string = action.payload as string;
            console.log(`${err}`);
        })

        builder.addCase(updateActivity.fulfilled, (state, action) => {
            state.isLoading = false;
            state.EditingActivity = action.payload.data;
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
    }
})

export const {toggleEditing, toggleCreating} = ActivitiesSlice.actions; 
export default ActivitiesSlice.reducer