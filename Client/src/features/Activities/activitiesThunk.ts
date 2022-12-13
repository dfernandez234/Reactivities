import axios from "../../apis/activities"
import { ActivityFormValues } from "../../models/activity";
import { IActivityEdit } from "../../models/editActivity";
import { getUserFromLocalStorage } from "../../utils/getUserFromLocalStorage";
import { closeModalLarge } from "../UI/uiSlice";
import { getSingleActivity } from "./activitesSlice";

export const getAllActivitiesThunk = async (thunkAPI:any) => {
    try{
        const response = await axios['get']('activities');
        return {
            response: response.data,
            username: getUserFromLocalStorage().username
        };
    }catch(err){
        const error = err as any;
        if (!error.response) {
            throw err;
        }
        let sum = error.response.data;
        return thunkAPI.rejectWithValue(`Something Went Wrong: ${sum.msg}`);
    }
}

export const getSingleActivityThunk = async (activityId:string, thunkAPI:any) => {
    try{
        const response = await axios['get'](`activities/${activityId}`);
        return {
            response: response.data,
            username: thunkAPI.getState().Authentication.user.username
        };
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
        thunkAPI.dispatch(closeModalLarge());
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

export const createActivityThunk = async(activityData: ActivityFormValues, thunkAPI:any) => {
    try{
        const postData:any = {...activityData};
        postData.date = new Date(postData.date).toISOString();
        const response = await axios['post']('activities', postData);
        thunkAPI.dispatch(closeModalLarge());
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

export const updateAttendanceThunk = async(activityId:string, thunkAPI:any) => {
    try{
        const response = await axios['post'](`/attend/${activityId}`);
        await thunkAPI.dispatch(getSingleActivity(activityId));
        return response.data
    }catch(err){
        const error = err as any; 
        if (!error.response) {
            throw err;
        }
        let sum = error.response.data;
        return thunkAPI.rejectWithValue(`Something Went Wrong: ${sum.msg}`);
    }
}

export const toggleActivityCancelThunk = async(activityId:string, thunkAPI:any) => {
    try{
        const response = await axios['patch'](`activities/${activityId}`);
        await thunkAPI.dispatch(getSingleActivity(activityId));
        return response.data
    }catch(err){
        const error = err as any; 
        if (!error.response) {
            throw err;
        }
        let sum = error.response.data;
        return thunkAPI.rejectWithValue(`Something Went Wrong: ${sum.msg}`);
    }
}