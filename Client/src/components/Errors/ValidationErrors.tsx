import React from 'react'
import { Message } from 'semantic-ui-react'

interface props{
    errors: any;
}

const ValidationErrors = (props:props) => {
  return (
    <Message error>
        {props.errors && (
            <Message.List>
                {props.errors.map((err:any, i: any) => {
                    return(<Message.Item key={i}>{err}</Message.Item>);
                })}
            </Message.List>
        )}
    </Message>
  )
}

export default ValidationErrors