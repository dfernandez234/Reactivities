import React from 'react'
import { useParams } from 'react-router-dom'
import { Container } from 'semantic-ui-react';
import ActivityDetails from '../components/ActivityDetails/ActivityDetails';

const SingleActivity = () => {
    const id = useParams().ActivityId;

    return (
        <Container textAlign='center' style={{marginTop: '7em'}}>
            <ActivityDetails id={id}/>
        </Container>
    )
}

export default SingleActivity