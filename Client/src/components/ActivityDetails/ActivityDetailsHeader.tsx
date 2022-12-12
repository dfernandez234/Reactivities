import {Button, Header, Item, Segment, Image, Label} from 'semantic-ui-react'
import React, { Fragment } from 'react'
import { useAppDispatch, useAppSelector } from '../../app/hooks';
import { Link } from 'react-router-dom';
import { toggleEditing } from '../../features/Activities/activitesSlice';
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
    const detailedActivity = useAppSelector((state) => state.Activities.EditingActivity);
    const dispatch = useAppDispatch();

    const toggleHandler = () => {
        dispatch(openModalLarge(<EditActivityForm/>))
    }

    return (
        <Fragment>
            {detailedActivity &&
            <Segment.Group>
                    <Segment basic attached='top' style={{padding: '0'}}>
                        <Image src={`https://thumbs.dreamstime.com/b/wooden-table-food-top-view-cafe-102532611.jpg`} fluid style={activityImageStyle}/>
                        <Segment style={activityImageTextStyle} basic>
                            <Item.Group>
                                <Item>
                                    <Item.Content>
                                        <Header
                                                size='huge'
                                                content={detailedActivity.title}
                                                style={{color: 'white'}}
                                            />
                                            <p>{detailedActivity.date}</p>
                                            <p>
                                                Hosted by <strong>Bob</strong>
                                            </p>                                
                                    </Item.Content>
                                </Item>
                            </Item.Group>
                        </Segment>
                    </Segment>
                    <Segment clearing attached='bottom'>
                        <Button color='teal' floated='left'>John Activity</Button>
                        <Button floated='left'>Cancel Attendance</Button>
                        <Button color='orange' floated='right' type='button' onClick={toggleHandler}>
                            Manage Event
                        </Button>
                    </Segment>
                </Segment.Group>
            }
        </Fragment>
    )
}

export default ActivityDetailsHeader