import React from 'react'
import { Reveal, Button } from 'semantic-ui-react'
import { useAppDispatch, useAppSelector } from '../../app/hooks'
import { getUserFromLocalStorage } from '../../utils/getUserFromLocalStorage';
import { SyntheticEvent } from 'react';
import { updateFollowing } from '../../features/Following/FollowingSlice';
import { store } from '../../app/store';
import { Profile } from '../../models/profile';

interface Props {
    profile: Profile
}

const FollowButton = (props:Props) => {
    const following = useAppSelector((store) => store.Following)
    const dispatch = useAppDispatch();

    const handleFollow = (e: SyntheticEvent, username: string) => {
        e.preventDefault();
        dispatch(updateFollowing(props.profile.username));
    }

    if (props.profile.username === getUserFromLocalStorage().username) return null;


    return (
        <Reveal animated='move'>
            <Reveal.Content visible style={{width: '100%'}}>
                <Button 
                    fluid 
                    color='teal' 
                    content={props.profile.following ? 'Following' : 'Not Following'}
                    style={{height: '100%'}}
                />
            </Reveal.Content>
            <Reveal.Content hidden style={{width: '100%'}}>
                <Button
                    fluid
                    basic
                    color={props.profile.following ? 'red' : 'green'}
                    content={props.profile.following ? 'Unfollow' : 'Follow'}
                    loading={following.isLoading}
                    onClick={(e) => handleFollow(e, props.profile.username)}
                />
            </Reveal.Content>
        </Reveal>
    )
}

export default FollowButton