import { createAsyncThunk, createSlice} from "@reduxjs/toolkit";
import { IActivity } from "../../models/activity";
import axios from "../../apis/activities"

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

export const getAllActivities = createAsyncThunk('activities/getAll', async (thunkAPI:any) => {
    try{
        const response = await axios['get']('activities');
        return response.data;
    }catch(err){
        const error = err as any;
        if (!error.response) {
            throw err;
        }
        let sum = error.response.data;
        return thunkAPI.rejectWithValue(`Something Went Wrong: ${sum.msg}`);
    }
}) as any;

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
            state.isLoading = false;
            const err:string = action.payload as string;
            console.log(`${err}`);
        })

        builder.addCase(getAllActivities.fulfilled, (state, action) => {
            state.Activities = action.payload.data;

            state.Activities.forEach((act) => {
                act.date = act.date.split('T')[0];
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