import { Empty } from 'antd';
import React from 'react';

const CustomEmpty = () => (
    <Empty
        imageStyle={{
            height: 60,
        }}
        description={
            <span>
                No Hay Datos
            </span>
        }
    >
    </Empty>
);

export default CustomEmpty;