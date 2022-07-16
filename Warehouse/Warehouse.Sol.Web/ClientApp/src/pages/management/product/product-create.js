import React, { useState, useEffect } from 'react';
import { HomeOutlined, SaveOutlined, PlusOutlined } from '@ant-design/icons';
import { Link, useParams } from 'react-router-dom';
import CustomEmpty from "../../../components/Empty/NoData";
import { Breadcrumb, Typography, Input, Select, Col, Row, Card, Button, Form, ConfigProvider, message } from 'antd';
import axios from 'axios'

const { Option } = Select;
const { Title } = Typography;
const SMART = {
    base: "Provider",
    company: "Management/companies",
    companyBranchs: "Management/company-branchs",
    identityDocumentType: 'Management/identity-documnet-type'
}


const ProductCreate = () => {
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
        axios.get(`${SMART.companyBranchs}?id=${value}`)
            .then(res => {
                setCompaniBranchs(res.data.data)
            })
    }

    const onSave = (data) => {
        message.loading({
            content: 'Guardando información...',
            key,
        })
        axios.post(SMART.base, data)
            .then(res => {
                setSaving(false)
                if (res.data.apiStatus === 201) {
                    setModeLabel("Editar")
                    form.setFieldsValue({
                        Id: res.data.data.id
                    });

                    message.success({
                        content: res.data.apiMessage,
                        key,
                        duration: 2,
                    });
                }
            }).catch(error => {
                setSaving(false)
                message.error({
                    content: "Ocurrió un error al intentar guardar.",
                    duration: 4
                })
                console.log(error)
            })
    }

    const onEdit = (idProvider, data) => {
        message.loading({
            content: 'Actualizando información...',
            key,
        })
        axios.put(`${SMART.base}/${idProvider}`, data)
            .then(res => {
                setSaving(false)
                if (res.data.apiStatus === 200) {
                    message.success({
                        content: res.data.apiMessage,
                        key,
                        duration: 2,
                    });
                }
            }).catch(error => {
                setSaving(false)
                message.error({
                    content: "Ocurrió un error al intentar actualizar.",
                    duration: 4
                })
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
            SMART.company,
            SMART.identityDocumentType
        ]
        return Promise.all(endpoints.map((endpoint) => axios.get(endpoint))).then(([{ data: companies }, { data: documentType }]) => {
            setCompanies(companies.data)
            setDocumentTypes(documentType.data)
        });
    }

    useEffect(() => {
        getInit().then(() => {
            if (id) {
                axios.get(`${SMART.base}/${id}`)
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
            <Breadcrumb className="breadcrumb-margin">
                <Breadcrumb.Item href="/">
                    <HomeOutlined />
                </Breadcrumb.Item>
                <Breadcrumb.Item>Administración</Breadcrumb.Item>
                <Breadcrumb.Item><Link to='/Management/Product'>Producto</Link></Breadcrumb.Item>
                <Breadcrumb.Item>{modeLabel}</Breadcrumb.Item>
            </Breadcrumb>
            <Title level={3}>Crear Producto</Title>
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
                                <Form.Item label="Código de Barra" name="CodigoBarra">
                                <Input placeholder="Ingrese el codigo de barra" maxLength="200" allowClear />
                            </Form.Item>
                        </Col>
                        <Col sx={24} lg={8} className="width100">
                                <Form.Item label="Categorias" name="Categorias" rules={[requiredField]}>
                                    <Select className="width100"
                                        mode="multiple"
                                        allowClear
                                        placeholder="Seleccione las categorias"
                                    >
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
                    </Row>
                    <Row gutter={[10, 0]} className="mt-4">
                        <Col sx={24} lg={id ? 18 : 15} className="width100">
                        </Col>

                        <Col sx={24} lg={3} className="width100">
                            <Form.Item>
                                <Link to='/Management/Provider'>
                                    <Button className="btn-right">
                                        Volver
                                    </Button>
                                </Link>
                            </Form.Item>
                        </Col>
                        <Col sx={24} lg={3} className="width100" style={{ display: id ? 'none' : '' }}>
                            <Form.Item hidden={id ? true : false}>
                                <Button className="btn-right" icon={<PlusOutlined />} onClick={onNew}>
                                    Nuevo
                                </Button>
                            </Form.Item>
                        </Col>
                        <Col sx={24} lg={3} className="width100">
                            <Form.Item>
                                <Button htmlType="submit" className="btn-right" type="primary" icon={<SaveOutlined />} loading={saving}>
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

export default ProductCreate