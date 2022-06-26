import React from 'react';
import { Route, Routes } from 'react-router';
import { LayoutLocal } from './components/Layout';
import Home from './components/Home';
import Counter from './components/Counter';

import './custom.css'

const AppRoute = () => {

    return (
        <LayoutLocal>
            <Routes>
                <Route path='/' element={<Home />} />
                <Route path='/counter' element={<Counter />} />
            </Routes>
        </LayoutLocal>
    );
}

export default AppRoute