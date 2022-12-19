import React from 'react'
import {Segment, Header, Comment, Button} from 'semantic-ui-react'
import { getActivityIdFromLocalStorage } from '../../utils/getActivityFromLocalStorage'
import { addComment, commentActions } from '../../features/Comments/CommentSlice';
import { useAppDispatch, useAppSelector } from '../../app/hooks';
import { ChatComment } from '../../models/comment';
import { Formik, Form, Field, FieldProps } from 'formik';
import * as Yup from "yup";
import MyTextArea from '../Common/Form/TextArea';
import { formatDistanceToNow } from 'date-fns';

const ActivityDetailedChat = () => {
    const ActivityId = getActivityIdFromLocalStorage();
    const dispatch = useAppDispatch();
    const comments = useAppSelector((store) => store.Comments);

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
        <Header as='h3' dividing>
          Comments
        </Header>
          {comments.comments.map((comment:ChatComment) => {
            return(
              <Comment key={comment.id}>
                <Comment.Avatar src={comment.image || 'https://upload.wikimedia.org/wikipedia/commons/9/99/Sample_User_Icon.png'}/>
                <Comment.Content>
                  <Comment.Author as='a'>{comment.displayName}</Comment.Author>
                  <Comment.Metadata>
                    <div>{formatDistanceToNow(comment.createdAt)} ago</div>
                  </Comment.Metadata>
                  <Comment.Text>{comment.body}</Comment.Text>
                </Comment.Content>
              </Comment>
            )
          })}
        </Comment.Group>

        <Formik
          onSubmit={(values, { resetForm }) =>
          dispatch(addComment(values)).then(() => resetForm())}
          initialValues={{ body: "" }}
          validationSchema={Yup.object({
            body: Yup.string().required()
          })}
        >
          {({ isSubmitting, isValid, handleSubmit }) => (
            <Form className='ui form'>
              <MyTextArea placeholder='Add Comment' name='body' rows={2}/>
              <Button
                loading={comments.isLoading}
                disabled={isSubmitting || !isValid}
                content='Add Reply'
                labelPosition='left'
                icon='edit'
                primary
                type='submit'
                floated='right'
              />
            </Form>
          )}                
        </Formik>
      </Segment>     
    </>
    )
}

export default ActivityDetailedChat


