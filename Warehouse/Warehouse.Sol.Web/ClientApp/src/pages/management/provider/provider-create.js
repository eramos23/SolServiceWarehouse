import React, { useState, useEffect } from 'react';
import { HomeOutlined, SaveOutlined, PlusOutlined } from '@ant-design/icons';
import { Link, useParams } from 'react-router-dom';
import CustomEmpty from "../../../components/Empty/NoData";
import { Breadcrumb, Typography, Input, Select, Col, Row, Card, Button, Form, ConfigProvider, message } from 'antd';
import axios from 'axios'

const { Option } = Select;
const { Title } = Typography;

const ProviderList = () => {
    const [form] = Form.useForm();
    const [saving, setSaving] = useState(false);
    const [modeLabel, setModeLabel] = useState("Crear");
    const [companies, setCompanies] = useState([]);
    const [companiBranchs, setCompaniBranchs] = useState([]);
    const [documentTypes, setDocumentTypes] = useState([]);
    const [provider, setProvider] = useState({});
    const { id } = useParams()
    
    const key = 'updatable';

    const requiredField = {
        required: true,
        message: 'Campo requerido'
    }

    const handleChangeCompanies = (value) => {
        form.resetFields(["IdEmpresaSucursal"]);
        axios.get(`Management/company-branchs?id=${value}`)
            .then(res => {
                setCompaniBranchs(res.data.data)
            })
    }

    const onSave = (data) => {
        message.loading({
            content: 'Guardando información...',
            key,
        })
        axios.post(`Provider/create`, data)
            .then(res => {
                setSaving(false)
                if (res.data.apiStatus === 201) {
                    setModeLabel("Editar")
                    form.setFieldsValue({
                        Id: res.data.data.id
                    });

                    message.success({
                        content: 'La información se guardó correctamente!',
                        key,
                        duration: 2,
                    });
                }
            }).catch(error => {
                console.log(error)
            })
    }

    const onEdit = (idProvider, data) => {
        message.loading({
            content: 'Actualizando información...',
            key,
        })
        axios.put(`Provider/update/${idProvider}`, data)
            .then(res => {
                setSaving(false)
                if (res.data.apiStatus === 200) {

                    message.success({
                        content: 'La información se actualizó correctamente!',
                        key,
                        duration: 2,
                    });
                }
            }).catch(error => {
                console.log(error)
            })
    }

    const onFinish = (data) => {
        let providerForm = form.getFieldsValue(["Id"])
        
        setSaving(true)
        if (providerForm.Id) {
            onEdit(providerForm.Id, data)
        } else {
            onSave(data)
        }
    };

    const onNew = () => {
        form.resetFields();
        setModeLabel("Crear")
    }

    const getInit = () => {
        let endpoints = [
            'Management/companies',
            'Management/identity-documnet-type'
        ]
        return Promise.all(endpoints.map((endpoint) => axios.get(endpoint))).then(([{ data: companies }, { data: documentType }]) => {
            setCompanies(companies.data)
            setDocumentTypes(documentType.data)
        });
    }

    useEffect(() => {
        getInit().then(() => {
            if (id) {
                axios.get(`Provider/get-single?id=${id}`)
                    .then(res => {
                        let data = res.data.data

                        handleChangeCompanies(data.idEmpresa)
                        return data
                    }).then((data) => {
                        setModeLabel("Editar")
                        form.setFieldsValue({
                            Id: data.id,
                            IdEmpresa: data.idEmpresa,
                            IdEmpresaSucursal: data.idEmpresaSucursal,
                            Nombre: data.nombre,
                            IdTipoDocumento: data.tipoDocumentoIdentidad?.id,
                            NumeroDocumento: data.numeroDocumento,
                            Direccion: data.direccion,
                            Correo: data.correo,
                            Telefono: data.telefono,
                            IdTipoProveedor: data.tipoProveedor?.id.toString(),
                            IdEstado: data.idEstado.toString()
                        });
                    })
            }
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
                <Breadcrumb.Item>{modeLabel}</Breadcrumb.Item>
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
                        ["IdTipoProveedor"]: "10",
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
                                    name="IdTipoProveedor"
                                    rules={[requiredField]}
                                >
                                <Select className="width100">
                                    <Option key="10" value="10">Factura-Stock</Option>
                                    <Option key="11" value="11">Gastos</Option>
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
                            <Form.Item label="Id" name="Id" hidden>
                                <Input type="hidden" />
                            </Form.Item>
                        </Col>

                        <Col sx={24} lg={15} className="width100">
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
                                <Form.Item hidden={id? true : false}>
                                    <Button style={{ float: 'right', width: '100%' }} icon={<PlusOutlined />} onClick={onNew}>
                                    Nuevo
                                </Button>
                            </Form.Item>
                        </Col>
                        <Col sx={24} lg={3} className="width100">
                                <Form.Item>
                                    <Button htmlType="submit" style={{ float: 'right', width: '100%' }} type="primary" icon={<SaveOutlined />} loading={saving}>
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