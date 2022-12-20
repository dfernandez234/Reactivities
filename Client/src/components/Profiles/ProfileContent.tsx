import React from 'react'
import { Tab } from 'semantic-ui-react';
import { Profile } from '../../models/profile';
import ProfilePhotos from './ProfilePhotos';
import ProfileAbout from './About/ProfileAbout';
import ProfileFollowings from './ProfileFollowings';
import ProfileFollowers from './ProfileFollowers';

interface Props{
    profile: Profile
    isCurrentUser: boolean
}

const ProfileContent = (props: Props) => {
    const panes = [
        {menuItem: 'About', render: () => <ProfileAbout/>},
        {menuItem: 'Photos', render: () => <ProfilePhotos profile={props.profile} isCurrentUser={props.isCurrentUser}/>},
        {menuItem: 'Events', render: () => <Tab.Pane>Events Content</Tab.Pane>},
        {menuItem: 'Followers', render: () => <ProfileFollowers/>},
        {menuItem: 'Following', render: () => <ProfileFollowings/>},
    ];


    return (
        <Tab
            menu={{fluid: true, vertical: true}}
            menuPosition='right'
            panes={panes}
        />
    )
}

export default ProfileContent