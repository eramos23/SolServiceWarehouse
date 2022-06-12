import {
    MenuFoldOutlined,
    MenuUnfoldOutlined,
    DesktopOutlined,
    FileOutlined,
    PieChartOutlined,
    TeamOutlined,
    UserOutlined,
    HomeOutlined
} from '@ant-design/icons';

import './css/home.css';

import { Layout, Menu, Breadcrumb, Avatar } from 'antd';
import React, { useState } from 'react';
const { Header, Sider, Content, Footer } = Layout;

function getItem(label, key, icon, children) {
    return {
        key,
        icon,
        children,
        label,
    };
}

const items = [
    getItem('Option 1', '1', <PieChartOutlined />),
    getItem('Option 2', '2', <DesktopOutlined />),
    getItem('User', 'sub1', <UserOutlined />, [
        getItem('Tom', '3'),
        getItem('Bill', '4'),
        getItem('Alex', '5'),
    ]),
    getItem('Team', 'sub2', <TeamOutlined />, [getItem('Team 1', '6'), getItem('Team 2', '8')]),
    getItem('Files', '9', <FileOutlined />),
];

export default function Home() {
    const [collapsed, setCollapsed] = useState(false);
    return (
        <Layout style={{ minHeight: '100vh' }}>
            <Sider
                style={{
                    overflow: 'auto',
                    height: '100vh',
                    position: 'fixed',
                    left: 0,
                    top: 0,
                    bottom: 0
                }}
                width={250} trigger={null} collapsible collapsed={collapsed}>
                <div className="logo" />
                <Menu
                    theme="dark"
                    defaultSelectedKeys={['1']}
                    items={items}
                />
            </Sider>
            <Layout
                style={{
                    marginLeft: collapsed ? '80px' : '250px',
                    transition: collapsed ? 'all 0.2s' : 'all 0.35s'
                }}
                className="site-layout">
                <Header
                    style={{
                        padding: 0,
                        position: 'fixed', width: '100%', zIndex: 1
                    }}
                >
                    {React.createElement(collapsed ? MenuUnfoldOutlined : MenuFoldOutlined, {
                        className: 'trigger',
                        onClick: () => setCollapsed(!collapsed),
                    })}
                    <Avatar style={{ marginLeft: '71%'}} icon={<UserOutlined />} />
                </Header>
                <Content className="site-layout"
                    style={{
                        padding: '0 50px',
                        marginTop: 64
                    }}
                >
                    <Breadcrumb
                        style={{
                            margin: '16px 0',
                        }}
                    >
                        <Breadcrumb.Item href="#">
                            <HomeOutlined />
                        </Breadcrumb.Item>
                        <Breadcrumb.Item href="#">
                            <span>Application List</span>
                        </Breadcrumb.Item>
                        <Breadcrumb.Item>Application</Breadcrumb.Item>
                    </Breadcrumb>
                 
                    <div
                        className="site-layout-background"
                        style={{
                            padding: 24,
                            minHeight: 360,
                        }}
                    >
                        Bill is a cat.Bill is a cat.Bill is a cat.Bill is a cat.Bill is a cat.Bill is a cat.
                    </div>
                </Content>
                <Footer
                    style={{
                        textAlign: 'center',
                    }}
                >
                    Ant Design ©2018 Created by Ant UED
                </Footer>
            </Layout>
        </Layout>
    );
};

