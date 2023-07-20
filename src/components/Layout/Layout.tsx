import React from "react";
import Header from "../Header/Header";
import Footer from "../Footer/Footer";
import Content from "../Content/Content";

const Layout = () => {
  return (
    <div className="layout">
      <Header />
      <Content />
      <Footer />
    </div>
  );
};

export default Layout;
