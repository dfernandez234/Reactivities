import React from 'react';
import { Link, NavLink } from 'react-router-dom';
import { Button, Container, Dropdown, Image, Menu, MenuItem } from 'semantic-ui-react';

const Navbar = () => {
  return (
    <Menu inverted fixed='top'>
        <Container>
            <Menu.Item header>
                <img src='https://upload.wikimedia.org/wikipedia/commons/a/a7/React-icon.svg' alt='logo' style={{marginRight: '10px'}}/>
                Reactivities
            </Menu.Item>
            <Menu.Item name='Activities'/>
            <Menu.Item as={NavLink} to='/errors' name='Errors'/>
            <Menu.Item>
                <Button positive content='Create Activity'/>
            </Menu.Item>
        </Container>
    </Menu>
  )
}

export default Navbar