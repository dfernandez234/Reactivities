import axios from "../../apis/activities"
import { IActivity } from "../../models/activity"
import { IActivityCreate } from "../../models/createActivity";
import { getAllActivities } from "./allActivitiesSlice";

export const getSingleActivityThunk = async (activityId:string, thunkAPI:any) => {
    try{
        const response = await axios['get'](`activities/${activityId}`);
        return response.data;
    }catch(err){
        const error = err as any;
        if (!error.response) {
            throw err;
        }
        let sum = error.response.data;
        return thunkAPI.rejectWithValue(`Something Went Wrong: ${sum.msg}`);
    }
}

export const updateActivityThunk = async(activityData:IActivity, thunkAPI:any) => {
    try{
        const editData = {...activityData}
        const response = await axios['put'](`activities/edit/${editData.id}`, editData);
        thunkAPI.dispatch(getAllActivities());
        return response.data;
    }catch(err){
        const error = err as any; 
        if (!error.response) {
            throw err;
        }
        let sum = error.response.data;
        return thunkAPI.rejectWithValue(`Something Went Wrong: ${sum.msg}`);
    }
}

export const createActivityThunk = async(activityData: IActivity, thunkAPI:any) => {
    try{
        let createData: IActivityCreate = {
            title: activityData.title,
            date: activityData.date,
            description: activityData.description,
            category: activityData.category,
            city: activityData.city,
            venue: activityData.venue,
        }
        const response = await axios['post']('activities/new', createData);
        thunkAPI.dispatch(getAllActivities());
        return response.data;
    }catch(err){
        const error = err as any; 
        if (!error.response) {
            throw err;
        }
        let sum = error.response.data;
        return thunkAPI.rejectWithValue(`Something Went Wrong: ${sum.msg}`);
    }
}

export const deleteActivityThunk = async (activityId:string, thunkAPI:any) => {
    try{
        const response = await axios['delete'](`activities/delete/${activityId}`)
        thunkAPI.dispatch(getAllActivities());
        return response.data;
    }catch(err){
        const error = err as any; 
        if (!error.response) {
            throw err;
        }
        let sum = error.response.data;
        return thunkAPI.rejectWithValue(`Something Went Wrong: ${sum.msg}`);
    }
}