import { Form, Formik } from 'formik'
import React, { Fragment } from 'react'
import { Button, Label } from 'semantic-ui-react'
import { useAppDispatch, useAppSelector } from '../../app/hooks'
import MyTextInput from '../Common/Form/TextInput'
import {LoginRequest} from '../../models/users'
import { login } from '../../features/Users/AuthenticationSlice'
import LoadingScreen from '../../pages/LoadingScreen'
import { useNavigate } from 'react-router-dom'
import { closeModalSmall } from '../../features/UI/uiSlice'

const LoginForm = () => {
  const authResponse = useAppSelector((state) => state.Authentication);
  const dispatch = useAppDispatch();
  const navigate = useNavigate();

  const initialValues:LoginRequest = {email: '', password: ''};

  const submitHandler = (loginRequest:LoginRequest) => {
    dispatch(login(loginRequest)).then(() => {
      dispatch(closeModalSmall());
      navigate('/activities');
    });
  }

  return (
    <Fragment>
      {authResponse.loading && <LoadingScreen/>}
      <Formik
        initialValues={initialValues}
        onSubmit={values => submitHandler(values)}
        >
            {({handleSubmit, isSubmitting}) => (
                <Form className='ui form' onSubmit={handleSubmit} autoComplete='off'>
                    <MyTextInput placeholder='Email' name='email'/>
                    <MyTextInput placeholder='Password' name='password' type='password'/>
                    {!authResponse.loading && authResponse.errors && <Label style={{marginBottom: 10, width:'100%'}} basic color='red' size='large' content={"Invalid Email or Password"}/>}
                    <Button positive content='Login' type='submit' fluid />
                </Form>
            )}

        </Formik> 
    </Fragment>
  )
}

export default LoginForm