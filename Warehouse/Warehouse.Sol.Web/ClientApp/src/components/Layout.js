import SiderLocal from './main/Sider'
import HeaderLocal from './main/Header'
import '../css/home.css';
import React, { useState } from 'react';
import { Link } from 'react-router-dom';
import { Layout } from 'antd';
const { Content, Footer } = Layout;

const MODES = {
    descktop: 1,
    tablete: 2,
    movil: 3
}


export function LayoutLocal({ children }) {

    const [collapsed, setCollapsed] = useState(false);
    const [appMode, setAppMode] = useState(MODES.descktop);

    
    return (
        <Layout style={{ minHeight: '100vh' }}>
            <SiderLocal
                collapsed={collapsed}
                setCollapsed={setCollapsed}
                appMode={appMode}
                setAppMode={setAppMode}
            />
            
            <Layout className="site-layout">
                <HeaderLocal
                    collapsed={collapsed}
                    setCollapsed={setCollapsed}
                />
                <Content className="site-layout"
                    style={{
                        overflow: 'auto',
                        padding: '0 35px',
                        marginTop: 64,
                        
                        marginLeft: (collapsed && appMode == MODES.movil) ? 0 : collapsed ? 80 : 200,
                        transition: 'all 0.2s'
                    }}
                >
                    <div style={{
                        maxWidth: 1280,
                        marginLeft: 'auto',
                        marginRight: 'auto'
                    }}>
                        {children}
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
}
