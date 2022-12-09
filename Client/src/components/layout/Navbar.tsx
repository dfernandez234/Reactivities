import React from 'react';
import { Link, NavLink } from 'react-router-dom';
import { Button, Container, Menu } from 'semantic-ui-react';
import { useAppDispatch } from '../../app/hooks';
import { toggleCreateModal } from '../../features/UI/uiSlice';

const Navbar = () => {
  const dispatch = useAppDispatch();

  return (
    <Menu fixed='top'>
        <Container>
            <Menu.Item header>
                <img src='https://upload.wikimedia.org/wikipedia/commons/a/a7/React-icon.svg' alt='logo' style={{marginRight: '10px'}}/>
                Reactivities
            </Menu.Item>
            <Menu.Item as={NavLink} to='/' name='Activities'/>
            <Menu.Item as={NavLink} to='/errors' name='Errors'/>
            <Menu.Item>
                <Button positive content='Create Activity' type='button' onClick={() => {dispatch(toggleCreateModal())}}/>
            </Menu.Item>
        </Container>
    </Menu>
  )
}

export default Navbar