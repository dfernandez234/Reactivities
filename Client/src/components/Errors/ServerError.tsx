import React from 'react'
import { Container, Header, Segment } from 'semantic-ui-react'
import { useAppSelector } from '../../app/hooks'
import ErrorPage from '../../pages/Error';

const ServerError = () => {
    const serverError = useAppSelector((state) => state.ServerError);

    return (
        <ErrorPage>
            <Container>
                <Header as='h1' content='Server Error'/>
                <Header sub as='h5' color='red' content={serverError.error.title}/>
                {serverError.error.detail &&
                    <Segment>
                        <Header as='h4' content='Stack trace' color='teal'/>
                        <code style={{marginTop:'10px'}}>{serverError.error.detail}</code>
                    </Segment>
                }
            </Container>
        </ErrorPage>
    )
}

export default ServerError