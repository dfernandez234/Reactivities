import React, { Fragment } from 'react'
import { useParams } from 'react-router-dom'
import { Grid } from 'semantic-ui-react'
import { useAppDispatch, useAppSelector } from '../../app/hooks'
import { getProfileInfo } from '../../features/Profiles/ProfilesSlice'
import ProfileContent from './ProfileContent'
import ProfileHeader from './ProfileHeader'

const Profile = () => {
    const userName = useParams().username;
    const dispatch = useAppDispatch();
    const profileData = useAppSelector((store) => store.Profiles.profile)
      
    React.useEffect(() => {
        if(userName){
          dispatch(getProfileInfo(userName))
        }
    }, [dispatch, userName])

    return (
      <Fragment>
        {profileData &&
          <Grid>
              <Grid.Column width={16}>
                  <ProfileHeader profile={profileData}/>
                  <ProfileContent/>
              </Grid.Column>
          </Grid>
        }
      </Fragment>
    )
}

export default Profile