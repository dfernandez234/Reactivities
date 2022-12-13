import React, { Fragment, useEffect } from 'react'
import { Grid } from 'semantic-ui-react';
import { useAppDispatch, useAppSelector } from '../../app/hooks';
import { getSingleActivity } from '../../features/Activities/activitesSlice';
import LoadingScreen from '../../pages/LoadingScreen';
import ActivityDetailedChat from './ActivityDetailedChat';
import ActivityDetailedInfo from './ActivityDetailedInfo';
import ActivityDetailedSidebar from './ActivityDetailedSidebar';
import ActivityDetailsHeader from './ActivityDetailsHeader';

interface props{
    id:string | undefined
}


const ActivityDetails = (props:props) => {
    const EditingActivity = useAppSelector((state) => state.Activities);
    const dispatch = useAppDispatch();

    useEffect(() => {
        dispatch(getSingleActivity(props.id));
    }, [dispatch, props.id]);


    if(EditingActivity.isLoading) return <LoadingScreen/>

    return (
        <Fragment>
            {EditingActivity.EditingActivity && 
            <Grid>
                    <Grid.Column width={10}>
                        <ActivityDetailsHeader id={props.id}/>
                        <ActivityDetailedInfo/>
                        <ActivityDetailedChat/>
                    </Grid.Column>
                    <Grid.Column width={6}>
                        <ActivityDetailedSidebar/>
                    </Grid.Column>
                </Grid>
            }
        </Fragment>
    )
}

export default ActivityDetails