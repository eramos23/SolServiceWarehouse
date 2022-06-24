import {
    MenuFoldOutlined,
    MenuUnfoldOutlined,
    DesktopOutlined,
    FileOutlined,
    PieChartOutlined,
    TeamOutlined,
    UserOutlined,
    HomeOutlined,
    CaretDownFilled
} from '@ant-design/icons';

import './css/home.css';

import { Layout, Menu, Breadcrumb, Avatar, Space, Col, Row, Dropdown, Icon} from 'antd';
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

const menuRight = (
    <Menu
        items={[
            {
                key: '1',
                label: (
                    <a target="_blank" rel="noopener noreferrer" href="#">
                        Mi perfil
                    </a>
                ),
            },
            {
                key: '2',
                label: (
                    <a target="_blank" rel="noopener noreferrer" href="#">
                        Cerrar Sesion
                    </a>
                ),
            }
        ]}
    />
);
const MODES = {
    descktop: 1,
    tablete: 2,
    movil: 3
}

export default function Home() {
    const [collapsed, setCollapsed] = useState(false);
    const [appMode, setAppMode] = useState(MODES.descktop);

    const descktopMenu = {
        breakpoint: "md",
        collapsedWidth: "0"
    }
    const movilMenu = {
        collapsible: "true"
    }

    return (
        <Layout style={{ minHeight: '100vh' }}>
            <Sider
                style={{
                    position: 'fixed',
                    left: 0,
                    top: -5,
                    bottom: 0
                }}

                breakpoint="md"
                collapsedWidth={appMode == MODES.movil ? "0" : "80"}
                trigger={null} collapsible collapsed={collapsed}
                onCollapse={(collapsed, type) => {
                    console.log(collapsed, type);
                    setAppMode(MODES.movil)
                    setCollapsed(collapsed)
                }}>
                <div className="logo" />
                <Menu
                    theme="dark"
                    mode="inline"
                    defaultSelectedKeys={['1']}
                    items={items}
                />
            </Sider>
            
            <Layout className="site-layout">
                <Header
                    style={{
                        background: '#70ea8c',
                        position: 'fixed', width: '100%', zIndex: 1
                    }}
                >
                    <Row>
                        <Col span={18} className="flex">
                            <div className="white p2 a-center" >
                                <img src='https://www.zarla.com/images/zarla-soluciona-1x1-2400x2400-20210603-xv6xrmkbpk3ggkjb6869.png?crop=1:1,smart&width=250&dpr=2' width='40px' />
                            </div>
                            {React.createElement(collapsed ? MenuUnfoldOutlined : MenuFoldOutlined, {
                                className: 'trigger',
                                onClick: () => setCollapsed(!collapsed),
                            })}
                        </Col>
                        <Col span={6} className='header-right'>
                            <Space size={10} className="mr10">
                                <div>
                                    <div className="local-layout-header">raicer1996@gmail.com</div>
                                    <div className="company-name local-layout-header">Farmaceutica Ramos S.A</div>
                                </div>
                            </Space>
                            <Space size={0}>
                                <Dropdown overlay={menuRight} placement="bottomLeft">
                                    <div>
                                        <Avatar
                                            src="https://upload.wikimedia.org/wikipedia/commons/thumb/1/12/User_icon_2.svg/1200px-User_icon_2.svg.png"
                                            size={28}
                                            style={{ verticalAlign: "middle" }}
                                            icon={<UserOutlined />}
                                        />
                                        <CaretDownFilled />
                                    </div>
                                </Dropdown>
                            </Space>
                        </Col>
                    </Row>
                </Header>
                <Content className="site-layout"
                    style={{
                        overflow: 'auto',
                        padding: '0 35px',
                        marginTop: 64,
                        marginLeft: (collapsed && appMode == MODES.movil) ? 0
                            : collapsed ? 80 : 200,
                        transition: 'all 0.2s'
                    }}
                    /*
                    style={{
                        padding: '0 35px',
                        marginTop: 64,
                        marginLeft: collapsed ? 80 : 200,
                        transition: 'all 0.2s'
                    }}
                    */
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
                            minHeight: 760,
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

