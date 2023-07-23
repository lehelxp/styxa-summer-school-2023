import { AppBar, Button } from "@mui/material";
import LoginIcon from "@mui/icons-material/Login";
import { Link as RouterLink } from "react-router-dom";

import "./Header.scss";

const pages = [
  {
    title: "Home",
    path: "/",
  },
  {
    title: "Cities",
    path: "/cities",
  },
];

const Header = () => {
  return (
    <div className="header">
      <AppBar className="navbar" position="static">
        <RouterLink to="/">{/* <Logo /> */}</RouterLink>
        <div>
          {pages.map((page) => {
            return (
              <Button
                key={page.path}
                component={RouterLink}
                to={page.path}
                className="page-link"
              >
                {page.title}
              </Button>
            );
          })}
        </div>
        <Button component={RouterLink} to="/login" color="inherit">
          <LoginIcon fontSize="large"></LoginIcon>
          <span>LogIn</span>
        </Button>
      </AppBar>
    </div>
  );
};

export default Header;
