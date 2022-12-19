import { Middleware } from "redux";
import { store } from "./store";
import { commentActions } from "../features/Comments/CommentSlice";
import { getActivityIdFromLocalStorage } from "../utils/getActivityFromLocalStorage";
import { HubConnectionBuilder } from "@microsoft/signalr";
import { getUserFromLocalStorage } from "../utils/getUserFromLocalStorage";
import { LogLevel } from "@microsoft/signalr/dist/esm/ILogger";
import { ChatComment } from "../models/comment";

const chatMiddleware:Middleware = store => next => action => {
    if(!commentActions.startConnecting.match(action)){
        return next(action)
    }

    const activityId = getActivityIdFromLocalStorage()
    const user = getUserFromLocalStorage();

    if(user && activityId){
        const connection = new HubConnectionBuilder()
        .withUrl("https://localhost:7238/chat?activityId=" + activityId, {
            accessTokenFactory: () => user.token
        })
        .withAutomaticReconnect()
        .configureLogging(LogLevel.Debug)
        .build();

        connection.start()
        .catch(error => console.log('Error establisihing the connection: ', error))
        .then(() => {
            store.dispatch(commentActions.setStatus(connection))
        });

        connection.on('LoadComments', (comments: ChatComment[]) => {
            console.log(`Middleware load comments`)
            console.log(comments)
            store.dispatch(commentActions.setComments(comments));
        })

        connection.on('ReceiveComment', (comment: ChatComment) => {
            console.log(`Middleware ReceiveComment`);
            console.log(comment)
            store.dispatch(commentActions.receiveComment(comment));
        })
    }

    next(action);
}

export default chatMiddleware;