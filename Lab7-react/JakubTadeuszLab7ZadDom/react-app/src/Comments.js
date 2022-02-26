import React, {useState, useEffect} from 'react'
import Comment from './Comment'

const Comments = (props)=>{

    //array with comments
    const [comments, setComments] = useState([])
    const [showComments, setShowComments] = useState(false)
    //new comment values
    const [value, setValue] = useState({
        postId: 0,
        id: 0,
        body: '',
        name: '',
        email: ''
      });

    useEffect(()=>{
        fetch('https://jsonplaceholder.typicode.com/comments')
        .then(response => response.json())
        .then(json => {
            const filtered = json.filter((value)=>{
                return value.postId === props.postId
              })
            setComments(filtered)
        })
      }, [props]);

      const handleShowCommentsButtonClick = ()=>{
        setShowComments(!showComments)
      }

      const handleInput = (event)=>{
        const oldValue = value;
        oldValue.name = props.username;
        oldValue.body = event.target.value;
        setValue(oldValue);
      }

      const handleSendCommentClick = ()=>{
          const oldComments = [...comments]
          oldComments.push(value)
          setComments(oldComments)
      }
    return(<div className = {showComments?"comments-wrapper-shown":"comments-wrapper"}><b><i>Komentarzy:</i></b> {comments.length}
        <button className="show-comments btn"  onClick = {handleShowCommentsButtonClick}>{showComments ? 'Ukryj komentarze':'Pokaz komentarze'}</button>
        {showComments === true && <div className = "comments">
            {comments.map((value, id)=>{
                return(<Comment key = {id} commentName = {value.name} commentBody = {value.body}/>);
            })}
                        <input className='input' placeholder = "Wprowadź treść komentarza.." onInput = {handleInput}/>
            <button className = "btn" onClick={handleSendCommentClick}>Wyślij</button>
            </div>}
    </div>);
}

export default Comments