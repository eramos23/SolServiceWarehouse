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
    getItem(<Link to='/counter'>counter</Link>, '2', <DesktopOutlined />),
    getItem('User', 'sub1', <UserOutlined />, [
        getItem('Tom', '3'),
        getItem('Bill', '4'),
        getItem('Alex', '5'),
    ]),
    getItem('Team', 'sub2', <TeamOutlined />, [getItem('Team 1', '6'), getItem('Team 2', '8')]),
    getItem(<Link to='/Demo'>Demo</Link>, '9', <FileOutlined />),
];

const MODES = {
    descktop: 1,
    tablete: 2,
    movil: 3
}

export default function SiderLocal({ ...props }) {
    const location = useLocation()
    console.log(location)
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