import { Formik, Form, Field, ErrorMessage } from 'formik'
import React from 'react'
import { Segment, Button, Header, Label } from 'semantic-ui-react'
import { useAppDispatch, useAppSelector } from '../../app/hooks'
import * as Yup from 'yup'
import MyTextInput from '../Common/Form/TextInput'
import { registerRequest } from '../../models/users'
import { register } from '../../features/Users/AuthenticationSlice'
import ValidationErrors from '../Errors/ValidationErrors'
import { useNavigate } from 'react-router-dom'
import { closeModalSmall } from '../../features/UI/uiSlice'

const ActivityForm = () => {
    var initialInputs = {displayName: '', username: '', email: '', password: '', error: null}

    const validationSchema = Yup.object({
        displayName: Yup.string().required(),
        username: Yup.string().required(),
        email: Yup.string().required().email(),
        password: Yup.string().required(),
    })

    const Authentication = useAppSelector((store) => store.Authentication);
    const dispatch = useAppDispatch();
    const navigate = useNavigate();

    const onSubmitHandler = (submitObject : any) => { 
        const request:registerRequest = {
            email: submitObject.email,
            username: submitObject.username,
            displayName: submitObject.displayName,
            password: submitObject.password
        }

        dispatch(register(request)).then(() => {
            dispatch(closeModalSmall());
            navigate('/activities');
          });
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
                    <Header as='h2' content='Sign up to Reactivities' color='teal' textAlign='center' />
                    <MyTextInput name='displayName' placeholder='Display Name' />
                    <MyTextInput name='username' placeholder='Username' />
                    <MyTextInput name='email' placeholder='Email' />
                    <MyTextInput name='password' placeholder='Password' type='password' />
                    {Authentication.errors && <ValidationErrors errors={Authentication.errors}/>}
                    <Button disabled={!isValid || !dirty || Authentication.loading} loading={Authentication.loading} positive content='Register' type='submit' fluid />
                </Form>
            )}
            </Formik>
        </Segment>
    )
}

export default ActivityForm