import React, { useState, useEffect } from 'react';
import { HomeOutlined } from '@ant-design/icons';
import { Link } from 'react-router-dom';
import { Breadcrumb, Typography, Input, Select, Col, Row, Space, Table, Card, Button, Divider } from 'antd';
import axios from 'axios'

const { Search } = Input;
const { Option } = Select;

const { Title } = Typography;

const Demo = () => {
    const [searching, setSearching] = useState(false);
    const [entidadesFinancieras, setEntidadesFinancieras] = useState([]);
    const onSearch = (value) => {
        setSearching(true)
        setTimeout(() => {
            setSearching(false)
        }, 1000);
        
    }

    const columns = [
        {
            title: 'Name',
            dataIndex: 'name',
            render: (text) => <a>{text}</a>,
        },
        {
            title: 'Age',
            dataIndex: 'age',
            defaultSortOrder: 'descend',
            sorter: (a, b) => a.age - b.age
        },
        {
            title: 'Address',
            dataIndex: 'address',
            sorter: (a, b) => a.address.length - b.address.length
        },
    ];
    const data = [
        {
            key: '1',
            name: 'John Brown',
            age: 32,
            address: 'New York No. 1 Lake Park',
        },
        {
            key: '2',
            name: 'Jim Green',
            age: 42,
            address: 'London No. 1 Lake Park',
        },
        {
            key: '3',
            name: 'Joe Black',
            age: 32,
            address: 'Sidney No. 1 Lake Park',
        },
        {
            key: '4',
            name: 'Disabled User',
            age: 99,
            address: 'Sidney No. 1 Lake Park',
        },
    ]; // rowSelection object indicates the need for row selection

    const rowSelection = {
        onChange: (selectedRowKeys, selectedRows) => {
            console.log(`selectedRowKeys: ${selectedRowKeys}`, 'selectedRows: ', selectedRows);
        },
        getCheckboxProps: (record) => ({
            disabled: record.name === 'Disabled User',
            // Column configuration not to be checked
            name: record.name,
        }),
    };

    const onChangeTable = (pagination, filters, sorter, extra) => {
        console.log('params', pagination, filters, sorter, extra);
    };


    useEffect(() => {
        axios.get(`EntidadFinanciera`)
            .then(res => {
                setEntidadesFinancieras(res.data.data)
                console.log(res.data.data)
            })
    }, [])
    return (
        <div>
            <Breadcrumb
                style={{
                    margin: '16px 0',
                }}
            >
                <Breadcrumb.Item href="/">
                    <HomeOutlined />
                </Breadcrumb.Item>
                <Breadcrumb.Item>Demo</Breadcrumb.Item>
            </Breadcrumb>
            <Title level={3}>Listado de Demostración</Title>
            <Card size="small">
                <Row>
                    <Col sx={24} lg={12}>
                        <Search className="input-pr-pb-2" placeholder="Ingrese texto a buscar" loading={searching} onSearch={onSearch} enterButton />
                    </Col>
                    <Col sx={24} lg={12}>
                        <Input className="pb-1" placeholder="input with clear icon" allowClear />
                    </Col>
                </Row>

                <Select
                    className="pb-2"
                    style={{
                        width: '100%',
                    }}
                    showSearch
                    placeholder="Busca la opción"
                    optionFilterProp="children"
                    filterOption={(input, option) => option.children.includes(input)}
                    filterSort={(optionA, optionB) =>
                        optionA.children.toLowerCase().localeCompare(optionB.children.toLowerCase())
                    }
                >
                    {
                        entidadesFinancieras.map((item) =>
                            <Option key={item.id} value={item.id}>{item.descripcion}</Option>
                            )
                    }
                </Select>

                <Button type="primary" style={{ float: 'right' }}>Buscar</Button>
            </Card>

            <br />
            <Card size="small">
                <Divider />
                <h1>Holi</h1>
                <Table
                    rowSelection={{
                        type: 'checkbox',
                        ...rowSelection,
                    }}
                    columns={columns}
                    dataSource={data}
                    size="small"
                    onChange={onChangeTable}
                />
            </Card>
        </div>
    );
};

export default Demo