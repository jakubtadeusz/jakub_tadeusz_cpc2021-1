import React, {useState, useEffect} from 'react'

const UsernameInput = (props)=>{

    const [value, setValue] = useState({
        name: '',
        username: ''
    });

    const handleNameInput = (event)=>{
        const oldValue = value;
        oldValue.name = event.target.value
        setValue(oldValue);
    }

    const handleUsernameInput = (event)=>{
        const oldValue = value;
        oldValue.username = event.target.value
        setValue(oldValue);
    }

    const handleClick = ()=>{
        props.setUsername(value)
    }

    useEffect(()=>{
        document.title = "Wprowadź dane"
        return ()=>{
            document.title = `Witamy!!!`
        }
    }, [])

    //allow user to set nick, first and last name
    return (
        <div id = "usernameInput">
            <input className='input' placeholder = "Wprowadź imię i nazwisko..." onInput = {handleNameInput}/>
            <input className='input' placeholder = "Wprowadź nick.." onInput = {handleUsernameInput}/>
            <button className = "btn" onClick={handleClick}>Potwierdź</button>
        </div>
    );
}

export default UsernameInput