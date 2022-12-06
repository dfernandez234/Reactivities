import React from 'react';
import {Button, Container, Header, Segment} from "semantic-ui-react";
import axios from '../../apis/activities';
import { useAppDispatch } from '../../app/hooks';
import { setError } from '../../features/Errors/ServerErrorSlice';
import ValidationErrors from './ValidationErrors';

export default function TestErrors() {
    const baseUrl = 'https://localhost:7238/';
    const [errors, setErrors] = React.useState(null);
    const dispatch = useAppDispatch();

    function handleNotFound() {
        axios['get'](baseUrl + 'buggy/not-found').catch(err => console.log(err.response));
    }

    function handleBadRequest() {
        axios['get'](baseUrl + 'buggy/bad-request').catch(err => console.log(err.response));
    }

    function handleServerError() {
        axios['get']('buggy/server-error').catch(err => dispatch(setError(err.response.data)));
    }

    function handleUnauthorised() {
        axios['get'](baseUrl + 'buggy/unauthorised').catch(err => console.log(err.response));
    }

    function handleBadGuid() {
        axios['get'](baseUrl + 'activities/notaguid').catch(err => console.log(err.response));
    }

    function handleValidationError() {
        axios['post']('activities', {}).catch(err => dispatch(setError(err.response)));
    }

    return (
        <Container style={{marginTop: '7em'}}>
            <Header as='h1' content='Test Error component' />
            <Segment>
                <Button.Group widths='7'>
                    <Button onClick={handleNotFound} content='Not Found' basic primary />
                    <Button onClick={handleBadRequest} content='Bad Request' basic primary />
                    <Button onClick={handleValidationError} content='Validation Error' basic primary />
                    <Button onClick={handleServerError} content='Server Error' basic primary />
                    <Button onClick={handleUnauthorised} content='Unauthorised' basic primary />
                    <Button onClick={handleBadGuid} content='Bad Guid' basic primary />
                </Button.Group>
            </Segment>
            {errors && 
                <ValidationErrors errors={errors}/>
            }
        </Container>
    )
}
