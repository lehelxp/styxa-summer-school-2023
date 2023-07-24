import React, { useEffect, useState } from "react";
import { City } from "../../pages/Cities";
import { Link, useParams } from "react-router-dom";
import { fetchWrapper } from "../../services/fetchWrapper";
import Box from "@mui/material/Box/Box";
import Table from '@mui/material/Table';
import TableBody from '@mui/material/TableBody';
import TableCell from '@mui/material/TableCell';
import TableContainer from '@mui/material/TableContainer';
import TableHead from '@mui/material/TableHead';
import TableRow from '@mui/material/TableRow';
import Paper from '@mui/material/Paper';
import AddIcon from '@mui/icons-material/Add';
import EditIcon from '@mui/icons-material/Edit';
import { Button, Dialog, DialogActions, DialogContent, DialogContentText, DialogTitle, TextField } from "@mui/material";
import Form from "../Form/Form";
import MapIcon from '@mui/icons-material/Map';
interface PointOfInterest{
  id:number;
name:string;
description:string;
cityId:number
mapsURL:string;
}
const CityDetails = () => {
  const [city, setCity] = useState<City>({} as City);
  const { cityId } = useParams();
  const [pois, setPois]=useState<PointOfInterest[]>([]);
  const [openpoi,setOpenPoi]=useState(false);
  const [opencity,setOpenCity]=useState(false);
  const [poi, setPoi]=useState<PointOfInterest>({} as PointOfInterest)
  const getCity = async () => {
    await fetchWrapper.get(`/cities/${cityId}`).then((data) => {
      setCity(data);
    });
  };
  const getPois=async ()=>{
    await fetchWrapper.get(`/cities/${cityId}/pointsOfInterest`).then((data)=>{
      setPois(data);
    })
  }
  const handleClickOpen= ()=>{
    setOpenPoi(true);
    
}
const handleClickOpencity= ()=>{
  setOpenCity(true);
}

const handleClose=()=>{
    setOpenPoi(false);
    setOpenCity(false);
}
const handleSubmit=()=>{
  setOpenPoi(false);
}
 useEffect(() => {
    getCity();
    getPois();
  }, []);

  return (
    <Box>
      <h1>{city.name}</h1>
      <Button variant="outlined" sx={{mb:3,mx:"auto",}} onClick={handleClickOpencity}><EditIcon></EditIcon>Edit City</Button>
  <Form handleClose={handleClose} handleSubmit={handleSubmit} type="City" open={opencity}></Form>
      <h3>
        {city.description}
      </h3>
      <h4>Population: {city.population}</h4>
      <h5>Area: {city.area}</h5>
      <Box sx={{maxWidth:1900, m:"20px"}}>
      <Button variant="outlined" sx={{mb:3,mx:"auto",}} onClick={handleClickOpen}><AddIcon></AddIcon>Add point of interest</Button>
      <Form handleClose={handleClose} type="Point of interest" handleSubmit={handleSubmit} open={openpoi}></Form>
      <TableContainer component={Paper}>
      <Table sx={{ minWidth: 650 }} aria-label="simple table">
        <TableHead>
          <TableRow>
            <TableCell>Point of Interest</TableCell>
            <TableCell align="right">Description</TableCell>
            <TableCell align="right">GoogleMaps</TableCell>
            <TableCell align="right">Edit</TableCell>
          </TableRow>
        </TableHead>
        <TableBody>
          {pois.map((row) => (
            <TableRow
              key={row.name}
              sx={{ '&:last-child td, &:last-child th': { border: 0 } }}
            >
              <TableCell component="th" scope="row">
                {row.name}
              </TableCell>
              <TableCell align="right">{row.description}</TableCell>
              <TableCell align="right"><Link to={row.mapsURL}><MapIcon></MapIcon></Link></TableCell>
              <TableCell align="right"><Button onClick={handleClickOpen}><EditIcon></EditIcon></Button></TableCell>
            </TableRow>
          ))}
        </TableBody>

      </Table>
    </TableContainer>
    <Form type="Point of interest" handleClose={handleClose} handleSubmit={handleSubmit} open={openpoi}></Form>
      </Box>
    </Box>
  );
};

export default CityDetails;
