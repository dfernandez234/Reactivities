import React from 'react'
import { IActivity } from '../../models/activity'
import { Button, Icon, Item, Label, Segment } from 'semantic-ui-react';
import { Link } from 'react-router-dom'

interface Props{
  activity: IActivity
}

const ActivityListItem = (props:Props) => {
  return (
    <Segment.Group>
      <Segment>
        <Item.Group>
          <Item>
            <Item.Image style={{marginBottom: 5}} size='tiny' circular src={'https://upload.wikimedia.org/wikipedia/commons/9/99/Sample_User_Icon.png'} />
            <Item.Content>
              <Item.Header as={Link} to={`/activities/${props.activity.id}`}>
                {props.activity.title}
              </Item.Header>
              <Item.Description>Hosted by Bob</Item.Description>
            </Item.Content>
          </Item>
        </Item.Group>
      </Segment>
      <Segment>
        <span>
          <Icon name='clock' /> {props.activity.date}
          <Icon name='marker' /> {props.activity.venue}
        </span>
      </Segment>
      <Segment secondary>
        Attendees go here
      </Segment>
      <Segment clearing>
        <span>{props.activity.description}</span>
        <Button
          as={Link}
          to={`/activities/${props.activity.id}`}
          color='teal'
          floated='right'
          content='View'
        /> 
      </Segment>
    </Segment.Group>
  )
}

export default ActivityListItem