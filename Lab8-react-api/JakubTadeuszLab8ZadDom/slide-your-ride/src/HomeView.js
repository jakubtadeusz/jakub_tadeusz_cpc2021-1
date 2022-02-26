import React from 'react';
import { Button} from 'antd'
import { NodeIndexOutlined, AimOutlined, PlusOutlined } from '@ant-design/icons';

const HomeView = (props)=>{
    return(
    <div className="home">
       <h2>SlideYourRide! - aplikacja do wyszukiwania tras longboardowych</h2>
       <p>Zadaniem aplikacji jest ułatwienie procesu znajdowania nowych tras służących jeździ na longboardzie. <br></br>W tym celu, aplikacja składa się z bazy danych przechowującej:<br></br>
        <ul>
        <li>Przystanki - nazwa przystanku oraz jego krótki opis</li>
        <li>Trasy - przystanek początkowy i końcowy, długość trasy, krótki opis oraz różnica w wysokości terenu pomiędzy początkiem i końcem</li>
        </ul>   
       </p>
       <h3>Nawigacja</h3>
        W panelu po lewej stronie znajdują się wszelkie wymagane odnośniki
       <h3>Instrukcja</h3>
       <p>
       Aby wyszukać nową trasę, użytkownik musi jedynie podać punkt początkowy trasy oraz jej długość. Po otrzymaniu tych danych, aplikacja znajdzie dla użytkownika trasę najbardziej zbliżoną do podanych parametrów!
       </p>
        <Button style={{backgroundColor: "#001529"}} ><div className={"title-text"} onClick={()=>props.handleControls(1)}><NodeIndexOutlined /> Znajdź trasę dla siebie!</div></Button>
       <h3>Dodawanie nowych punktów oraz tras</h3>
       <p>
        Aby dodać nowy przystanek lub trasę pomiędzy istniejącymi punktami, przejdź do odpowiedniego menu <br></br>
       </p>
       <Button style={{backgroundColor: "#001529"}} ><div className={"title-text"} onClick={()=>props.handleControls(2)}><AimOutlined /> Utwórz przystanek lub trasę!</div></Button>
        <p>
            Po przejściu do menu służącego do dodawania danych do bazy, na samym początku ukazana zostaje pełna lista przystanków, wraz z możliwościami edycji, usunięcia. <br></br>
            Wykorzystując przycisk z symbolem plusa, można rozwinąć listę tras wychodzących z danego punktu, usunąć je lub dodać nowe. <br></br>
            W celu dodania nowego elementu, w odpowiednim menu zlokalizuj odpowiedni przycisk
        </p>
        <Button type="primary"><PlusOutlined /> Dodaj nowy element! </Button>
    </div>
    );
}

export default HomeView