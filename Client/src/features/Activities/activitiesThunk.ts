import axios from "../../apis/activities"
import { IActivityCreate } from "../../models/createActivity";
import { IActivityEdit } from "../../models/editActivity";
import { getSingleActivity } from "./activitesSlice";
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

export const updateActivityThunk = async(editData: IActivityEdit, thunkAPI:any) => {
    try{
        const body:any = editData.data
        body.date = new Date(body.date);
        const response = await axios['put'](`activities/${editData.ActivityId}`, body);
        thunkAPI.dispatch(getSingleActivity(editData.ActivityId));
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

export const createActivityThunk = async(activityData: IActivityCreate, thunkAPI:any) => {
    try{
        const postData:any = {...activityData};
        postData.date = new Date(postData.date).toISOString();
        const response = await axios['post']('activities', postData);
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