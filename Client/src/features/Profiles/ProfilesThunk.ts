import axios from "../../apis/activities"
import { ProfileEdit } from "../../models/profile";

export const GetUserInfoThunk = async (username:String, thunkAPI:any) => {
    try{
        const response = await axios['get'](`/profiles/${username}`);
        const data = response.data;
        return data;
    }catch(err){
        return thunkAPI.rejectWithValue(err);
    }
}

export const UploadPhotoThunk = async(file:Blob, thunkAPI:any) => {
    try{
        let formData = new FormData();
        formData.append('File', file);
        const response = await axios['post']('/photos/add', formData, {
            headers: {'Content-Type': 'multipart/form-data'}
        });
        return response.data
    }catch(err){
        return thunkAPI.rejectWithValue(err)
    }
}

export const DeletePhotoThunk = async (ImageId:string, thunkAPI:any) => {
    try{
        const response = await axios['post'](`/photos/delete/${ImageId}`);
        return {
            data: response.data,
            ImageId: ImageId
        }
    }catch(err){
        return thunkAPI.rejectWithValue(err)
    }
}

export const UpdateProfileThunk = async(ProfileEdit:ProfileEdit, thunkAPI:any) => {
    try{
        const requestBody = {displayName: ProfileEdit.displayName, bio: ProfileEdit.bio}
        const response = await axios['put'](`/profiles/${ProfileEdit.username}`, requestBody);
        return {
            data: response.data,
            updates: {displayName:ProfileEdit.displayName, bio: ProfileEdit.bio}
        };
    }catch(err){
        return thunkAPI.rejectWithValue(err)
    }
}