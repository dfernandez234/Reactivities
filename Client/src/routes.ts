// pages
import Home from "./pages/Home";
// other
import {FC} from "react";
import NewActivity from "./pages/NewActivity";
import TestErrors from "./components/Errors/TestError";
import NotFound from "./components/Errors/NotFound";
import ServerError from "./components/Errors/ServerError";

// interface
interface Route {
    key: string,
    title: string,
    path: string,
    enabled: boolean,
    component: FC<{}>
}

export const routes: Array<Route> = [
    {
        key: 'home-route',
        title: 'Home',
        path: '/',
        enabled: true,
        component: Home
    },
    {
        key: 'new-activty-route',
        title: 'New Activity',
        path: '/newActivity',
        enabled: true,
        component: NewActivity
    },
    {
        key: 'errors',
        title: 'Errors',
        path: '/errors',
        enabled: true,
        component: TestErrors
    },
    {
        key:'notFoundError',
        title: 'Not Found Error',
        path:'/not-found',
        enabled:true,
        component: NotFound
    },
    {
        key:'serverError',
        title: 'Server Error',
        path:'/server-error',
        enabled:true,
        component: ServerError
    }
]