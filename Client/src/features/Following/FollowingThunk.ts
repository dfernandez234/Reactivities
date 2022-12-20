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

export const getFollowingsThunk = async (request:{username:string, predicate:string}, thunkAPI:any) => {
    try{
        const response = await axios['get'](`/follow/${request.username}?predicate=${request.predicate}`,);
        const data = response.data;
        return data;
    }catch(err){
        return thunkAPI.rejectWithValue(err);
    }
}