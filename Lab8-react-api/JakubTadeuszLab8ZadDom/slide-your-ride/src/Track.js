import React, { useState, useEffect } from 'react';

// server ip
const hostname = "http://localhost:36897";

const Track = (props) =>{

    const [stop, setStop] = useState()
    const [stopLoaded, setStopLoaded] = useState(false)
    const [track, setTrack] = useState()
    const [trackState, setTrackState] = useState(false)

    useEffect(() => {
        console.log("x")
		fetch(`${hostname}/api/Stop/${props.data.id}`, {
		method: 'get'
	}).then((res)=>res.json()).then((json)=>{
		setStop(json)
        setStopLoaded(true);
	})
	}, [props.data.id])

    useEffect(()=>{
        console.log(props.data);
        if(props.data.previous){
        fetch(`${hostname}/api/Stop/${props.data.previous}/Track`, {
            method: 'get'
        }).then((res)=>res.json()).then((json)=>{
            setTrack(json.filter(track=>{
                return track.length === props.data.distance &&
                track.endStopId === props.data.id && 
                track.startStopId === props.data.previous
            })[0]);
            setTrackState(true)
        })
    }
    }, [props.data.previous])

    return (<div className="path-desc"><h2 className="title-text">{stopLoaded&&stop.stopName}</h2> Odległość - {props.data.distance}m {trackState && <div><h4 className="title-text">{track.trackDescription}</h4> 
    <div >Różnica wysokości terenu: <div style={track.elevation < 0 ? {color:'green'}: {color:'red'}}>{track.elevation}m</div> </div></div>}</div>);
}

export default Track