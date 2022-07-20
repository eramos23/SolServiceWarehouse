import React, { useState, useEffect } from 'react';
import { HomeOutlined, SearchOutlined, PlusOutlined, EditTwoTone, DeleteTwoTone } from '@ant-design/icons';
import { Link } from 'react-router-dom';
import CustomEmpty from "../../../components/Empty/NoData";
import { Breadcrumb, Typography, Input, Select, Col, Row, Space, Table, Card, Button, Form, Divider, Tag, ConfigProvider, message, Popconfirm } from 'antd';
import axios from 'axios'

const { Option } = Select;
const { Title } = Typography;
const SMART = {
    base: "laboratory",
    company: "Management/companies",
    companyBranchs: "Management/company-branchs"
}

const laboratoryList = () => {
    const [form] = Form.useForm();

    const [searching, setSearching] = useState(false);
    const [companies, setCompanies] = useState([]);
    const [companiBranchs, setCompaniBranchs] = useState([]);
    const [laboratories, setLaboratories] = useState([]);

    const columns = [
        {
            title: 'Nombre',
            dataIndex: 'nombre',
            sorter: (a, b) => a.nombre.length - b.nombre.length
        },
        {
            title: 'Estado',
            dataIndex: 'estado',
            sorter: (a, b) => a.estado.nombre.length - b.estado.nombre.length,
            align: 'center',
            render: (estado) => (
                <Tag color={estado.id == 1 ? 'success' : 'error'} key={estado.nombre}>
                    {estado.nombre}
                </Tag>
            )
        },
        {
            title: 'Acciones',
            dataIndex: 'acciones',
            key: 'acciones',
            align: 'center',
            render: (text,data, key) =>
                <>
                    <Link to={`/Management/Laboratory/Edit/${data.id}`}><Button size="small" icon={<EditTwoTone />} /> {"  "}</Link>
                    <Popconfirm
                        title="¿Quieres eliminar este registro?"
                        onConfirm={() => onDelete(data.id)}
                        okText="Si"
                        cancelText="Cancelar"
                    >
                        <Button size="small" icon={<DeleteTwoTone twoToneColor="#ff4d4f" />} />
                    </Popconfirm>
                </>
        },
    ];
    
    const onChangeTable = (pagination, filters, sorter, extra) => {
        console.log('params', pagination, filters, sorter, extra);
    };

    const onDelete = (id) => {
        axios.delete(`${SMART.base}/${id}`)
            .then(res => {
                if (res.data.apiStatus === 200) {
                    let values = form.getFieldsValue();
                    handleSeach(values)
                    message.success({
                        content: res.data.apiMessage,
                        duration: 2
                    });
                }
            }).catch(error => {
                message.error({
                    content: "Ocurrió un error al intentar eliminar.",
                    duration: 4
                })
                console.log(error)
            })
    };

    const handleChangeCompanies = (value) => {
        form.resetFields(["IdEmpresaSucursal"]);
        axios.get(`${SMART.companyBranchs}?id=${value}`)
            .then(res => {
                setCompaniBranchs(res.data.data)
            })
    }

    const handleSeach = (value) => {
        setSearching(true)
        axios.get(SMART.base, { params: value })
            .then(res => {
                setSearching(false)
                setLaboratories(res.data.data.map((item, i) => {
                    return {
                        key: i,
                        ...item
                    }
                }))
            })
            .catch(error => {
                setSearching(false)
                message.error({
                    content: "Ocurrió un error al intentar listar.",
                    duration: 4
                })
                console.log(error)
            })

    }

    useEffect(() => {
        axios.get(SMART.company)
            .then(res => {
                setCompanies(res.data.data)
            })
        handleSeach()
    }, [])
    return (
        <div>
            <Breadcrumb className="breadcrumb-margin">
                <Breadcrumb.Item href="/">
                    <HomeOutlined />
                </Breadcrumb.Item>
                <Breadcrumb.Item>Administración</Breadcrumb.Item>
                <Breadcrumb.Item>Laboratorio</Breadcrumb.Item>
                <Breadcrumb.Item>Listar</Breadcrumb.Item>
            </Breadcrumb>
            <Title level={3}>Listado de Laboratorios</Title>
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
                                            <Option key={item.id} value={item.id}>{item.nombre}</Option>
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
                                    <Button className="btn-right" htmlType="submit" type="primary" icon={<SearchOutlined />} loading={searching}>
                                    Buscar
                                </Button>
                            </Form.Item>
                        </Col>
                        <Col sx={24} lg={21} className="width100">
                        </Col>
                        <Col sx={24} lg={3} className="width100">
                            <Form.Item>
                                <Link to='/Management/Laboratory/Create'>
                                    <Button className="btn-right" type="primary" icon={<PlusOutlined />}>
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
                    dataSource={laboratories}
                    size="small"
                    showSorterTooltip={false}
                    onChange={onChangeTable}
                />
                </Card>
            </ConfigProvider>
        </div>
    );
};

export default laboratoryList