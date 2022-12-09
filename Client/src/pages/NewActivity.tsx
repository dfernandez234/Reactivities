import React from 'react'
import { Container } from 'semantic-ui-react'
import ActivityForm from '../components/Activity/ActivityForm'

const NewActivity = () => {
  return (
    <Container style={{marginTop: '7em'}}>
      <ActivityForm/>
    </Container>
  )
}

export default NewActivity