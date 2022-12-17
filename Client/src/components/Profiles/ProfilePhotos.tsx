import React, { useState } from 'react'
import { Card, Header, Tab, Image, Grid, Button, Reveal, Container, Dimmer } from 'semantic-ui-react'
import { Profile } from '../../models/profile'
import PhotoUploadWidget from '../Common/ImageUpload/PhotoUploadWidget'
import { useAppDispatch, useAppSelector } from '../../app/hooks'
import { deletePhoto, uploadPhoto } from '../../features/Profiles/ProfilesSlice'
import { handleDimmerHide, handleDimmerShow } from '../../features/UI/uiSlice'

interface props{
    profile: Profile
    isCurrentUser: boolean
}

const ProfilePhotos = (props:props) => {
    const [addPhotoMode, setAddPhotoMode] = useState(false);
    const profile = useAppSelector((store) => store.Profiles.profile)

    const active = useAppSelector((store) => store.UI.dimmerOpen);
    const dispatch = useAppDispatch();

    const deleteImageHandler = (imageId:string) => {
        dispatch(deletePhoto(imageId));
    }

    return (
        <>
        {profile && 
            <Tab.Pane>
                <Grid>
                    <Grid.Column width={16}>
                        <Header icon='image' content='Photos'/>
                        {props.isCurrentUser && (
                            <Button floated='right' basic 
                                content={addPhotoMode ? 'Cancel' : 'Add Photo'}
                                onClick={() => {setAddPhotoMode(!addPhotoMode)}}
                            />
                        )}
                    </Grid.Column>
                    <Grid.Column width={16}>
                        {addPhotoMode ? (
                            <PhotoUploadWidget closePhotoMode={setAddPhotoMode}/>
                        ) : (
                            <Card.Group itemsPerRow={5}>
                                {props.profile.photos?.map(photo => (
                                    <Dimmer.Dimmable
                                        as={Image}
                                        dimmed={active}
                                        dimmer={{ active, content:
                                            <div>
                                                <Button inverted color='red' onClick={() => {deleteImageHandler(photo.id)}}>
                                                    Delete
                                                </Button>
                                            </div>
                                        }}
                                        onMouseEnter={() => {dispatch(handleDimmerShow())}}
                                        onMouseLeave={() => {dispatch(handleDimmerHide())}}
                                        size='small'
                                        src={photo.url}
                                        blurring
                                        key={photo.id}
                                        />
                                ))}
                            </Card.Group>
                        )}
                    </Grid.Column>
                </Grid>
            </Tab.Pane>
        }
        </>
    )
}





export default ProfilePhotos