import React from 'react'
import { Segment, List, Item, Label, Image } from 'semantic-ui-react'
import { Link } from 'react-router-dom'
import { Profile } from '../../models/profilte'

interface Props{
  attendees: Profile[]
}

const ActivityDetailedSidebar = (props: Props) => {
  return (
    <>
      <Segment
        textAlign='center'
        style={{ border: 'none' }}
        attached='top'
        secondary
        inverted
        color='teal'
      >
        {props.attendees.length} {props.attendees.length === 1 ? 'Person' : 'People'} Going
      </Segment>
      <Segment attached textAlign='left'>
        <List relaxed divided>
          {props.attendees.map(attendee => (
            <Item style={{position: 'relative'}} key={attendee.username}>
            <Label
              style={{position:'absolute'}}
              color="orange"
              ribbon='right'
            >
              Host
            </Label>
            <Image size='tiny' src={'https://upload.wikimedia.org/wikipedia/commons/9/99/Sample_User_Icon.png'}/>
            <Item.Content verticalAlign='middle'>
              <Item.Header as='h3'>
                <Link to={`/profiles.${attendee.username}`}>{attendee.displayName}</Link>
              </Item.Header>
              <Item.Extra style={{color: 'orange'}}>Following</Item.Extra>
            </Item.Content>
            </Item>
          ))}
        </List>
      </Segment>
    </>
  )
}

export default ActivityDetailedSidebar