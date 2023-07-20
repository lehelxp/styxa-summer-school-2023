import './App.css';
import { BrowserRouter,Routes,Route,Link } from 'react-router-dom';
import Home from './pages/Home';
import Cities from './pages/Cities';
import  Login from './pages/Login';
const App=()=> {

  return (
    <BrowserRouter>
     <div className="header">
      Header:
      <Link to="/">Home</Link>
      <Link to="/Cities">City</Link>
      
    </div>  
    <Routes>
    <Route path='/' element={<Home />}/>
    <Route path='/Cities' element={<Cities/> } /> 
    <Route path='/login' element={<Login/> } /> 
    </Routes>
    </BrowserRouter>

    
  );
}

export default App;
