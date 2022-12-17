import React, { useState } from 'react'
import { useAppSelector } from '../../../app/hooks';
import { Grid, Header, Tab, Button, Container } from 'semantic-ui-react';
import EditProfileForm from './EditProfileForm';

const ProfileAbout = () => {
    const [addEditMode, setEditMode] = useState(false);
    const profile = useAppSelector((store) => store.Profiles.profile)
    const isCurrentUser = useAppSelector((store) => store.Profiles.isCurrentUser);

    return (
        <>
            {profile && 
                <Tab.Pane>
                    <Grid>
                        <Grid.Column width={16}>
                            <Header icon='user' content={`About ${profile.displayName}`}/>
                            {isCurrentUser && (
                                <Button floated='right' basic 
                                    content={addEditMode ? 'Cancel' : 'Edit Profile'}
                                    onClick={() => {setEditMode(!addEditMode)}}
                                />
                            )}
                        </Grid.Column>      
                        <Grid.Column width={16}>
                            {addEditMode ? (
                                <EditProfileForm closeForm={setEditMode}/>
                            ) : (
                                <Container>
                                    <p>
                                        {profile.bio}
                                    </p>
                                </Container>
                            )}
                        </Grid.Column>                  
                    </Grid>
                </Tab.Pane>
            }
        </>
    )
}

export default ProfileAbout