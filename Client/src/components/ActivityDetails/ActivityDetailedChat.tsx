import React from 'react'
import {Segment, Header, Comment, Form, Button} from 'semantic-ui-react'
import { getActivityIdFromLocalStorage } from '../../utils/getActivityFromLocalStorage'
import { commentActions } from '../../features/Comments/CommentSlice';
import { useAppDispatch, useAppSelector } from '../../app/hooks';
import { ChatComment } from '../../models/comment';

const ActivityDetailedChat = () => {
    const ActivityId = getActivityIdFromLocalStorage();
    const dispatch = useAppDispatch();
    const comments = useAppSelector((store) => store.Comments.comments);

    React.useEffect(() => {
      if(ActivityId){
        dispatch(commentActions.startConnecting())
      }
      return() => {
        dispatch(commentActions.stopHubConnection());
        dispatch(commentActions.clearComments());
      };
    }, [dispatch, ActivityId])


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
          {comments.map((comment:ChatComment) => {
            return(
              <Comment key={comment.id}>
                <Comment.Avatar src={comment.image || 'https://upload.wikimedia.org/wikipedia/commons/9/99/Sample_User_Icon.png'}/>
                <Comment.Content>
                  <Comment.Author as='a'>{comment.displayName}</Comment.Author>
                  <Comment.Metadata>
                    <div>{comment.createdAt}</div>
                  </Comment.Metadata>
                  <Comment.Text>{comment.body}</Comment.Text>
                  <Comment.Actions>
                    <Comment.Action>Reply</Comment.Action>
                  </Comment.Actions>
                </Comment.Content>
              </Comment>
            )
          })}

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


