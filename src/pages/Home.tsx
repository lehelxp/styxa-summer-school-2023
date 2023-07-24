import React from "react";
import Header from "../components/Header/Header";
import { Box, Button } from "@mui/material";
import styxa from "../styxa-Logo-BLU.png"
const Home=()=>{ 
    return (
    <Box textAlign="center">
        <h1>Styxa Project</h1>
        <p>This app is implemented using react framework and .net backend.   </p>
        <a href="https://styxa.ro">
            <img src={styxa} alt="Styxa-Logo"></img>
        </a>
    </Box>
    )
}
export default Home;