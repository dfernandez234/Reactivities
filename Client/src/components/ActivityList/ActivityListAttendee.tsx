import React from 'react'
import { Link } from 'react-router-dom'
import { List, Image, Popup } from 'semantic-ui-react'
import { IActivity } from '../../models/activity'
import ProfileCard from '../Profiles/ProfileCard'

interface ActivityListAttendeeProps{
    activity: IActivity
}

const ActivityListAttendee = (props:ActivityListAttendeeProps) => {

  
    return (
        <List horizontal>
            {props.activity.attendees.map(attendee => (
                <Popup
                    hoverable
                    key={attendee.username}
                    trigger={
                        <List.Item key={attendee.username} as={Link} to={`/profiles/${attendee.username}`}>
                            <Image size='mini' circular src='https://upload.wikimedia.org/wikipedia/commons/9/99/Sample_User_Icon.png'/>
                        </List.Item>
                    }
                >
                    <Popup.Content>
                        <ProfileCard profile={attendee} />
                    </Popup.Content>
                </Popup>
            ))}
        </List>
    )
}

export default ActivityListAttendee