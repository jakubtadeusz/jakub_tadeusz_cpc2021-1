import React, { useState, useEffect } from 'react';
import { Table, Dropdown, Button, Menu, Modal } from 'antd';
import { SettingFilled, PlusOutlined } from '@ant-design/icons';
import TrackForm from './TrackForm';

// server ip
const hostname = "http://localhost:36897";

const StopTracks = (props)=>{
    const [tracks, setTracks] = useState([])
    const [loadState, setLoadState] = useState(false)
    const [showAddModal, setShowAddModal] = useState(false);
    const [showDeleteModal, setShowDeleteModal] = useState(false);
	const [useEffectInvoker, setUseEffectInvoker] = useState(false);
    const [selectedTrack, setSelectedTrack] = useState(null);

    useEffect(() => {
        setLoadState(true);
		fetch(`${hostname}/api/Stop/${props.stopId}/Track`, {
		method: 'get'
	}).then((res)=>res.json()).then((tracks)=>{
        let counter = tracks.length;
        tracks.forEach(track => {
            fetch(`${hostname}/api/Stop/${track.endStopId}`, {
                method: 'get'
            }).then((res)=>res.json()).then((stop)=>{
                counter--;
                track.endStopName = stop.stopName;
                if(counter <= 0){
                    console.log(tracks);
                    setTracks(tracks);
                    setLoadState(false);
                }
            })
        });
	})
	}, [useEffectInvoker])


    const handleShowDeleteModal = (trackInfo) => {
		return () => {
			setSelectedTrack(trackInfo);
			setShowDeleteModal(true);
		};
	};

	const handleDeleteFinish = () => {
		fetch(`${hostname}/api/Stop/${props.stopId}/Track/${selectedTrack.id}`, { method: 'delete' }).then(() => {
			closeDeleteModal();
			setUseEffectInvoker(!useEffectInvoker);
		});
	};
	const closeDeleteModal = () => setShowDeleteModal(false);

    const handleShowAddModal = () => {
		return () => {
			setShowAddModal(true);
		};
	};

	const handleAddFinish = (values) => {
        console.log(values);
		fetch(`${hostname}/api/Stop/${props.stopId}/Track`, {
			body: JSON.stringify(values),
			method: 'post',
			headers: { 'Content-type': 'application/json' }
		}).then(() => {
			closeAddModal();
			setUseEffectInvoker(!useEffectInvoker);
		});
	};
	const closeAddModal = () => setShowAddModal(false);


    const columns = [{
		title: 'Przystanek końcowy',
		dataIndex: 'endStopName'
	},
	{
		title: 'Długość',
		dataIndex: 'length' ,
        render: text => <div>{text}m</div>
	},
    {
        title: 'Opis trasy',
        dataIndex: 'trackDescription'
    },
    {
        title: 'Różnica wysokości',
        dataIndex: 'elevation',
        render: text => <div style={parseInt(text) < 0 ? {color: "green"}:{color: "red"}}>{parseInt(text) > 0?'+':''}{text}m</div>
    },
    {
		title: "Opcje",
        render: (data) => (
            <Dropdown placement='bottomCenter' trigger='click' overlay={menu(data)}>
                <Button type='link' icon={<SettingFilled />} />
            </Dropdown>
        )
	}];

    const menu = (track) => (
        <Menu>
            <Menu.Item key="1" onClick={handleShowDeleteModal(track)}>
                Usuń
            </Menu.Item>
        </Menu>
        );

    return(
        <div className="tracks-table">
            <div style={{display: 'flex', flexDirection: 'row', margin: '20px', marginLeft: '60px', marginRight: '200px', justifyContent: 'space-between'}}>
			<h3><b>Trasy rozpoczynające się w wybranym punkcie:</b></h3>
			<Button className = "btn" type="primary" onClick={handleShowAddModal()}> <PlusOutlined /> Dodaj nową trasę</Button>	
		    </div>
        
            <Table columns={columns} dataSource = {tracks} rowKey={(track)=>track.id} bordered={false} loading={loadState}/>

            <Modal visible={showAddModal} onCancel={closeAddModal}>
			    <h1>Dodaj nową trasę</h1>
			    <TrackForm initialValues={{startStopId: props.stopId}} submitText='Utwórz!' onFinish={handleAddFinish} />
		    </Modal>

            <Modal visible={showDeleteModal} onCancel={closeDeleteModal} onOk={handleDeleteFinish}>
				Czy checesz usunąć trasę?
			</Modal>
        </div>);
}

export default StopTracks
