import { profile } from 'console'
import React from 'react'
import { Link } from 'react-router-dom'
import { Card, Icon, Image } from 'semantic-ui-react'
import { Profile } from '../../models/profile'

interface props{
    profile:Profile
}

const ProfileCard = (props:props) => {
  return (
    <Card as={Link} to={`/profiles/${props.profile.username}`}>
        <Image src='https://upload.wikimedia.org/wikipedia/commons/9/99/Sample_User_Icon.png' />
        <Card.Content>
            <Card.Header>{props.profile.displayName}</Card.Header>
            <Card.Description>Bio goes here</Card.Description>
        </Card.Content>
        <Card.Content extra>
            <Icon name='user'/>
            20 followers
        </Card.Content>
    </Card>
  )
}

export default ProfileCard