import React from 'react'
import { Fragment } from 'react';
import { useAppSelector } from '../../app/hooks'
import { Header } from 'semantic-ui-react';
import ActivityListItem from './ActivityListItem';
import { IActivity } from '../../models/activity';
import LoadingScreen from '../../pages/LoadingScreen';

const ActivityList = () => {
  const activities = useAppSelector((state) => state.AllActivities);

  if(activities.isLoading) return <LoadingScreen/>
  
  return (
    <>
      {activities.groupedActivities.map(([group, activities]) =>{
        return(
          <Fragment key={group}>
            <Header sub color='teal'>
              {group}
            </Header>
            {activities.map((activity:IActivity) => {
              return(
                <ActivityListItem key={activity.activityId} activity={activity}/>
              )
            })}
          </Fragment>
        )
      })}
    </>
  );
}

export default ActivityList


