import axios from "../../apis/activities"

export const GetUserInfoThunk = async (username:String, thunkAPI:any) => {
    try{
        const response = await axios['get'](`/profiles/${username}`);
        const data = response.data;
        return data;
    }catch(err){
        return thunkAPI.rejectWithValue(err);
    }
}