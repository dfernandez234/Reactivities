import React from 'react'
import { Link } from 'react-router-dom'
import { List, Image } from 'semantic-ui-react'
import { IActivity } from '../../models/activity'

interface ActivityListAttendeeProps{
    activity: IActivity
}

const ActivityListAttendee = (props:ActivityListAttendeeProps) => {

  
    return (
        <List horizontal>
            {props.activity.attendees.map(attendee => (
                <List.Item key={attendee.username} as={Link} to={`/profiles/${attendee.username}`}>
                    <Image size='mini' circular src='https://upload.wikimedia.org/wikipedia/commons/9/99/Sample_User_Icon.png'/>
                </List.Item>
            ))}
        </List>
    )
}

export default ActivityListAttendee