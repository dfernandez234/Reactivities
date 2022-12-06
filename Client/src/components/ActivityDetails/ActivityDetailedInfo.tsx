import React from 'react'
import { useAppSelector } from '../../app/hooks'
import {Segment, Grid, Icon} from 'semantic-ui-react'

const ActivityDetailedInfo = () => {
  const detailedActivity = useAppSelector((state) => state.Activities.EditingActivity); 
  const date1 = new Date(detailedActivity.date);

  return (
      <Segment.Group>
            <Segment attached='top'>
                <Grid>
                    <Grid.Column width={1}>
                        <Icon size='large' color='teal' name='info'/>
                    </Grid.Column>
                    <Grid.Column width={15}>
                        <p>{detailedActivity.description}</p>
                    </Grid.Column>
                </Grid>
            </Segment>
            <Segment attached>
                <Grid verticalAlign='middle'>
                    <Grid.Column width={1}>
                        <Icon name='calendar' size='large' color='teal'/>
                    </Grid.Column>
                    <Grid.Column width={15}>
            <span>
                {date1.toString().split('G')[0]}
            </span>
                    </Grid.Column>
                </Grid>
            </Segment>
            <Segment attached>
                <Grid verticalAlign='middle'>
                    <Grid.Column width={1}>
                        <Icon name='marker' size='large' color='teal'/>
                    </Grid.Column>
                    <Grid.Column width={11}>
                        <span>{detailedActivity.venue}, {detailedActivity.city}</span>
                    </Grid.Column>
                </Grid>
            </Segment>
        </Segment.Group>
  )
}

export default ActivityDetailedInfo