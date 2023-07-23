import { FC, ReactNode } from "react";
import { Navigate } from "react-router-dom";

const Guard: FC<{
  isAuth: boolean;
  children: ReactNode;
}> = ({ isAuth, children }) => {
  if (!isAuth) {
    return <Navigate to="/" replace />;
  }

  return <>{children}</>;
};

export default Guard;
