import React from 'react'
import { Dimmer, Loader, Image, Segment, Container } from 'semantic-ui-react'

const LoadingScreen = () => {
  return (
    <Container>
      <Dimmer active inverted>
        <Loader inverted content='Loading' />
      </Dimmer>

      <Image src='https://react.semantic-ui.com/images/wireframe/short-paragraph.png' />
    </Container>
  )
}

export default LoadingScreen