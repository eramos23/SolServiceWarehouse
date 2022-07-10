import React, { useState, useEffect } from 'react';
import { HomeOutlined, SearchOutlined, PlusOutlined, EditTwoTone, DeleteTwoTone } from '@ant-design/icons';
import { Link } from 'react-router-dom';
import CustomEmpty from "../../../components/Empty/NoData";
import { Breadcrumb, Typography, Input, Select, Col, Row, Space, Table, Card, Button, Form, Divider, Tag, ConfigProvider } from 'antd';
import axios from 'axios'

const { Search } = Input;
const { Option } = Select;

const { Title } = Typography;

const ProviderList = () => {
    const [searching, setSearching] = useState(false);
    const [companies, setCompanies] = useState([]);
    const [providers, setProviders] = useState([]);
    const [companiBranchs, setCompaniBranchs] = useState([]);

    const [form] = Form.useForm();


    const columns = [
        {
            title: 'Proveedor',
            dataIndex: 'nombre',
            sorter: (a, b) => a.nombre.length - b.nombre.length
        },
        {
            title: 'Tipo Proveedor',
            dataIndex: 'nombreTipoProveedor',
            sorter: (a, b) => a.tipoProveedor.length - b.tipoProveedor.length
        },
        {
            title: 'Tipo Documento',
            dataIndex: 'tipoDocumentoIdentidad',
            render: (tipoDocumento) => (
                tipoDocumento.descripcion
            ),
            sorter: (a, b) => a.tipoDocumento.length - b.tipoDocumento.length
        },
        {
            title: 'Número Documento',
            dataIndex: 'docuemto',
            sorter: (a, b) => a.numeroDocumento.length - b.numeroDocumento.length
        },
        {
            title: 'Estado',
            dataIndex: 'estado',
            sorter: (a, b) => a.estado.length - b.estado.length,
            align: 'center',
            render: (estado) => (
                <Tag color={estado.nombre == 'Activo' ? 'success' : 'error'} key={estado.nombre}>
                    {estado.nombre}
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
    
    const onChangeTable = (pagination, filters, sorter, extra) => {
        console.log('params', pagination, filters, sorter, extra);
    };

    const handleChangeCompanies = (value) => {
        form.resetFields(["IdEmpresaSucursal"]);
        axios.get(`Management/compani-branchs?id=`+value)
            .then(res => {
                setCompaniBranchs(res.data.data)
            })
        
    }

    const handleSeach = (value) => {
        debugger
        setSearching(true)
        axios.get(`Provider/get-list`, { params: value })
            .then(res => {
                setSearching(false)
                setProviders(res.data.data.map((item, i) => {
                    return {
                        key: i,
                        ...item
                    }
                }))
            })

    }

    useEffect(() => {
        axios.get(`Management/companies`)
            .then(res => {
                setCompanies(res.data.data)
            })
        handleSeach()
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
            <ConfigProvider renderEmpty={CustomEmpty}>
            <Card size="small">
                <Form
                    layout='vertical'
                    form={form}
                    name="control-hooks"
                    initialValues={{
                        layout: 'vertical',
                    }}
                    onFinish = {handleSeach}
                >
                    <Row gutter={[10, 0]}>
                        <Col sx={24} lg={12} className="width100">
                            <Form.Item label="Empresa" name="IdEmpresa">
                                <Select
                                    className="width100"
                                    showSearch
                                    placeholder="Buscar empresa"
                                    optionFilterProp="children"
                                    filterOption={(input, option) => option.children.includes(input)}
                                    filterSort={(optionA, optionB) => 
                                        optionA.children.toLowerCase().localeCompare(optionB.children.toLowerCase())
                                    }
                                    onChange={handleChangeCompanies}
                                >
                                    {
                                        companies.map((item) =>
                                            <Option key={item.id} value={item.id}>{item.nombre}</Option>
                                        )
                                    }
                                </Select>
                            </Form.Item>
                        </Col>
                        <Col sx={24} lg={12} className="width100">
                            <Form.Item label="Sucursal" name="IdEmpresaSucursal">
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
                                        companiBranchs.map((item) =>
                                            <Option key={item.id} value={item.id}>{item.descripcion}</Option>
                                        )
                                    }
                                </Select>
                            </Form.Item>
                        </Col>
                        <Col sx={24} lg={21} className="width100">
                            <Form.Item name="Texto">
                                <Input placeholder="Ingrese texto a buscar" allowClear />
                            </Form.Item>
                        </Col>
                        <Col sx={24} lg={3} className="width100">
                            <Form.Item>
                                <Button style={{ float: 'right', width: '100%' }} htmlType="submit" type="primary" icon={<SearchOutlined />} loading={searching}>
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
            </ConfigProvider>
            <br />
            <ConfigProvider renderEmpty={CustomEmpty}>
            <Card size="small">
                <Table
                    columns={columns}
                    dataSource={providers}
                    size="small"
                    showSorterTooltip={false}
                onChange={onChangeTable}
                />
                </Card>
            </ConfigProvider>
        </div>
    );
};

export default ProviderList