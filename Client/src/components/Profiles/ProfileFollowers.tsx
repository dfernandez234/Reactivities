import React, { useEffect } from 'react'
import { Card, Grid, Header, Tab } from 'semantic-ui-react'
import { useAppDispatch, useAppSelector } from '../../app/hooks'
import { store } from '../../app/store';
import ProfileCard from './ProfileCard';
import { Profile } from '../../models/profile'
import { clearFollowings, getFollowings } from '../../features/Following/FollowingSlice';

const ProfileFollowers = () => {
    const followings = useAppSelector((store) => store.Following);
    const profile = useAppSelector((store) => store.Profiles.profile);
    const dispatch = useAppDispatch();

    useEffect(() => {
        if(profile){
            dispatch(getFollowings({username:profile?.username, predicate:'followers'}))
        }

        return(() => {
            dispatch(clearFollowings);
        })
    }, [dispatch, profile])

    return (
        <Tab.Pane loading ={followings.isLoading}>
            <Grid>
                <Grid.Column width={16}>
                    <Header floated='left' icon='user' content={`Followers ${profile?.displayName}`}/>
                </Grid.Column>
                <Grid.Column width={16}>
                    <Card.Group itemsPerRow={3}>
                        {followings.followings.map((profile:Profile) => (
                            <ProfileCard key={profile.username} profile={profile} />
                        ))}
                    </Card.Group>
                </Grid.Column>
            </Grid>
        </Tab.Pane>
    )
}

export default ProfileFollowers