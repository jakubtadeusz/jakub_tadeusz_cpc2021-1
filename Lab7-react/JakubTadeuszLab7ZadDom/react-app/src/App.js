import React, {useState, useEffect} from 'react'
import './App.css';
import UsernameInput from './UsernameInput'
import Post from './Post';

function App() {

  const [posts, setPosts] = useState([])
  const [username, setUsername] = useState(null)
  const [name, setName] = useState(null)
  const [value, setValue] = useState({
    title: '',
    body: ''
  });

  const updateUsername = (user)=>{
    setUsername(user.username)
    setName(user.name)
  }

  const handleBodyInput = (event)=>{
    const oldValue = value;
    oldValue.body = event.target.value;
    setValue(oldValue);
  }

  const handleTitleInput = (event)=>{
    const oldValue = value;
    oldValue.title = event.target.value;
    setValue(oldValue);
  }

  const handleClick = ()=>{
      const postsOld = [...posts]
      postsOld.push({
        userId: -1,
        id: (Math.max(...posts.map(user => user.id)) + 1),
        title: value.title,
        body: value.body
      })
      setPosts(postsOld)
      setValue({title: '', body: ''})
      console.log(posts)
  }


  useEffect(()=>{
    fetch('https://jsonplaceholder.typicode.com/posts')
     .then(response => response.json())
      .then(json => setPosts(json))
  }, []);

  return (
    <div className="App">
      {username === null && <UsernameInput setUsername={updateUsername}/>}
      {username !== null && 
        <div id = "social-app">
          <h1>Zalogowano jako: {name} ({username})</h1>
          <div id = "add-post"> 
            <input className='input' placeholder = "Wprowadź tytuł postu.." onInput = {handleTitleInput}/>
            <input className='input' placeholder = "Wprowadź treść postu.." onInput = {handleBodyInput}/>
            <button className = "btn" onClick={handleClick}>Wyślij</button>
            <div id = "posts">
              {posts.slice(0).reverse().map((value, index)=>{
                return (
                  <Post key = {index} post = {value} username = {username} name = {name}/>
                );
              })}
            </div>
          </div>
        </div>}
    </div>
  );
}

export default App;
