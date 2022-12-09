import React from 'react'
import { Grid } from 'semantic-ui-react';
import { useAppSelector } from '../../app/hooks';
import LoadingScreen from '../../pages/LoadingScreen';
import ActivityDetailedChat from './ActivityDetailedChat';
import ActivityDetailedInfo from './ActivityDetailedInfo';
import ActivityDetailedSidebar from './ActivityDetailedSidebar';
import ActivityDetailsHeader from './ActivityDetailsHeader';

interface props{
    id:string | undefined
}

const ActivityDetails = (props:props) => {
    const SingleActivity = useAppSelector((state) => state.Activities);

    if(SingleActivity.isLoading) return <LoadingScreen/>

    return (
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
    )
}

export default ActivityDetails