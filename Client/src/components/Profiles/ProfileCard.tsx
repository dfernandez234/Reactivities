import React from 'react'
import { Link } from 'react-router-dom'
import { Card, Grid, Icon, Image } from 'semantic-ui-react'
import { Profile } from '../../models/profile'
import { useAppSelector } from '../../app/hooks'
import FollowButton from './FollowButton'
import { getUserFromLocalStorage } from '../../utils/getUserFromLocalStorage'

interface props{
    profile:Profile
}

const ProfileCard = (props:props) => {
  const truncate = (str:string) => {
      return str.length > 40 ? str.substring(0, 40) + "..." : str;
  }

  const mProfile = getUserFromLocalStorage().username;

  return (
    <Card>
        <Image as={Link} to={`/profiles/${props.profile.username}`} 
        src={props.profile.image || 'https://upload.wikimedia.org/wikipedia/commons/9/99/Sample_User_Icon.png'} />
        <Card.Content>
            <Card.Header>{props.profile.displayName}</Card.Header>
            <Card.Description>{truncate(props.profile.bio!)}</Card.Description>
        </Card.Content>
        <Card.Content extra>
            <Grid>
                <Grid.Column width={7} verticalAlign="middle">
                    <Icon name='user'/>
                    {props.profile.followersCount} followers
                </Grid.Column>
                <Grid.Column width={9} textAlign='right'>
                    {mProfile !== props.profile.username &&
                        <FollowButton profile={props.profile}/>
                    }
                </Grid.Column>
            </Grid>
        </Card.Content>
    </Card>
  )
}

export default ProfileCard