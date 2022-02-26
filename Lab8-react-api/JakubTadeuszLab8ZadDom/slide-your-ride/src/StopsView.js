import React, { useState, useEffect } from 'react';
import { Table, Dropdown, Button, Menu, Modal } from 'antd';
import { SettingFilled, PlusOutlined } from '@ant-design/icons';
import StopTracks from './StopTracks';
import StopForm from './StopForm'

//server ip
const hostname = "http://localhost:36897";

const StopsView = ()=>{

    const [stopsData, setStopsData] = useState([]);
	const [selectedStop, setSelectedStop] = useState(null);
	const [showDeleteModal, setShowDeleteModal] = useState(false);
	const [showUpdateModal, setShowUpdateModal] = useState(false);
	const [showAddModal, setShowAddModal] = useState(false);
	const [useEffectInvoker, setUseEffectInvoker] = useState(false);


	const handleShowDeleteModal = (stop) => {
		return () => {
			setSelectedStop(stop);
			setShowDeleteModal(true);
		};
	};
	const handleDeleteFinish = () => {
		fetch(`${hostname}/api/Stop/${selectedStop.id}`, { method: 'delete' }).then(() => {
			closeDeleteModal();
			setUseEffectInvoker(!useEffectInvoker);
		});
	};
	const closeDeleteModal = () => setShowDeleteModal(false);

	const handleShowUpdateModal = (stop) => {
		return () => {
			setSelectedStop(stop);
			setShowUpdateModal(true);
		};
	};

	const handleUpdateFinish = (values) => {
		fetch(`${hostname}/api/Stop/${selectedStop.id}`, {
			body: JSON.stringify(values),
			method: 'put',
			headers: { 'Content-type': 'application/json' }
		}).then(() => {
			closeUpdateModal();
			setUseEffectInvoker(!useEffectInvoker);
		});
	};
	const closeUpdateModal = () => setShowUpdateModal(false);

	const handleShowAddModal = () => {
		return () => {
			setShowAddModal(true);
		};
	};

	const handleAddFinish = (values) => {
		fetch(`${hostname}/api/Stop`, {
			body: JSON.stringify(values),
			method: 'post',
			headers: { 'Content-type': 'application/json' }
		}).then(() => {
			closeAddModal();
			setUseEffectInvoker(!useEffectInvoker);
		});
	};
	const closeAddModal = () => setShowAddModal(false);


    useEffect(() => {
		fetch(`${hostname}/api/Stop`, {
		method: 'get'
	}).then((res)=>res.json()).then((json)=>{
		setStopsData(json)
	})
	}, [useEffectInvoker])


    const columns = [
		{
			title: 'Id',
			dataIndex: 'id'
		},
		{
		title: 'Nazwa przystanku',
		dataIndex: 'stopName'
	},
	{
		title: 'Opis przystanku',
		dataIndex: 'stopDescription' 
	},{
		title: "Opcje",
		render: (data) => (
			<Dropdown placement='bottomCenter' trigger='click' overlay={menu(data)}>
				<Button type='link' icon={<SettingFilled />} />
			</Dropdown>
		)
	}];

    const menu = (stopRow) => (
        <Menu>
            <Menu.Item key='1' onClick={handleShowUpdateModal(stopRow)}>
                Edytuj
            </Menu.Item>	
			<Menu.Item key='2' onClick={handleShowDeleteModal(stopRow)}>
				Usuń
			</Menu.Item>
        </Menu>
        );


    return(
    <div>
		<div style={{display: 'flex', flexDirection: 'row', margin: '20px', marginLeft: '60px', marginRight: '200px', justifyContent: 'space-between'}}>
			<h1 className = "text-center m-3 font-display"><b>Przystanki:</b></h1>
			<Button className = "btn" type="primary" onClick={handleShowAddModal()}> <PlusOutlined /> Dodaj nowy przystanek</Button>	
		</div>

		<Table columns={columns} dataSource = {stopsData} rowKey={(stop)=>stop.id}  
        expandable={{expandedRowRender: stop => <StopTracks stopId={stop.id}/> }}/>

		<Modal visible={showAddModal} onCancel={closeAddModal}>
			<h1>Dodaj nowy przystanek</h1>
			<StopForm submitText='Utwórz!' onFinish={handleAddFinish} />
		</Modal>
		<Modal visible={showUpdateModal} onCancel={closeUpdateModal}>
			<h1>Edytuj przystanek</h1>
			<StopForm initialValues={selectedStop} submitText='Zapisz!' onFinish={handleUpdateFinish} />
		</Modal>
		<Modal visible={showDeleteModal} onCancel={closeDeleteModal} >
			<h1>Czy checesz usunąć przystanek?</h1>
			<StopForm initialValues={selectedStop} submitText='Usuń' onFinish={handleDeleteFinish} />
		</Modal>
    </div>
    );
}

export default StopsView