import React from 'react';
import {Form, Input, InputNumber, Button} from 'antd'

// Formularz obsługujący trasy
const TrackForm = ({ onFinish, submitText, initialValues})=>{
    const [form] = Form.useForm();
    return (
        <Form form={form} layout='vertical' onFinish={onFinish} initialValues={initialValues}>
        <Form.Item name='id' hidden>
            <InputNumber />
        </Form.Item>
        <Form.Item name='trackDescription' label='Opis trasy'>
            <Input placeholder='Podaj opis trasy...' />
        </Form.Item>
        <Form.Item name='length' label='Długość trasy'>
            <InputNumber />
        </Form.Item>
        <Form.Item name='elevation' label='Różnica wysokości trasy (wartość ujemna oznacza trasę w dół'>
            <InputNumber />
        </Form.Item>
        <Form.Item name='startStopId' label='Początek trasy'>
            <InputNumber disabled={true}/>
        </Form.Item>
        <Form.Item name='endStopId' label='Koniec trasy'>
            <InputNumber />
        </Form.Item>
        <Form.Item className='text-center'>
            <Button className='w-100' htmlType='submit' size='large' type='primary'>
                {submitText}
            </Button>
        </Form.Item>
    </Form>
    );
}

export default TrackForm