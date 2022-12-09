import React from 'react'
import { Container, Modal } from 'semantic-ui-react'
import { useAppDispatch, useAppSelector } from '../../app/hooks'
import { toggleEditModal } from '../../features/UI/uiSlice'
import EditActivityForm from './EditActvityForm'

type Props = {}

const EditActivityModal = (props: Props) => {
    const UI = useAppSelector((state) => state.UI);
    const dispatch = useAppDispatch();

    return (
        <Container style={{margin: '0'}}>
            <Modal
                open={UI.editModalOpen}
                onClose={() => {dispatch(toggleEditModal())}}
                style={{marginTop: '0'}}
                >
                    <Modal.Header>
                        Activity Details
                    </Modal.Header>
                    <Modal.Content>
                        <EditActivityForm/>
                    </Modal.Content>
            </Modal>
        </Container>
    )
}

export default EditActivityModal