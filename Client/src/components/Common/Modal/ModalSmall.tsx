import React from 'react'
import { Modal } from 'semantic-ui-react'
import { useAppDispatch, useAppSelector } from '../../../app/hooks'
import { closeModalSmall } from '../../../features/UI/uiSlice';
import { clearInputs } from '../../../features/Users/AuthenticationSlice';

const ModalSmall = () => {
    const modal = useAppSelector((store) => store.UI);
    const dispatch = useAppDispatch();

    return (
        <Modal 
            open={modal.open} 
            onClose={() => {dispatch(closeModalSmall()); dispatch(clearInputs())}} 
            size='mini'
            dimmer="blurring">
            <Modal.Content>
                {modal.body}
            </Modal.Content>
        </Modal>
    )
}

export default ModalSmall