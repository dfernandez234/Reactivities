import React from 'react'
import * as Yup from 'yup'
import { Formik, Form } from 'formik'
import { useAppDispatch, useAppSelector } from '../../../app/hooks'
import { Segment, Button } from 'semantic-ui-react'
import MyTextInput from '../../Common/Form/TextInput'
import ValidationErrors from '../../Errors/ValidationErrors'
import { ProfileEdit } from '../../../models/profile'
import { updateProfile } from '../../../features/Profiles/ProfilesSlice'
import MyTextArea from '../../Common/Form/TextArea'

interface Props{
    closeForm: (sum?:any) => any
}

const EditProfileForm = (props:Props) => {
    const profile = useAppSelector((store) => store.Profiles)

    let initialInputs = {}

    if(profile.profile){
        const bio = profile.profile?.bio === undefined ? '' : profile.profile?.bio;
        initialInputs = {displayName: profile.profile?.displayName, bio: bio}
    }

    const validationSchema = Yup.object({
        displayName: Yup.string().required(),
        bio: Yup.string().required(),
    })

    const dispatch = useAppDispatch();

    const onSubmitHandler = (submitObject : any) => { 
        if(profile.profile){
            const request:ProfileEdit = {
                username: profile.profile?.username,
                displayName: submitObject.displayName,
                bio: submitObject.bio
            }
            dispatch(updateProfile(request)).then(() => {props.closeForm(false)});
        }
    }
    
    return (
        <Segment clearing>
            <Formik 
            validationSchema={validationSchema}
            enableReinitialize
            initialValues={initialInputs} 
            onSubmit={(values, {setErrors}) => onSubmitHandler(values)}>
            {({handleSubmit, isValid, dirty}) => (
                <Form className='ui form error' onSubmit={handleSubmit} autoComplete='off'>
                    <MyTextInput name='displayName' placeholder='Display Name' />
                    <MyTextArea rows={6} name='bio' placeholder='Bio' />
                    {profile.errors && <ValidationErrors errors={profile.errors}/>}
                    <Button disabled={!isValid || !dirty || profile.isLoading} loading={profile.isLoading} positive content='Save Changes' type='submit' fluid />
                </Form>
            )}
            </Formik>
        </Segment>
    )
}

export default EditProfileForm