import React from 'react'
import { useParams } from 'react-router-dom'
import { Container, Grid } from 'semantic-ui-react';
import Profile from '../components/Profiles/Profile'

const ProfilePage = () => {
    return (
        <Container style={{marginTop: '7em'}}>
            <Profile/>
        </Container>
    )
}

export default ProfilePage