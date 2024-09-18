import { createContext, useContext, useState } from "react";

export const SearchContext = createContext();

export const SearchProvider = ({ children }) => {
  const [inputText, setInputText] = useState("");
  return (
    <SearchContext.Provider value={{ inputText, setInputText }}>
      {children}
    </SearchContext.Provider>
  );
};
