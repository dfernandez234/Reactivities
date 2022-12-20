import React from 'react'
import { Divider, Grid, Header, Item, Reveal, Segment, Statistic, Button } from 'semantic-ui-react'
import { Profile } from '../../models/profile'
import FollowButton from './FollowButton'
import { useAppSelector } from '../../app/hooks'

const ProfileHeader = () => {
    const profile = useAppSelector((store) => store.Profiles.profile)

    return (
        <Segment>
            {profile &&
                <Grid>
                <Grid.Column width={12}>
                        <Item.Group>
                            <Item>
                                <Item.Image avatar size='small' src={profile.image || 'https://upload.wikimedia.org/wikipedia/commons/9/99/Sample_User_Icon.png'}/>
                                <Item.Content verticalAlign='middle'>
                                    <Header as='h1' content={profile.displayName}/>
                                </Item.Content>
                            </Item>
                        </Item.Group>
                </Grid.Column>
                <Grid.Column width={4}>
                    <Statistic.Group widths={2}>
                        <Statistic label='Followers' value={profile.followersCount}/>
                        <Statistic label='Following' value={profile.followingCount}/>
                    </Statistic.Group>
                    <Divider />
                    <Reveal animated='move'>
                        <FollowButton profile={profile}/>
                    </Reveal>
                </Grid.Column>
                </Grid>
            }
        </Segment>
  )
}

export default ProfileHeader