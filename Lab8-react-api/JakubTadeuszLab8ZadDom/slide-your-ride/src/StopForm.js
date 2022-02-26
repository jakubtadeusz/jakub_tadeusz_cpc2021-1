import React from 'react';
import {Form, Input, InputNumber, Button} from 'antd'

const StopForm = ({ onFinish, submitText, initialValues})=>{

    const [form] = Form.useForm();

	return (
		<Form form={form} layout='vertical' onFinish={onFinish} initialValues={initialValues}>
			<Form.Item name='id' hidden>
				<InputNumber />
			</Form.Item>
			<Form.Item name='stopName' label='Nazwa przystanku'>
				<Input placeholder='Podaj nazwę przystanku...' />
			</Form.Item>
			<Form.Item name='stopDescription' label='Opis przystanku'>
				<Input placeholder='Podaj opis...' />
			</Form.Item>
			<Form.Item className='text-center'>
				<Button className='w-100' htmlType='submit' size='large' type='primary'>
					{submitText}
				</Button>
			</Form.Item>
		</Form>
	);
}

export default StopForm