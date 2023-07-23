import './App.css';
import { BrowserRouter,Routes,Route,Link } from 'react-router-dom';
import Home from './pages/Home';
import Cities from './pages/Cities';
import Layout from './components/Layout/Layout';
import  Login from './pages/Login';
import Header from './components/Header/Header';
const App=()=> {

  return (
    <BrowserRouter>
    <Routes>
    <Route path="/" element={<Layout />}>
          <Route path="/" element={<Home />}/>
    <Route path="/cities/:cityId?" element={<Cities />} />
    
    <Route path='/Cities' element={<Cities/> } /> 
   
    <Route path='/login' element={<Login/> } /> 
    </Route>
    </Routes>
    </BrowserRouter>

    
  );
}

export default App;
