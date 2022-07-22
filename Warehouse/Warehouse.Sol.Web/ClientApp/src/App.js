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
import ProductUseList from './pages/management/product-use/product-use-list'
import ProductUseCreate from './pages/management/product-use/product-use-create'
import ProductBrandList from './pages/management/product-brand/product-brand-list'
import ProductBrandCreate from './pages/management/product-brand/product-brand-create'
import LaboratoryList from './pages/management/laboratory/laboratory-list'
import LaboratoryCreate from './pages/management/laboratory/laboratory-create'

import UnitMeasureList from './pages/management/unit-measure/unit-measure-list'
import UnitMeasureCreate from './pages/management/unit-measure/unit-measure-create'


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

                <Route path='/Management/Provider' element={<ProviderList />} />
                <Route path='/Management/Provider/Create' element={<ProviderCreate />} />
                <Route path='/Management/Provider/Edit/:id' element={<ProviderCreate />} />

                <Route path='/Management/Category' element={<CategoryList />} />
                <Route path='/Management/Category/Create' element={<CategoryCreate />} />
                <Route path='/Management/Category/Edit/:id' element={<CategoryCreate />} />

                <Route path='/Management/ProductUse' element={<ProductUseList />} />
                <Route path='/Management/ProductUse/Create' element={<ProductUseCreate />} />
                <Route path='/Management/ProductUse/Edit/:id' element={<ProductUseCreate />} />

                <Route path='/Management/ProductBrand' element={<ProductBrandList />} />
                <Route path='/Management/ProductBrand/Create' element={<ProductBrandCreate />} />
                <Route path='/Management/ProductBrand/Edit/:id' element={<ProductBrandCreate />} />

                <Route path='/Management/ProductBrand' element={<ProductBrandList />} />
                <Route path='/Management/ProductBrand/Create' element={<ProductBrandCreate />} />
                <Route path='/Management/ProductBrand/Edit/:id' element={<ProductBrandCreate />} />

                <Route path='/Management/Laboratory' element={<LaboratoryList />} />
                <Route path='/Management/Laboratory/Create' element={<LaboratoryCreate />} />
                <Route path='/Management/Laboratory/Edit/:id' element={<LaboratoryCreate />} />

                <Route path='/Management/Product' element={<ProductList />} />
                <Route path='/Management/Product/Create' element={<ProductCreate />} />
                <Route path='/Management/Product/Edit/:id' element={<ProductCreate />} />

                <Route path='/Management/UnitMeasure' element={<UnitMeasureList />} />
                <Route path='/Management/UnitMeasure/Create' element={<UnitMeasureCreate />} />
                <Route path='/Management/UnitMeasure/Edit/:id' element={<UnitMeasureCreate />} />

                <Route path='*' element={<h1>404 Not Fount</h1>} />
            </Routes>
        </LayoutLocal>
    );
}

export default AppRoute