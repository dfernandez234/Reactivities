import { createSlice } from "@reduxjs/toolkit";

interface UIState{
    editFormOpen: boolean
    singleActivityCardOpen: boolean
}

const initialState: UIState = {
    editFormOpen: false,
    singleActivityCardOpen: false,
}

export const UISlice = createSlice({
    name: 'ui_slice',
    initialState,
    reducers: {
        openEditForm:(state) => {
            if(!state.editFormOpen){
                state.editFormOpen = true;
            }
        },

        closeEditForm:(state) => {
            if(state.editFormOpen){
                state.editFormOpen = false;
            }
        },

        openSingleActivityCard: (state) => {
            if(!state.singleActivityCardOpen){
                state.singleActivityCardOpen = true;
            }
        },

        closeSingleActivityCard: (state) => {
            if(state.singleActivityCardOpen){
                state.singleActivityCardOpen = false;
            }
        },
    }
})

export const {openEditForm, closeEditForm, openSingleActivityCard, closeSingleActivityCard} = UISlice.actions;
export default UISlice.reducer; 