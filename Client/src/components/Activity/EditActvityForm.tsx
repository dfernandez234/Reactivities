import { Formik, Form } from 'formik'
import React, { useEffect, useState } from 'react'
import { Link, useParams } from 'react-router-dom'
import { Segment, Button } from 'semantic-ui-react'
import { useAppDispatch, useAppSelector } from '../../app/hooks'
import { IActivityCreate } from '../../models/createActivity'
import * as Yup from 'yup'
import { IActivityEdit } from '../../models/editActivity'
import { updateActivity } from '../../features/Activities/activitesSlice'
import MyTextInput from '../Common/Form/TextInput'
import MyTextArea from '../Common/Form/TextArea'
import MySelectInput from '../Common/Form/SelectInput'
import MyDateInput from '../Common/Form/DateInput'
import { categoryOptions } from '../Common/Options/categoryOptions'
import { format } from 'date-fns'
import { closeModalLarge } from '../../features/UI/uiSlice'

const EditActivityForm = () => {
    const [initDate, setDate] = useState<string>('');

    const { id } = useParams();
    const activity = useAppSelector((state) => state.Activities);
    const dispatch = useAppDispatch();

    useEffect(() => {
        if(activity.EditingActivity){
            const date = new Date(activity.EditingActivity.date);
            if(!isNaN(date.getTime())){
                const result = format(date, 'MMMM d, yyyy h:mm aa')
                setDate(result);
            }
        }
    }, [activity.EditingActivity])

    var initialInputs:IActivityCreate = {
        title: '',
        date: initDate,
        description: '',
        category: '',
        city: '',
        venue: ''
    };

    if(activity.EditingActivity){
        initialInputs = {
            title: activity.EditingActivity.title,
            date: initDate,
            description: activity.EditingActivity.description,
            category: activity.EditingActivity.category,
            city: activity.EditingActivity.city,
            venue: activity.EditingActivity.venue
        }
    }

    const validationSchema = Yup.object({
        title: Yup.string().required('The activity title is required'),
        description: Yup.string().required('The activity description is required'),
        category: Yup.string().required('The activity category is required'),
        date: Yup.string().required('The activity date is required'),
        venue: Yup.string().required('The activity venue is required'),
        city: Yup.string().required('The activity city is required'),
    })

    const onSubmitHandler = (updateHandler:IActivityCreate) => {
        const post:IActivityEdit = {
             ActivityId: id,
             data: updateHandler
        }
        dispatch(updateActivity(post));
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

export default EditActivityForm