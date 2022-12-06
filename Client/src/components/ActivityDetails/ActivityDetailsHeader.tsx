import {Button, Header, Item, Segment, Image, Label} from 'semantic-ui-react'
import React from 'react'
import { useAppSelector } from '../../app/hooks';

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

const ActivityDetailsHeader = () => {
    const detailedActivity = useAppSelector((state) => state.Activities.EditingActivity);
    
    return (
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
                <Button color='teal'>John Activity</Button>
                <Button>Cancel Attendance</Button>
                <Button color='orange' floated='right'>
                    Manage Event
                </Button>
            </Segment>
        </Segment.Group>
    )
}

export default ActivityDetailsHeader