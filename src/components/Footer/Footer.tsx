import { Link } from "react-router-dom";

const Footer = () => {
  return (
    <div className="footer">
      Footer:
      <Link to="/">Home</Link>
      <Link to="/cities">City list</Link>
      <Link to="/contact">Contact</Link>
    </div>
  );
};

export default Footer;
