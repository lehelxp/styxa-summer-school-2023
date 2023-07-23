import { Link,useParams } from "react-router-dom";
import CityDetails from "../components/CityDetails/CityDetails";
import { useEffect,useState } from "react";
import { fetchWrapper } from "../services/fetchWrapper";
import Table from '@mui/material/Table';
import TableBody from '@mui/material/TableBody';
import TableCell from '@mui/material/TableCell';
import TableContainer from '@mui/material/TableContainer';
import TableHead from '@mui/material/TableHead';
import TableRow from '@mui/material/TableRow';
import Paper from '@mui/material/Paper';
import { Box, Button } from "@mui/material";
import AddIcon from '@mui/icons-material/Add';
import Form from "../components/Form/Form";
import { error } from "console";
export interface City{
id:number;
name:string;
description:string;
population:number;
mapsurl:string;
}
const Cities=()=>{
    const [cities,setCities]=useState<City[]>([]);
    const [open,setOpen]=useState(false);
    const {cityId}=useParams();
   const getCitiesAll=async ()=>{
        await fetchWrapper.get("/cities").then((data)=>{
            setCities(data);
        })
    }
    const handleClickOpen= ()=>{
        setOpen(true);
    }
    const handleClose=()=>{
        setOpen(false);
    }
    const handleSubmit=  (data:any)=>{
      fetchWrapper.post("/cities",data).then((res)=>{
        if(res){
        setOpen(false);
        }
        else{
          error("unsuccessfull operation");
        }
      })
  }
   useEffect(()=>{
        getCitiesAll();
   },[]);
   console.log({cities});
    return cityId?( <CityDetails />):(
        <Box>
        <h1>My City list</h1>
        <Box sx={{maxWidth:1900, m:"20px"}}>
        <Button variant="outlined" sx={{mb:3,mx:"auto",}} onClick={handleClickOpen}><AddIcon></AddIcon>Add City</Button>
        <Form handleClose={handleClose} type="City" open={open} handleSubmit={handleSubmit(handleSubmit)}></Form>

      <TableContainer component={Paper}>
      <Table sx={{ minWidth: 650 }} aria-label="simple table">
        <TableHead>
          <TableRow>
            <TableCell>City</TableCell>
            <TableCell align="right">Population</TableCell>
            <TableCell align="right">Description</TableCell>
            <TableCell align="right">GoogleMaps</TableCell>

          </TableRow>
        </TableHead>
        <TableBody>
          {cities.map((city) => (
            <TableRow
              key={city.name}
              sx={{ '&:last-child td, &:last-child th': { border: 0 } }}
            >
              <TableCell component="th" scope="row"><Link to={`/cities/${city.id}`}>
                {city.name}
                </Link></TableCell>
              <TableCell align="right">{city.population}</TableCell>
              <TableCell align="right">{city.description}</TableCell>
              <TableCell align="right">{city.mapsurl}</TableCell>
            </TableRow>
          ))}
        </TableBody>
      </Table>
    </TableContainer>   
      </Box>
    </Box>
    );
}
export default Cities;