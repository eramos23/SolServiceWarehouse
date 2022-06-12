import 'bootstrap/dist/css/bootstrap.css';
import React, { StrictMode } from 'react';
import ReactDOM from 'react-dom/client';
import 'antd/dist/antd.css';

import { BrowserRouter } from 'react-router-dom';
import App from './App';
import registerServiceWorker from './registerServiceWorker';

const baseUrl = document.getElementsByTagName('base')[0].getAttribute('href');
const rootElement = document.getElementById('root');

const root = ReactDOM.createRoot(document.getElementById("root"));

root.render(
    <BrowserRouter basename={baseUrl}>
        <App />
    </BrowserRouter>
);


registerServiceWorker();

