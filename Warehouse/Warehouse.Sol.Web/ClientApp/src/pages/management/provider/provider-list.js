import React, { useState, useEffect } from 'react';
import { HomeOutlined, SearchOutlined, PlusOutlined, EditTwoTone, DeleteTwoTone } from '@ant-design/icons';
import { Link } from 'react-router-dom';
import FloatInput from "../../../components/FloatInput";
import { Breadcrumb, Typography, Input, Select, Col, Row, Space, Table, Card, Button, Form, Divider, Tag } from 'antd';
import axios from 'axios'

const { Search } = Input;
const { Option } = Select;

const { Title } = Typography;

const ProviderList = () => {
    const [searching, setSearching] = useState(false);
    const [entidadesFinancieras, setEntidadesFinancieras] = useState([]);
    const [form] = Form.useForm();

    const onSearch = (value) => {
        setSearching(true)
        setTimeout(() => {
            setSearching(false)
        }, 1000);
        
    }

    const columns = [
        {
            title: 'Proveedor',
            dataIndex: 'nombre',
            sorter: (a, b) => a.nombre.length - b.nombre.length
        },
        {
            title: 'Tipo Proveedor',
            dataIndex: 'tipoProveedor',
            sorter: (a, b) => a.tipoProveedor.length - b.tipoProveedor.length
        },
        {
            title: 'Tipo Documento',
            dataIndex: 'tipoDocumento',
            sorter: (a, b) => a.tipoDocumento.length - b.tipoDocumento.length
        },
        {
            title: 'Número Documento',
            dataIndex: 'numeroDocumento',
            sorter: (a, b) => a.numeroDocumento.length - b.numeroDocumento.length
        },
        {
            title: 'Estado',
            dataIndex: 'estado',
            sorter: (a, b) => a.estado.length - b.estado.length,
            align: 'center',
            render: (estado) => (
                <Tag color={estado == 'Activo' ? 'success' : 'error'} key={estado}>
                    {estado}
                </Tag>
            )
        },
        {
            title: 'Acciones',
            dataIndex: 'acciones',
            key: 'acciones',
            align: 'center',
            render: (text) => <><Button size="small" icon={<EditTwoTone />} href="#" /> {"  "} <Button size="small" icon={<DeleteTwoTone twoToneColor="#ff4d4f" />} /></>
        },
    ];
    const data = [
        {
            key: '1',
            nombre: 'A Sunarp S.A.C.',
            tipoProveedor: 'Gastos',
            tipoDocumento: 'Ruc',
            numeroDocumento: '20718634761',
            estado: 'Activo'
        },
        {
            key: '2',
            nombre: 'Bonilla Proveedores S.A.C.',
            tipoProveedor: 'Facturación-Stok',
            tipoDocumento: 'Otros',
            numeroDocumento: '71863476',
            estado: 'Inactivo'
        }
    ];

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
                <Breadcrumb.Item>Administración</Breadcrumb.Item>
                <Breadcrumb.Item>Proveedor</Breadcrumb.Item>
                <Breadcrumb.Item>Listar</Breadcrumb.Item>
            </Breadcrumb>
            <Title level={3}>Listado de Proveedorees</Title>
            <Card size="small">

                <Form
                    layout='vertical'
                    form={form}
                    initialValues={{
                        layout: 'vertical',
                    }}
                >
                    <Row gutter={[10, 0]}>
                        <Col sx={24} lg={12} className="width100">
                            <Form.Item label="Empresa">
                                <Select
                                    className="width100"
                                    showSearch
                                    placeholder="Buscar empresa"
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
                            </Form.Item>
                        </Col>
                        <Col sx={24} lg={12} className="width100">
                            <Form.Item label="Sucursal">
                                <Select
                                    className="width100"
                                    showSearch
                                    placeholder="Buscar Sucursal"
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
                            </Form.Item>
                        </Col>
                        <Col sx={24} lg={21} className="width100">
                            <Form.Item>
                                <Input placeholder="Ingrese texto a buscar" allowClear />
                            </Form.Item>
                        </Col>
                        <Col sx={24} lg={3} className="width100">
                            <Form.Item>
                                <Button style={{ float: 'right', width: '100%' }} type="primary" icon={<SearchOutlined />}>
                                    Buscar
                                </Button>
                            </Form.Item>
                        </Col>
                        <Col sx={24} lg={21} className="width100">
                        </Col>
                        <Col sx={24} lg={3} className="width100">
                            <Form.Item>
                                <Link to='/Management/Provider/Create'>
                                    <Button style={{ float: 'right', width: '100%' }} type="primary" icon={<PlusOutlined />}>
                                        Crear
                                    </Button>
                                </Link>
                            </Form.Item>
                        </Col>
                    </Row>
                </Form>

            </Card>

            <br />

            <Card size="small">
                <Table
                    columns={columns}
                    dataSource={data}
                    size="small"
                    showSorterTooltip={false}
                onChange={onChangeTable}
                />
            </Card>
        </div>
    );
};

export default ProviderList