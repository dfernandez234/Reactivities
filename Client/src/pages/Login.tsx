import React, { Fragment } from 'react'
import { Container } from 'semantic-ui-react';
import LoginForm from '../components/Users/LoginForm';

const Login = () => {
  return (
    <Fragment>
      <Container style={{marginTop: '7em'}}>
        <LoginForm/>
      </Container>
    </Fragment>
  )
}

export default Login

