import { Box, Button, FormHelperText, TextField, Typography } from "@mui/material";
import { useForm } from "react-hook-form";
import { fetchWrapper } from "../services/fetchWrapper";
import { useState } from "react";
import { STATUS_CODES } from "http";
import { error } from "console";
import {  useNavigate } from "react-router-dom";
interface LoginFields {
  username: string;
  password: string;
}

const Login = () => {
  const [isLoading, setIsLoading] = useState<boolean>(false);
  const navigate=useNavigate();
  const {
    register,
    handleSubmit,
    formState: { errors },
  } = useForm<LoginFields>({
    mode: "onBlur",
    defaultValues: {
    },
  });

  const onSubmit = (data: any) => {
    setIsLoading(true);
    ///
    fetchWrapper.post("/login", data).then((res) => {
     if (res) {
      navigate('/');
    } else{
      console.error("invalid creditentials");
    }
       setIsLoading(false);
    });
  };

  return (
    <div>
      <form id="login-form" onSubmit={handleSubmit(onSubmit)}>
        <Box sx={{ maxWidth: 400, mx: "auto" }}>
          <Typography variant="h5" textAlign="center" mb={3}>
            Login page
          </Typography>
          <Box mb={1}>
            <TextField
              id="user"
              label="Username"
              variant="standard"
              fullWidth
              {...register("username", { required: true })}
              error={!!errors.username}
              {...(!!errors.username && { helperText: "Username is required" })}
            />
          </Box>
          <Box mb={4}>
            <TextField
              id="password"
              label="Password"
              variant="standard"
              type="password"
              fullWidth
              {...register("password", { required: true })}
            />
          </Box>
          <Button
            type="submit"
            variant="contained"
            disabled={
              !!errors.username || !!errors.password || isLoading ? true : false
            }
          >
            Log In
          </Button>
        </Box>
      </form>
    </div>
  );
};

export default Login;
