import React, {useState, useEffect} from 'react'
import Comments from './Comments';

const Post = (props) =>{

    const [user, setUser] = useState({
        id: props.post.userId,
        name: '',
        username: '',
        email: ''
    })

    //get info about user from api
    useEffect(()=>{
        if(props.post.userId === -1){
            const user = {
                id:  props.post.userId,
                name: props.name,
                username: props.username,
                email: '' 
            }
            setUser(user)
        }else{
        fetch('https://jsonplaceholder.typicode.com/users/' + props.post.userId)
        .then(response => response.json())
        .then(json => setUser(json))
        }
      }, [props]);

    //show post component
    return(<div className="post">
        <div className="post-author"><b>{user.name}</b> ({user.username}):</div>
        <div className="post-title">{props.post.title}</div>
        <div className="post-body">{props.post.body}</div>
        <Comments username = {props.username} postId = {props.post.id}/>
    </div>)
}

export default Post