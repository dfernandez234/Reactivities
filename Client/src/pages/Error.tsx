import React from 'react'
import { Container } from 'semantic-ui-react';

type Props = {
    children?: JSX.Element | JSX.Element[] | React.ReactElement;
}

const ErrorPage = (props: Props) => {
  return (
    <Container style={{marginTop: '7em'}}>
        {props.children}
    </Container>
  )
}

export default ErrorPage