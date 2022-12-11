import { Navigate } from 'react-router-dom';
import { Fragment } from 'react';
import { useAppSelector } from '../../../app/hooks';

interface protectedRouteProps{
    children: JSX.Element | JSX.Element[]
}

const ProtectedRoute = (props:protectedRouteProps) => {
    const user = useAppSelector((store) => store.Authentication.user);

    if (!user) {
        return(
            <Fragment>
                <Navigate to='/landing' />;
            </Fragment>
        )
    }
    return(
        <Fragment>
            {props.children}
        </Fragment>
    )
};

export default ProtectedRoute;