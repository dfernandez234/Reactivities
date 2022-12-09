import React from 'react'
import { Button, Container, Modal } from 'semantic-ui-react'
import { useAppDispatch, useAppSelector } from '../../app/hooks'
import { toggleCreateModal } from '../../features/UI/uiSlice'
import ActivityForm from './ActivityForm'

type Props = {}

const NewActivityModal = (props: Props) => {
    const UI = useAppSelector((state) => state.UI);
    const dispatch = useAppDispatch();

    return (
        <Container style={{margin: '0'}}>
            <Modal
                open={UI.createModalOpen}
                onClose={() => {dispatch(toggleCreateModal())}}
                style={{marginTop: '0'}}
                >
                    <Modal.Header>
                        New Activity Details
                    </Modal.Header>
                    <Modal.Content>
                        <ActivityForm/>
                    </Modal.Content>
            </Modal>
        </Container>
    )
}

export default NewActivityModal