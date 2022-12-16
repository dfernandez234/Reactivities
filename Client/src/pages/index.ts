import SharedLayout from "../components/Common/Layout/SharedLayout";
import NotFound from "../components/Errors/NotFound";
import Activities from "./Activities";
import ErrorPage from "./Error";
import Landing from "./Landing";
import Login from "./Login";
import ServerError from "../components/Errors/ServerError";
import ProtectedRoute from '../components/Common/Private/ProtectedRoute';
import SingleActivity from './SingleActivity';
import TestErrors from "../components/Errors/TestError";
import ProfilePage from "./ProfilePage";

export{
    Activities, ErrorPage, SharedLayout, NotFound, Landing, Login, ServerError, 
    ProtectedRoute, SingleActivity, TestErrors, ProfilePage
}