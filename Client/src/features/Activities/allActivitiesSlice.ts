import { createAsyncThunk, createSlice} from "@reduxjs/toolkit";
import { IActivity } from "../../models/activity";
import axios from "../../apis/activities"
import { getAllActivitiesThunk } from "./activitiesThunk";

interface allActivitiesState{
    Activities: IActivity[],
    isLoading: boolean,
    groupedActivities: any[]
}

const initialState:allActivitiesState = {
    Activities: [],
    isLoading: false,
    groupedActivities: []
}

export const getAllActivities = createAsyncThunk('activities/getAll', getAllActivitiesThunk);

const AllActivitiesSlice = createSlice({
    name: 'allActivities-slice',
    initialState,
    reducers:{},
    extraReducers: builder => {
        //get all
        builder.addCase(getAllActivities.pending, (state) => {
            state.isLoading = true;
        })

        builder.addCase(getAllActivities.rejected, (state, action) => {
            console.log("Error")
        })

        builder.addCase(getAllActivities.fulfilled, (state, action) => {

            console.log(action.payload);
            state.Activities = action.payload.response;

            state.Activities.forEach((act) => {
                act.date = act.date.split('T')[0];
                act.isGoing = act.attendees.some(
                    a => a.username === action.payload.username
                );
                act.isHost = act.hostUsername === action.payload.username;
                act.host = act.attendees.find(x => x.username === act.hostUsername);
            })

            state.Activities.sort((a, b) => Date.parse(b.date) - Date.parse(a.date));



            state.groupedActivities = Object.entries(
                state.Activities.reduce((activities, activity) => {
                    const date = activity.date;
                    activities[date] = activities[date] ? [...activities[date], activity] : [activity];
                    return activities
                }, {} as {[key:string]: IActivity[]})
            )

            state.isLoading = false;
        })
    }
})

export default AllActivitiesSlice.reducer