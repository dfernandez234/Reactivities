import { Formik, Form, Field, ErrorMessage } from 'formik'
import React, { useState } from 'react'
import { Link } from 'react-router-dom'
import { Segment, Button } from 'semantic-ui-react'
import { useAppDispatch, useAppSelector } from '../../app/hooks'
import { IActivityCreate } from '../../models/createActivity'
import * as Yup from 'yup'
import MyTextInput from '../Common/Form/TextInput'
import MyTextArea from '../Common/Form/TextArea'
import MySelectInput from '../Common/Form/SelectInput'
import { categoryOptions } from '../Common/Options/categoryOptions'
import MyDateInput from '../Common/Form/DateInput'
import { createActivity } from '../../features/Activities/activitesSlice'
import { closeModalLarge } from '../../features/UI/uiSlice'

const ActivityForm = () => {
    var initialInputs:IActivityCreate = {
        title: '',
        date: '',
        description: '',
        category: '',
        city: '',
        venue: ''
    }

    const validationSchema = Yup.object({
        title: Yup.string().required('The activity title is required'),
        description: Yup.string().required('The activity description is required'),
        category: Yup.string().required('The activity category is required'),
        date: Yup.string().required('The activity date is required'),
        venue: Yup.string().required('The activity venue is required'),
        city: Yup.string().required('The activity city is required'),
    })

    const activity = useAppSelector((state) => state.Activities);
    const dispatch = useAppDispatch();

    const onSubmitHandler = (submitObject : IActivityCreate) => { 
        console.log(submitObject);
        dispatch(createActivity(submitObject));
    }
    
    return (
        <Segment clearing>
            <Formik 
            validationSchema={validationSchema}
            enableReinitialize
            initialValues={initialInputs} 
            onSubmit={values => onSubmitHandler(values)}>
                {({handleSubmit}) =>(
                    <Form className='ui form' onSubmit={handleSubmit} autoComplete='off'>
                        <MyTextInput name='title' placeholder='Title'/>
                        <MyTextArea rows={3} name='description' placeholder='Description'/>
                        <MySelectInput options={categoryOptions} placeholder='Category' name='category'/>
                        <MyDateInput
                            placeholderText='Date'
                            name='date'
                            showTimeSelect
                            timeCaption='time'
                            dateFormat='MMMM d, yyyy h:mm aa'
                        />
                        <MyTextInput name='city' placeholder='City'/>
                        <MyTextInput name='venue' placeholder='Venue'/>
                        <Button loading={activity.isLoading} floated='right' positive type='submit' content='Submit'/>
                        <Button floated='right' type='button' content='Cancel' onClick={() => {dispatch(closeModalLarge())}}/>
                    </Form>
                )}
            </Formik>
        </Segment>
    )
}

export default ActivityForm