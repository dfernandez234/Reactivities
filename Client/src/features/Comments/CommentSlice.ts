import { PayloadAction, createSlice } from "@reduxjs/toolkit";
import { ChatComment } from "../../models/comment";
import { HubConnection } from "@microsoft/signalr/dist/esm/HubConnection";

interface State{
    comments: ChatComment[];
    hubConnection: HubConnection | null;
}

const initialState:State={
    comments: [],
    hubConnection: null
}

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

        clearComments(state){
            state.comments = [];
            state.hubConnection = null;
        }
    }
})

export default commentSlice.reducer;
export const commentActions = commentSlice.actions