import React from 'react'
import { Link } from 'react-router-dom'
import { Segment, Header, Icon, Button } from 'semantic-ui-react'
import ErrorPage from '../../pages/Error'

const NotFound = () => {
  return (
    <ErrorPage>
      <Segment placeholder>
          <Header icon>
              <Icon name='search'/>
              Oops - we've looked everywhere and could not find this.
          </Header>
          <Segment.Inline>
              <Button as={Link} to='/' primary>
                  Return to activities page.
              </Button>
          </Segment.Inline>
      </Segment>
    </ErrorPage>
  )
}

export default NotFound