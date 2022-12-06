import React from 'react';
import ReactDOM from 'react-dom/client';
import App from './App';
import 'react-toastify/dist/ReactToastify.css';

import { Provider } from 'react-redux';
import { store } from './app/store';
import { AxiosInterceptor } from './apis/activities';
import { BrowserRouter, Router } from 'react-router-dom';

const root = ReactDOM.createRoot(
  document.getElementById('root') as HTMLElement
);
root.render(
  <BrowserRouter>
    <Provider store={store}>
      <AxiosInterceptor>
        <App />
      </AxiosInterceptor>
    </Provider>
  </BrowserRouter>
);

