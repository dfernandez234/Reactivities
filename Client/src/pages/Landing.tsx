import React from 'react'
import { Container, Header, Segment, Image, Button } from 'semantic-ui-react';
import { Link } from 'react-router-dom';
import styles from '../styles/Home.module.css'
import { useAppDispatch, useAppSelector } from '../app/hooks';
import { openModalSmall } from '../features/UI/uiSlice';
import LoginForm from '../components/Users/LoginForm';
import RegisterForm from '../components/Users/RegisterForm';

const Landing = () => {
  const modal = useAppSelector((store) => store.UI);
  const dispatch = useAppDispatch();
  const user = useAppSelector((store) => store.Authentication.user);

  return (
    <Segment inverted textAlign='center' vertical className={styles.masthead}>
      <Container text>
        <Header as='h1' inverted>
            <Image size='massive' src='/assets/logo.png' alt='logo' style={{marginBottom: 12}} />
            Reactivities          
        </Header>
        {user && 
          <>
            <Header as='h2' inverted content={`Welcome back ${user.displayName}`}/>
            <Button as={Link} to='/activities' size='huge' inverted>
              Go to activities!
            </Button>
          </>
        }

        {!user && 
          <>
            <Header as='h2' inverted content={`Welcome to Reactivities`}/>
            <Button size='huge' inverted onClick={() => {dispatch(openModalSmall(<LoginForm/>))}}>
              Login
            </Button>
            <Button size='huge' inverted onClick={() => {dispatch(openModalSmall(<RegisterForm/>))}}>
              Register
            </Button>
          </>
        }
        
      </Container>
    </Segment>
  )
}

export default Landing

