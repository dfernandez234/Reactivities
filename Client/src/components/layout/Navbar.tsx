import React from 'react';
import { Link, NavLink, useNavigate } from 'react-router-dom';
import { Button, Container, Menu, Image, Dropdown } from 'semantic-ui-react';
import { useAppDispatch, useAppSelector } from '../../app/hooks';
import { openModalLarge } from '../../features/UI/uiSlice';
import { logout } from '../../features/Users/AuthenticationSlice';
import ActivityForm from '../Activity/ActivityForm';

const Navbar = () => {
  const dispatch = useAppDispatch();
  const user = useAppSelector((store) => store.Profiles.profile);
  const navigate = useNavigate();

  const logoutHandler = () => {
    dispatch(logout());
    navigate('/landing');
  }

  return (
    <Menu fixed='top'>
        <Container>
            <Menu.Item header>
                <img src='https://upload.wikimedia.org/wikipedia/commons/a/a7/React-icon.svg' alt='logo' style={{marginRight: '10px'}}/>
                Reactivities
            </Menu.Item>
            <Menu.Item as={NavLink} to='/activities' name='Activities'/>
            <Menu.Item as={NavLink} to='/errors' name='Errors'/>
            <Menu.Item>
                <Button positive content='Create Activity' type='button' onClick={() => {dispatch(openModalLarge(<ActivityForm/>))}}/>
            </Menu.Item>
            <Menu.Item position='right'>
              <div>
                <Image src={user?.image} avatar style={{marginTop: 1, marginLeft: 1}}/>
              </div>
              <Dropdown pointing='top left' text={user?.displayName} style={{marginLeft: 2}}>
                <Dropdown.Menu>
                  <Dropdown.Item as={Link} to={`/profiles/${user?.username}`} text="My Profile"/>
                  <Dropdown.Item onClick={logoutHandler} icon='power'/>
                </Dropdown.Menu>
              </Dropdown>
            </Menu.Item>
        </Container>
    </Menu>
  )
}

export default Navbar