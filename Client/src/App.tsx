import React, { Fragment } from 'react';
import Navbar from './components/layout/Navbar';
import 'semantic-ui-css/semantic.min.css'
import { BrowserRouter as Router, Routes, Route, useNavigate, BrowserRouter } from "react-router-dom";
import { routes as appRoutes } from "./routes";
import SingleActivity from './pages/SingleActivity';
import 'react-calendar/dist/Calendar.css';
import { ToastContainer } from 'react-toastify';
import NotFound from './components/Errors/NotFound';

function App() {
  return (
    <Fragment>
      <ToastContainer position='bottom-right'/>
          <Navbar />
          <Routes>
            {appRoutes.map((route) => (
              <Route
                key={route.key}
                path={route.path}
                element={<route.component />}
              />
            ))}
            <Route path="activities/:id" element={<SingleActivity/>}/>
          </Routes>
    </Fragment>
  );
}

export default App;
