import {
    DesktopOutlined,
    FileOutlined,
    PieChartOutlined,
    TeamOutlined,
    UserOutlined
} from '@ant-design/icons';


import { Layout, Menu } from 'antd';
import React, { useState } from 'react';
import { Link, useLocation } from 'react-router-dom';
const { Sider } = Layout;

function getItem(label, key, icon, children) {
    return {
        key,
        icon,
        children,
        label
    };
}

const items = [
    getItem(<Link to='/'>Home</Link>, '1', <PieChartOutlined />),
    getItem('Usuario', '2', <UserOutlined />),
    getItem('Administración', 'sub1', <DesktopOutlined />, [
        getItem(<Link to='/Management/Provider'>Proveedor</Link>, '3'),
        getItem('Entidad Financiera', '4'),
        getItem(<Link to='/Management/Product'>Producto</Link>, '5'),
        getItem(<Link to='/Management/Category'>Categoria</Link>, '6'),
        getItem(<Link to='/Management/ProductUse'>Uso de Producto</Link>, '66'),
        getItem(<Link to='/Management/ProductBrand'>Marca</Link>, '7'),
        getItem('Unidad', '8')
    ]),
    getItem('Team', 'sub2', <TeamOutlined />, [getItem('Team 1', '9'), getItem('Team 2', '10')]),
    getItem(<Link to='/Demo'>Demo</Link>, '11', <FileOutlined />),
];

const MODES = {
    descktop: 1,
    tablete: 2,
    movil: 3
}

export default function SiderLocal({ ...props }) {
    const location = useLocation()

    return (
        <Sider
            style={{
                position: 'fixed',
                left: 0,
                top: -5,
                bottom: 0
            }}

            breakpoint="md"
            collapsedWidth={props.appMode == MODES.movil ? "0" : "80"}
            trigger={null} collapsible collapsed={props.collapsed}
            onCollapse={(collapsed, type) => {
                props.setAppMode(MODES.movil)
                props.setCollapsed(collapsed)
            }}>
            <div className="logo" />
            <Menu
                theme="dark"
                mode="inline"
                defaultSelectedKeys={[location.key]}
                items={items}
            />
        </Sider>
        );
}