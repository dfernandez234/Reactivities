import React from 'react'
import {Segment, Header, Comment, Form, Button} from 'semantic-ui-react'

const ActivityDetailedChat = () => {
  return (
   <>
    <Segment
      textAlign='center'
      attached='top'
      inverted
      color='teal'
      style={{border: 'none'}}
    >
      <Header>Chat about this event</Header>
    </Segment> 
    <Segment attached clearing>
      <Comment.Group>
        <Comment>
          <Comment.Avatar src='https://upload.wikimedia.org/wikipedia/commons/9/99/Sample_User_Icon.png'/>
          <Comment.Content>
            <Comment.Author as='a'>Matt</Comment.Author>
            <Comment.Metadata>
              <div>Today at 5:42PM</div>
            </Comment.Metadata>
            <Comment.Text>How Artistic!</Comment.Text>
            <Comment.Actions>
              <Comment.Action>Reply</Comment.Action>
            </Comment.Actions>
          </Comment.Content>
        </Comment>

        <Comment>
          <Comment.Avatar src='https://upload.wikimedia.org/wikipedia/commons/9/99/Sample_User_Icon.png'/>
          <Comment.Content>
            <Comment.Author as='a'>Joe Henderson</Comment.Author>
            <Comment.Metadata>
              <div>5 days ago</div>
            </Comment.Metadata>
            <Comment.Text>Dude, this is awesome. Thank you so much.</Comment.Text>
            <Comment.Actions>
              <Comment.Action>Reply</Comment.Action>
            </Comment.Actions>
          </Comment.Content>
        </Comment>

        <Form reply>  
          <Form.TextArea>
          </Form.TextArea>
          <Button
              content='Add Reply'
              labelPosition='left'
              icon='edit'
              primary
          />
        </Form>

      </Comment.Group>
    </Segment>     
   </>
  )
}

export default ActivityDetailedChat