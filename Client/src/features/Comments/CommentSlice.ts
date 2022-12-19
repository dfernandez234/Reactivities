import { PayloadAction, createAsyncThunk, createSlice } from "@reduxjs/toolkit";
import { ChatComment } from "../../models/comment";
import { HubConnection } from "@microsoft/signalr/dist/esm/HubConnection";
import { getActivityIdFromLocalStorage } from "../../utils/getActivityFromLocalStorage";

interface State{
    comments: ChatComment[];
    hubConnection: HubConnection | null;
    isLoading: boolean;
}

const initialState:State={
    comments: [],
    hubConnection: null,
    isLoading: false
}

export const addComment = createAsyncThunk('comments/addMessage', async(values: any, thunkAPI:any) => {
    values.activityId = getActivityIdFromLocalStorage();
    const state = thunkAPI.getState().Comments;
    try{
        state.hubConnection?.invoke("SendComment", values);
    }catch(err){
        console.log(err);
        return thunkAPI.rejectWithValue(err)
    }
});

const commentSlice = createSlice({
    name: 'comments_slice',
    initialState,
    reducers:{
        setStatus(state, action:PayloadAction<HubConnection>){
            state.hubConnection = action.payload;
        },

        startConnecting(state){
            console.log("Starting Server Connection...");
        },

        stopHubConnection(state){
            if(state.hubConnection){
                state.hubConnection.stop().catch(error => console.log("Error while stopping SignalR connection", error));
            }
        },

        setComments(state, action:PayloadAction<ChatComment[]>){
            const comments =  action.payload;
            comments.forEach(comment => {
                comment.createdAt = new Date(comment.createdAt + "Z");
            })

            state.comments = comments
        },

        receiveComment(state, action:PayloadAction<ChatComment>){
            const comment = action.payload;
            comment.createdAt = new Date(comment.createdAt = "Z");
            state.comments.unshift(comment);
        },

        clearComments(state){
            state.comments = [];
            state.hubConnection = null;
        },
    },

    extraReducers: builder => {
        builder.addCase(addComment.pending, (state, actiom) => {
            state.isLoading = true;
        })
        builder.addCase(addComment.rejected, (state, actiom) => {
            state.isLoading = false;
        })
        builder.addCase(addComment.fulfilled, (state, actiom) => {
            state.isLoading = false;
        })
    }
})

export default commentSlice.reducer;
export const commentActions = commentSlice.actions