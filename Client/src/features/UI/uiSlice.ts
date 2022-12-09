import { createSlice } from "@reduxjs/toolkit";

interface UIState{
    createModalOpen: boolean
    editModalOpen: boolean
}

const initialState: UIState = {
    createModalOpen: false,
    editModalOpen: false
}

export const UISlice = createSlice({
    name: 'ui_slice',
    initialState,
    reducers: {
        toggleCreateModal(state){
            if(state.editModalOpen)
                state.editModalOpen = !state.editModalOpen

            state.createModalOpen = !state.createModalOpen;
        },
        toggleEditModal(state){
            if(state.createModalOpen)
                state.createModalOpen = !state.createModalOpen
                
            state.editModalOpen = !state.editModalOpen;
        },
    }
})

export const {toggleCreateModal, toggleEditModal} = UISlice.actions;
export default UISlice.reducer; 