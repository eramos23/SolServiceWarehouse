import {
    MenuFoldOutlined,
    MenuUnfoldOutlined,
    UserOutlined,
    CaretDownFilled
} from '@ant-design/icons';

import { Layout, Menu, Avatar, Space, Col, Row, Dropdown} from 'antd';
import React, { useState } from 'react';
const { Header } = Layout;

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

export default function HeaderLocal({ ...props }) {
    const [collapsed, setCollapsed] = useState(false);

    return (
        <Header
            style={{
                background: '#70ea8c',
                position: 'fixed', width: '100%', zIndex: 1
            }}
        >
            <Row>
                <Col xs={12} sm={12} md={12} lg={10} xl={8} className="flex">
                    <div className="white p2 a-center" >
                        <img src='https://www.zarla.com/images/zarla-soluciona-1x1-2400x2400-20210603-xv6xrmkbpk3ggkjb6869.png?crop=1:1,smart&width=250&dpr=2' width='40px' />
                    </div>
                    {React.createElement(props.collapsed ? MenuUnfoldOutlined : MenuFoldOutlined, {
                        className: 'trigger',
                        onClick: () => props.setCollapsed(!props.collapsed),
                    })}
                </Col>
                <Col xs={12} sm={12} md={12} lg={14} xl={16} className='header-right'>
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
        );
}