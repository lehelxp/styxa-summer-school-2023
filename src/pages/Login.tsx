import { TextField, Box,Button } from "@mui/material";

const Login=()=>{
    return(
        <div>
            <h1>Login page</h1>
            <form id="login-form">
            <Box sx={{maxWidth:400}}>
                <Box mb={1}>
                    <TextField id="user" label="Username" variant="standard" fullWidth/>
                </Box>
                <Box mb={4}>
                    <TextField id="password" label="Password" variant="standard"  type="password" fullWidth/>
                </Box>
                <Button type="submit" variant="contained">Login</Button>  
            </Box>
            </form>
        </div>
    );
};
export default Login;