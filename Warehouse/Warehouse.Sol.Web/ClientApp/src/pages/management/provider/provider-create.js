import React, { useState, useEffect } from 'react';
import { HomeOutlined, SaveOutlined } from '@ant-design/icons';
import { Link } from 'react-router-dom';
import { Breadcrumb, Typography, Input, Select, Col, Row, Card, Button, Form } from 'antd';
import axios from 'axios'

const { Option } = Select;
const { Title } = Typography;

const ProviderList = () => {
    
    const [entidadesFinancieras, setEntidadesFinancieras] = useState([]);
    const [form] = Form.useForm();

    const onFinish = (values) => {
        console.log(values);
    };

    useEffect(() => {

        axios.get(`/Provider/GetAll`, {params:{ Nombre: 'Holi' }})
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
                <Breadcrumb.Item><Link to='/Management/Provider'>Proveedor</Link></Breadcrumb.Item>
                <Breadcrumb.Item>Crear</Breadcrumb.Item>
            </Breadcrumb>
            <Title level={3}>Crear Proveedor</Title>
            <Card size="small">

                <Form
                    layout='vertical'
                    form={form}
                    onFinish={onFinish}
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

                        <Col sx={24} lg={8} className="width100">
                            <Form.Item label="Nombre">
                                <Input placeholder="Ingrese el nombre" allowClear />
                            </Form.Item>
                        </Col>
                        <Col sx={24} lg={8} className="width100">
                            <Form.Item label="Tipo Documento">
                                <Select className="width100" >
                                    {
                                        entidadesFinancieras.map((item) =>
                                            <Option key={item.id} value={item.id}>{item.descripcion}</Option>
                                        )
                                    }
                                </Select>
                            </Form.Item>
                        </Col>
                        <Col sx={24} lg={8} className="width100">
                            <Form.Item label="Documento">
                                <Input placeholder="Ingrese el documento" allowClear />
                            </Form.Item>
                        </Col>

                        <Col sx={24} lg={8} className="width100">
                            <Form.Item label="Dirección">
                                <Input placeholder="Ingrese la dirección" allowClear />
                            </Form.Item>
                        </Col>
                        <Col sx={24} lg={8} className="width100">
                            <Form.Item label="Correo">
                                <Input placeholder="Ingrese el correo" allowClear />
                            </Form.Item>
                        </Col>
                        <Col sx={24} lg={8} className="width100">
                            <Form.Item label="Telefono">
                                <Input placeholder="Ingrese el telefono" allowClear />
                            </Form.Item>
                        </Col>

                        <Col sx={24} lg={8} className="width100">
                            <Form.Item label="Tipo Proveedor">
                                <Select className="width100" defaultValue="0">
                                    <Option value="0">Seleccione</Option>
                                    <Option value="1">Factura-Stock</Option>
                                    <Option value="2">Gastos</Option>
                                </Select>
                            </Form.Item>
                        </Col>
                        <Col sx={24} lg={8} className="width100">
                            <Form.Item label="Estado">
                                <Select className="width100" defaultValue="1">
                                    <Option value="1">Activo</Option>
                                    <Option value="2">Inactivo</Option>
                                </Select>
                            </Form.Item>
                        </Col>
                        <Col sx={24} lg={8} className="width100">
                        </Col>

                        <Col sx={24} lg={18} className="width100">
                        </Col>

                        <Col sx={24} lg={3} className="width100">
                            <Form.Item>
                                <Link to='/Management/Provider'>
                                    <Button style={{ float: 'right', width: '100%' }}>
                                        Volver
                                    </Button>
                                </Link>
                            </Form.Item>
                        </Col>
                        <Col sx={24} lg={3} className="width100">
                            <Form.Item>
                                <Link to='#'>
                                    <Button htmlType="submit" style={{ float: 'right', width: '100%' }} type="primary" icon={<SaveOutlined />}>
                                        Guardar
                                    </Button>
                                </Link>
                            </Form.Item>
                        </Col>
                    </Row>
                </Form>
            </Card>
        </div>
    );
};

export default ProviderList