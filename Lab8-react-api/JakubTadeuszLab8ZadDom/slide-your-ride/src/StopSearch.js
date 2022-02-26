import React, { useState, useEffect } from 'react';
import {Select} from 'antd';

//server ip
const hostname = "http://localhost:36897";

const Option = {Select}

const StopSearch = (props)=>{

  const [data, setData] = useState([])
  const [filtered, setFiltered] = useState([])
  const [value, setValue] = useState()

  useEffect(() => {
		fetch(`${hostname}/api/Stop`, {
		method: 'get'
	}).then((res)=>res.json()).then((json)=>{
		setData(json)
	})
	}, [])
    
    
    const handleSearch = value => {
        if (value) {
          setFiltered(data.filter((stop)=>stop.stopName.includes(value)))
        } else {
          setFiltered([]);
        }
      };
    
    const handleChange = value => {
        setValue(value);
        props.setSelectedStop(value);
      };

    let options = data.map(d => <Option key={d.id}>{d.stopName}</Option>);

    return(      
    <Select
        showSearch
        value={value}
        placeholder={props.placeholder}
        defaultActiveFirstOption={false}
        showArrow={false}
        filterOption={false}
        onSearch={handleSearch}
        onChange={handleChange}
        notFoundContent={null}
      >
        {options}
      </Select>);
}

export default StopSearch