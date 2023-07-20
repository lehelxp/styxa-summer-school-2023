import { Link } from "react-router-dom";

const Header = () => {
  return (
    <div className="header">
      Header:
      <Link to="/">Home</Link>
      <Link to="/cities">City list</Link>
      <Link to="/contact">Contact</Link>
    </div>
  );
};

export default Header;
