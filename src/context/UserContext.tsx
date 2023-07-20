import { FC, ReactNode, createContext, useState } from "react";

interface UserContextState {
  loggedIn: boolean;
}

interface UserContextProps extends UserContextState {
  logIn: () => void;
  logOut: () => void;
}

const defaultValues = {
  loggedIn: false,
  logIn: () => null,
  logOut: () => null,
};

export const UserContext = createContext<UserContextProps>(defaultValues);

const UserProvider: FC<{ children: ReactNode }> = ({ children }) => {
  const [store, setStore] = useState<UserContextState>(defaultValues);

  const { loggedIn } = store;

  const logIn = () => {
    setStore({ ...store, loggedIn: true });
  };

  const logOut = () => {
    setStore({ ...store, loggedIn: false });
  };

  return (
    <UserContext.Provider value={{ loggedIn, logIn, logOut }}>
      {children}
    </UserContext.Provider>
  );
};

export default UserProvider;
