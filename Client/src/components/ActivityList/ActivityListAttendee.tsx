import { profile } from 'console'
import React from 'react'
import { Link } from 'react-router-dom'
import { List, Image, Popup } from 'semantic-ui-react'
import { IActivity } from '../../models/activity'
import ProfileCard from '../Profiles/ProfileCard'

interface ActivityListAttendeeProps{
    activity: IActivity
}

const ActivityListAttendee = (props:ActivityListAttendeeProps) => {
    const styles = {
        borderColor: 'orange',
        borderWidth: 3
    }
  
    return (
        <List horizontal>
            {props.activity.attendees.map(attendee => (
                <Popup
                    hoverable
                    key={attendee.username}
                    trigger={
                        <List.Item key={attendee.username} as={Link} to={`/profiles/${attendee.username}`}>
                            <Image 
                                size='mini' 
                                circular src={attendee.image || 'https://upload.wikimedia.org/wikipedia/commons/9/99/Sample_User_Icon.png'}
                                bordered
                                style={attendee.following ? styles : null}
                            />
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