import axios from "../../apis/activities"

export const updateFollowingThunk = async (username:String, thunkAPI:any) => {
    try{
        const response = await axios['post'](`/follow/${username}`,);
        const data = response.data;
        return data;
    }catch(err){
        return thunkAPI.rejectWithValue(err);
    }
}