import React from 'react'
import { Container, Modal } from 'semantic-ui-react';
import { useAppDispatch, useAppSelector } from '../../../app/hooks';
import { closeModalLarge } from '../../../features/UI/uiSlice';

const ModalLarge = () => {
    const UI = useAppSelector((state) => state.UI);
    const dispatch = useAppDispatch();

    return (
        <Container style={{margin: '0'}}>
            <Modal
                open={UI.openLarge}
                onClose={() => {dispatch(closeModalLarge())}}
                style={{marginTop: '0'}}
                >
                    <Modal.Header>
                        Activity Details
                    </Modal.Header>
                    <Modal.Content>
                        {UI.body}
                    </Modal.Content>
            </Modal>
        </Container>
    )
}

export default ModalLarge