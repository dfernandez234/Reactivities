import React, { useEffect } from 'react'
import { useParams } from 'react-router-dom'
import { Container } from 'semantic-ui-react';
import { useAppDispatch } from '../app/hooks';
import ActivityDetails from '../components/ActivityDetails/ActivityDetails';
import { getSingleActivity } from '../features/Activities/activitesSlice';

const SingleActivity = () => {
    const id = useParams().ActivityId;

    return (
        <Container textAlign='center' style={{marginTop: '7em'}}>
            <ActivityDetails id={id}/>
        </Container>
    )
}

export default SingleActivity