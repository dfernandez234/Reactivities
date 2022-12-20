import React, { Fragment } from 'react'
import { useParams } from 'react-router-dom'
import { Button, Grid } from 'semantic-ui-react'
import { useAppDispatch, useAppSelector } from '../../app/hooks'
import { changeName, clearProfile, getProfileInfo, isCurrentUserCheck } from '../../features/Profiles/ProfilesSlice'
import ProfileContent from './ProfileContent'
import ProfileHeader from './ProfileHeader'

const Profile = () => {
    const userName = useParams().username;
    const dispatch = useAppDispatch();
    const profileData = useAppSelector((store) => store.Profiles)
      
    React.useEffect(() => {
        if(userName){
          dispatch(isCurrentUserCheck(userName));
          dispatch(getProfileInfo(userName))
        }
        return(() => {
          dispatch(clearProfile())
        })
    }, [dispatch, userName])

    return (
      <Fragment>
        {profileData.profile &&
          <Grid>
              <Grid.Column width={16}>
                  <ProfileHeader />
                  <ProfileContent profile={profileData.profile} isCurrentUser={profileData.isCurrentUser}/>
              </Grid.Column>
          </Grid>
        }
      </Fragment>
    )
}

export default Profile