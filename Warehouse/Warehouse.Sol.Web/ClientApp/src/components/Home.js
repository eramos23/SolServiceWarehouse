import React from 'react';
import { HomeOutlined } from '@ant-design/icons';

import { Breadcrumb } from 'antd';

export default function Home () {
    
    return (
        <div>
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
        </div>
    );
};
