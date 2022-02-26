import './App.css';
import React, { useState } from 'react';
import { Layout, Menu, Image } from 'antd';
import { NodeIndexOutlined, AimOutlined, HomeOutlined } from '@ant-design/icons';
import LogoSrc from './assets/logo.png';
import HomeView from './HomeView'
import FindTrackView from './FindTrackView'
import StopsView from './StopsView'

const { Content, Sider, Header, Footer } = Layout;

function App() {
  //aktualnie wybrana podstrona
  const [selectedMenu, setSelectedMenu] = useState(0);

  //funkcja zwracająca wybraną podstronę
  const getSelectedPage = ()=>{
    switch(selectedMenu){
      case 0: return(<HomeView handleControls={setSelectedMenu}/>); 
      case 1: return(<FindTrackView/>);
      case 2: return(<StopsView/>);
    }
  }

  return (
    <div className="App">
        <Layout style={{ minHeight: '100vh' }}>
          <Sider>
          <div className='logo'>
          <Image src={LogoSrc} preview={false}></Image>
					<h1 className='font-display m-1 title-text'><b>SlideYourRide!</b></h1>
			  	</div>
            <Menu theme = "dark" mode = "inline" defaultSelectedKeys={[0]} selectedKeys={selectedMenu}>
              <Menu.Item key = '0' icon = {<HomeOutlined />} onClick={()=>setSelectedMenu(0)}>Strona główna</Menu.Item>
              <Menu.Item key = '1' icon = {<NodeIndexOutlined />} onClick={()=>setSelectedMenu(1)}>Wygeneruj trasę!</Menu.Item>
              <Menu.Item key = '2' icon = {<AimOutlined />} onClick={()=>setSelectedMenu(2)}>Pokaż wszystkie przystanki</Menu.Item>
            </Menu>
          </Sider>
          <Layout>
            <Header>
              <h2 className="title-text"><b>SlideYourRide!</b></h2>
            </Header>
            <Content>{getSelectedPage()}</Content>
            <Footer>@2021 - Kredek - Jakub Tadeusz</Footer>
			    </Layout>
        </Layout>
      <header className="App-header">
      </header>
    </div>
  );
}

export default App;
