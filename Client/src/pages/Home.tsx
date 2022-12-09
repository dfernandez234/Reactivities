import React, { Fragment } from 'react'
import ActivityList from '../components/ActivityList/ActivityList'
import { useAppDispatch } from '../app/hooks'
import { getAllActivities } from '../features/Activities/allActivitiesSlice';
import { Container, Grid } from 'semantic-ui-react';
import ActivityFilters from '../components/ActivityList/ActivityFilters';

const Home = () => {
  const dispatch = useAppDispatch();

  React.useEffect(() => {
    dispatch(getAllActivities());
  }, [dispatch])



  return (
    <Fragment>
      <Container style={{marginTop: '7em'}}>
        <Grid>
          <Grid.Column width='10'>
            <ActivityList/>
          </Grid.Column>
          <Grid.Column width='6'>
            <ActivityFilters/>
          </Grid.Column>
        </Grid>
      </Container>
    </Fragment>
  )
}

export default Home

