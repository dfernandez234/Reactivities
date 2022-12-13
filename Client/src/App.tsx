import React, { Fragment, useEffect } from 'react';
import 'semantic-ui-css/semantic.min.css'
import { BrowserRouter as Router, Routes, Route } from "react-router-dom";
import 'react-calendar/dist/Calendar.css';
import { ToastContainer } from 'react-toastify';
import "react-datepicker/dist/react-datepicker.css";
import * as index from './pages/index';
import ModalSmall from './components/Common/Modal/ModalSmall';
import ModalLarge from './components/Common/Modal/ModalLarge';

function App() {
  return (
    <Fragment>
      <ModalSmall/>
      <ModalLarge/>
      <ToastContainer position='bottom-right'/>
          <Routes>
            <Route path='/' element={<index.ProtectedRoute>
              <index.SharedLayout/>
              </index.ProtectedRoute>}
            >
              <Route path='activities' element={<index.Activities/>}/>
              <Route path="activities/:ActivityId" element={<index.SingleActivity/>}/>
              <Route path='errors' element={<index.TestErrors/>}/>
            </Route>
            <Route index path='/landing' element={<index.Landing/>}/>
            <Route path='/login' element={<index.Login/>}/>
            <Route path='/serverError' element={<index.ServerError/>}/>
            <Route path='*' element={<index.NotFound/>} />
          </Routes>
    </Fragment>
  );
}

export default App;
