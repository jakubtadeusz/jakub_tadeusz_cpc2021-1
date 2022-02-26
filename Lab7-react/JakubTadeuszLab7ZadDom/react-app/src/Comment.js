import React, {useState, useEffect} from 'react'

const Comment = (props)=>{
    //comment component
    return(
        <div className = "comment"><b>{props.commentName}:</b> {props.commentBody} </div>
    );
}

export default Comment