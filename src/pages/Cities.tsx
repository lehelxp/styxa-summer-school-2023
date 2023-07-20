import { Link,useParams } from "react-router-dom";
import CityDetails from "../components/CityDetails/CityDetails";
import { useEffect,useState } from "react";
import { fetchWrapper } from "../services/fetchWrapper";
interface City{
id:number;
name:string;
description:string;
population:number;

}
const Cities=()=>{
    const [cities,setCities]=useState<City[]>([]);
    const {cityId}=useParams();
   /* const getCitiesAll=async ()=>{
        await fetchWrapper.get("/cities").then((data)=>{
            setCities(data);
        })
    }
    useEffect(()=>{
        getCitiesAll();
   },[]);*/
    return cityId?( <CityDetails />):(
        <>
        <h1>My City list</h1>
 
    </>
    );
}
export default Cities;