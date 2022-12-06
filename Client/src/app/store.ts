import {configureStore} from '@reduxjs/toolkit'
import ActivityReducer from '../features/Activities/activitesSlice'
import UIReducer from '../features/UI/uiSlice'
import AllActivitiesReducer from '../features/Activities/allActivitiesSlice'
import ServerErrorReducer from '../features/Errors/ServerErrorSlice'

export const store = configureStore({
    reducer: {
        AllActivities: AllActivitiesReducer,
        Activities:ActivityReducer,
        UI:UIReducer,
        ServerError: ServerErrorReducer
    },
    middleware: (getDefaultMiddleware) => getDefaultMiddleware({
        serializableCheck: false
    }),
});

export type RootState = ReturnType<typeof store.getState>
export type AppDispatch = typeof store.dispatch;