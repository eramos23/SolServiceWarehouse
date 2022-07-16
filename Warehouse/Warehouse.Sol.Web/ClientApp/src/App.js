import React from 'react';
//import { Route, Routes } from 'react-router';
import { BrowserRouter, Route, Routes } from 'react-router-dom'
import { LayoutLocal } from './components/Layout';
import Home from './components/Home';
import Counter from './components/Counter';
import Demo from './pages/demo/demo-list'
import ProviderList from './pages/management/provider/provider-list'
import ProviderCreate from './pages/management/provider/provider-create'
import ProductList from './pages/management/product/product-list'
import ProductCreate from './pages/management/product/product-create'
import CategoryList from './pages/management/category/category-list'
import CategoryCreate from './pages/management/category/category-create'

import axios from 'axios'

import './custom.css'

axios.defaults.baseURL = 'http://localhost:32553/'

const AppRoute = () => {
    return (
        <LayoutLocal>
            <Routes>
                <Route path='/' element={<Home />} />
                <Route path='/Counter' element={<Counter />} />
                <Route path='/Demo' element={<Demo />} />

                <Route path='/Management/Category' element={<CategoryList />} />
                <Route path='/Management/Category/Create' element={<CategoryCreate />} />
                <Route path='/Management/Category/Edit/:id' element={<CategoryCreate />} />

                <Route path='/Management/Provider' element={<ProviderList />} />
                <Route path='/Management/Provider/Create' element={<ProviderCreate />} />
                <Route path='/Management/Provider/Edit/:id' element={<ProviderCreate />} />

                <Route path='/Management/Product' element={<ProductList />} />
                <Route path='/Management/Product/Create' element={<ProductCreate />} />
                <Route path='/Management/Product/Edit/:id' element={<ProductCreate />} />

                <Route path='*' element={<h1>404 Not Fount</h1>} />
            </Routes>
        </LayoutLocal>
    );
}

export default AppRoute