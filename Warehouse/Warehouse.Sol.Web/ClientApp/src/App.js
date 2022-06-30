import React from 'react';
import { Route, Routes } from 'react-router';
import { LayoutLocal } from './components/Layout';
import Home from './components/Home';
import Counter from './components/Counter';
import Demo from './pages/demo/demo-list'
import axios from 'axios'

import './custom.css'

axios.defaults.baseURL = 'http://localhost:32553/'

const AppRoute = () => {

    return (
        <LayoutLocal>
            <Routes>
                <Route path='/' element={<Home />} />
                <Route path='/counter' element={<Counter />} />
                <Route path='/Demo' element={<Demo />} />
            </Routes>
        </LayoutLocal>
    );
}

export default AppRoute