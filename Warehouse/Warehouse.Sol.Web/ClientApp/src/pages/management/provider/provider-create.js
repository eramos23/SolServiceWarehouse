import React, { useState, useEffect } from 'react';
import { HomeOutlined, SaveOutlined } from '@ant-design/icons';
import { Link } from 'react-router-dom';
import CustomEmpty from "../../../components/Empty/NoData";
import { Breadcrumb, Typography, Input, Select, Col, Row, Card, Button, Form, ConfigProvider } from 'antd';
import axios from 'axios'

const { Option } = Select;
const { Title } = Typography;

const ProviderList = () => {
    const [form] = Form.useForm();
    const [companies, setCompanies] = useState([]);
    const [companiBranchs, setCompaniBranchs] = useState([]);
    const [documentTypes, setDocumentTypes] = useState([]);

    const requiredField = {
        required: true,
        message: 'Campo requerido'
    }

    const handleChangeCompanies = (value) => {
        form.resetFields(["IdEmpresaSucursal"]);
        axios.get(`Management/company-branchs?id=` + value)
            .then(res => {
                setCompaniBranchs(res.data.data)
            })
    }

    const onFinish = (values) => {
        console.log(values);
    };

    useEffect(() => {
        axios.get(`Management/companies`)
            .then(res => {
                setCompanies(res.data.data)
            })

        axios.get(`Management/identity-documnet-type`)
            .then(res => {
                setDocumentTypes(res.data.data)
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
            <ConfigProvider renderEmpty={CustomEmpty}>
            <Card size="small">

                <Form
                    layout='vertical'
                    form={form}
                    onFinish={onFinish}
                    initialValues={{
                        layout: 'vertical',
                    }}
                    name="control-hooks"
                    initialValues={{
                        ["TipoProveedor"]: "1",
                        ["IdEstado"]: "1"
                    }}
                >
                    <Row gutter={[10, 0]}>
                        <Col sx={24} lg={12} className="width100">
                            <Form.Item
                                label="Empresa"
                                name="IdEmpresa"
                                rules={[requiredField]}
                            >
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
                            <Form.Item label="Sucursal" name="IdEmpresaSucursal" rules={[requiredField]}>
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
                                            <Option key={item.id} value={item.id}>{item.nombre}</Option>
                                        )
                                    }
                                </Select>
                            </Form.Item>
                        </Col>

                        <Col sx={24} lg={8} className="width100">
                            <Form.Item label="Nombre" name="Nombre" rules={[requiredField]}>
                                    <Input placeholder="Ingrese el nombre" maxLength="100" allowClear />
                            </Form.Item>
                        </Col>
                        <Col sx={24} lg={8} className="width100">
                            <Form.Item label="Tipo Documento" name="IdTipoDocumento" rules={[requiredField]}>
                                <Select className="width100" >
                                    {
                                        documentTypes.map((item) =>
                                            <Option key={item.id} value={item.id}>{item.nombre}</Option>
                                        )
                                    }
                                </Select>
                            </Form.Item>
                        </Col>
                        <Col sx={24} lg={8} className="width100">
                            <Form.Item label="Número Documento" name="NumeroDocumento" rules={[requiredField]}>
                                    <Input placeholder="Ingrese el documento" allowClear maxLength="20" />
                            </Form.Item>
                        </Col>

                        <Col sx={24} lg={8} className="width100">
                            <Form.Item label="Dirección" name="Direccion">
                                    <Input placeholder="Ingrese la dirección" allowClear maxLength="200" />
                            </Form.Item>
                        </Col>
                        <Col sx={24} lg={8} className="width100">
                            <Form.Item
                                label="Correo"
                                name="Correo"
                                rules={[
                                    {
                                        type: 'email',
                                        message: 'Formato de correo incorrecto'
                                    }
                                ]}
                            >
                                    <Input placeholder="Ingrese el correo" allowClear maxLength="50" />
                            </Form.Item>
                        </Col>
                        <Col sx={24} lg={8} className="width100">
                                <Form.Item
                                    label="Telefono"
                                    name="Telefono"
                                >
                                    <Input placeholder="Ingrese el telefono" allowClear maxLength="20" />
                            </Form.Item>
                        </Col>
                        <Col sx={24} lg={8} className="width100">
                            <Form.Item
                                    label="Tipo Proveedor"
                                    name="TipoProveedor"
                                    rules={[requiredField]}
                                    placeholder="Seleccione"
                                >
                                <Select className="width100">
                                    <Option value="1">Factura-Stock</Option>
                                    <Option value="2">Gastos</Option>
                                </Select>
                            </Form.Item>
                        </Col>
                        <Col sx={24} lg={8} className="width100">
                            <Form.Item label="Estado" name="IdEstado">
                                <Select className="width100">
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
                                <Button htmlType="submit" style={{ float: 'right', width: '100%' }} type="primary" icon={<SaveOutlined />}>
                                    Guardar
                                </Button>
                            </Form.Item>
                        </Col>
                    </Row>
                </Form>
                </Card>
            </ConfigProvider>
        </div>
    );
};

export default ProviderList