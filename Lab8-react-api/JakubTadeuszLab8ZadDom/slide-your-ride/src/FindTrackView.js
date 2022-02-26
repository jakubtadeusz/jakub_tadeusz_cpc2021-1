import React, { useState, useEffect } from 'react';
import { InputNumber, Button } from 'antd';
import StopSearch from './StopSearch';
import Track from './Track';


const hostname = "http://localhost:36897";
const INT32_MAX = 2147483647;

const FindTrackView = ()=>{
    const [trackLength, setTrackLength] = useState(0)
    const [pathsLoaded, setPathsLoaded] = useState(false)
    const [selectedStopId, setSelectedStopId] = useState(null); 
    const [path, setPath] = useState([])

    const onTrackLengthChange = (length)=>{
        setTrackLength(length);
    }

    const handleButtonClick = ()=>{
        fetch(`${hostname}/api/Stop/${selectedStopId}/Paths`, {
            method: 'get'
        }).then((res)=>res.json()).then((json)=>{
            console.log(json)
            let endId = -1;
            let dist = INT32_MAX;
            for(let i = 0; i < json.distance.length; i++){
                if((json.distance[i] - trackLength) * (json.distance[i] - trackLength) < (dist - trackLength) * (dist - trackLength)){
                    endId = i;
                    dist = json.distance[i];
                }
            }
            let arr = [];
            let u = endId;
            while(u != -1){
                arr.push({id: json.dbId[u], distance: json.distance[u], previous: json.dbId[json.previous[u]]});
                u = json.previous[u];
            }
            arr = arr.reverse();
            let lastDistance = 0;
            for(let i = 0; i < arr.length; i++){
                let x = arr[i].distance;
                arr[i].distance = (arr[i].distance - lastDistance);
                lastDistance = x;
            }
            setPath(arr);
        })
    }

    useEffect(() => {
        if(path.length > 0){
        setPathsLoaded(true);
        }
	}, [path])

    return(
    <div>
        <h1><b>Znajdź trasę o wybranej długości!</b></h1>
        <div>Długość:<InputNumber min={0} defaultValue={0} onChange={onTrackLengthChange} formatter={value => `${value}m`}
        parser={value => value.replace('m', '')}/>
        </div>
        <StopSearch placeholder={'Wybierz punkt początkowy...'} setSelectedStop={setSelectedStopId}/>
        <Button type="primary" onClick={handleButtonClick}>Wygeneruj trasę!</Button>
        {pathsLoaded&&<div>
            Znaleziona ścieżka:
            {path.map((track, index)=>{
                console.log(track.id);
                return <Track data={track} key={index}/>
             })}</div>}

    </div>
    );
}

export default FindTrackView