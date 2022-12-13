import React from 'react'
import { IActivity } from '../../models/activity'
import { Button, Icon, Item, Label, Segment } from 'semantic-ui-react';
import { Link } from 'react-router-dom'
import ActivityListAttendee from './ActivityListAttendee';

interface Props{
  activity: IActivity
}

const ActivityListItem = (props:Props) => {
  return (
    <Segment.Group>
      <Segment>
        {props.activity.isCancelled &&
          <Label attached='top' color='red' content='Cancelled' style={{textAlign: 'center'}}/>
        }
        <Item.Group>
          <Item>
            <Item.Image style={{marginBottom: 5}} size='tiny' circular src={'https://upload.wikimedia.org/wikipedia/commons/9/99/Sample_User_Icon.png'} />
            <Item.Content>
              <Item.Header as={Link} to={`/activities/${props.activity.activityId}`}>
                {props.activity.title}
              </Item.Header>
              <Item.Description>
                {props.activity.isHost && (
                  <Item.Description>
                    <Label basic color='orange'>
                      You are hosting this activity
                    </Label>
                  </Item.Description>
                )}
                {props.activity.isGoing && !props.activity.isHost && (
                  <Item.Description>
                    <Label basic color='green'>
                      You are attending this activity
                    </Label>
                  </Item.Description>
                )}
              </Item.Description>
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
        <ActivityListAttendee activity={props.activity}/>
      </Segment>
      <Segment clearing>
        <span>{props.activity.description}</span>
        <Button
          as={Link}
          to={`/activities/${props.activity.activityId}`}
          color='teal'
          floated='right'
          content='View'
        /> 
      </Segment>
    </Segment.Group>
  )
}

export default ActivityListItem