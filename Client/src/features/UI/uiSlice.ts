import { createSlice, PayloadAction } from "@reduxjs/toolkit";
import { JsxElement } from "typescript";

interface UIState{
    open: boolean;
    openLarge: boolean;
    body: JSX.Element | null,

    dimmerOpen: boolean
}

const initialState: UIState = {
    open: false,
    openLarge: false,
    body: null,

    dimmerOpen: false
}

export const UISlice = createSlice({
    name: 'ui_slice',
    initialState,
    reducers: {
        openModalSmall:(state, action:PayloadAction<JSX.Element>) => {
            state.open = true;
            state.body = action.payload;
        },

        closeModalSmall:(state) => {
            state.open = false;
            state.body = null;
        },

        openModalLarge:(state, action:PayloadAction<JSX.Element>) => {
            state.openLarge = true;
            state.body = action.payload;
        },

        closeModalLarge:(state) => {
            state.openLarge = false;
            state.body = null;
        },

        handleDimmerShow:(state) => {
            state.dimmerOpen = true;
        },
        handleDimmerHide:(state) => {
            state.dimmerOpen = false;
        }
    }
})

export const {openModalSmall, closeModalSmall, openModalLarge, closeModalLarge, handleDimmerHide, handleDimmerShow} = UISlice.actions;
export default UISlice.reducer; 