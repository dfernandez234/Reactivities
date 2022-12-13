import {Button, Header, Item, Segment, Image, Label} from 'semantic-ui-react'
import React, { Fragment } from 'react'
import { useAppDispatch, useAppSelector } from '../../app/hooks';
import { Link, useNavigate } from 'react-router-dom';
import { toggleCancelActivity, toggleEditing, updateAttendance } from '../../features/Activities/activitesSlice';
import { openModalLarge } from '../../features/UI/uiSlice';
import EditActivityForm from '../Activity/EditActvityForm';

interface props{
    id:string|undefined
}

const activityImageStyle = {
    filter: 'brightness(30%)'
};

const activityImageTextStyle = {
    position: 'absolute',
    bottom: '5%',
    left: '5%',
    width: '100%',
    height: 'auto',
    color: 'white'
};

const ActivityDetailsHeader = (props:props) => {
    const detailedActivity = useAppSelector((state) => state.Activities);
    const dispatch = useAppDispatch();
    const navigate = useNavigate();
    
    const toggleHandler = () => {
        dispatch(openModalLarge(<EditActivityForm/>))
    }

    const updateAttendanceHandler = () => {
        if(detailedActivity){
            dispatch(updateAttendance(detailedActivity.EditingActivity!.activityId));
        }
    }

    const cancelActivityHandle = () => {
        if(detailedActivity){
            dispatch(toggleCancelActivity(detailedActivity.EditingActivity!.activityId))
                .then(() => {navigate('/activities')})
        }
    }

    return (
        <Fragment>
            {detailedActivity.EditingActivity &&
            <Segment.Group>
                    <Segment basic attached='top' style={{padding: '0'}}>
                        {detailedActivity.EditingActivity.isCancelled && 
                            <Label style={{position:'absolute', zIndex: 1000, left: -14, top:20}}
                                ribbon color='red' content='Cancelled'/>
                        }
                        <Image src={`https://thumbs.dreamstime.com/b/wooden-table-food-top-view-cafe-102532611.jpg`} fluid style={activityImageStyle}/>
                        <Segment style={activityImageTextStyle} basic>
                            <Item.Group>
                                <Item>
                                    <Item.Content>
                                        <Header
                                                size='huge'
                                                content={detailedActivity.EditingActivity.title}
                                                style={{color: 'white'}}
                                            />
                                            <p>{detailedActivity.EditingActivity.date}</p>
                                            <p>
                                                Hosted by <strong><Link to={`/profiles/${detailedActivity.EditingActivity.hostUsername}`}>{detailedActivity.EditingActivity.host?.displayName}</Link></strong>
                                            </p>                                
                                    </Item.Content>
                                </Item>
                            </Item.Group>
                        </Segment>
                    </Segment>
                    <Segment clearing attached='bottom'>
                        {detailedActivity.EditingActivity.isHost? (
                            <>
                                <Button 
                                    color={detailedActivity.EditingActivity.isCancelled ? 'green' : 'red'}
                                    floated='left'
                                    basic
                                    content={detailedActivity.EditingActivity.isCancelled ? 'Resume Activity' : 'Cancel Activity'}
                                    onClick={cancelActivityHandle}
                                    loading={detailedActivity.isLoading}
                                />
                                
                                <Button 
                                disabled={detailedActivity.EditingActivity.isCancelled}
                                color='orange' 
                                floated='right'
                                type='button' 
                                onClick={toggleHandler}>
                                    Manage Event
                                </Button>
                            </>
                        ) : detailedActivity.EditingActivity.isGoing ? (
                            <Button disabled={detailedActivity.EditingActivity.isCancelled} onClick={updateAttendanceHandler}>Cancel Attendance</Button>
                        ):(
                            <Button disabled={detailedActivity.EditingActivity.isCancelled} onClick={updateAttendanceHandler} color='teal'>Join Activity</Button>
                        )}
                    </Segment>
                </Segment.Group>
            }
        </Fragment>
    )
}

export default ActivityDetailsHeader