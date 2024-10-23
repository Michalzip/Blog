import React, { useState, createContext } from "react";

export const OffCanvasContext = createContext();

export const OffCanvasProvider = ({ children }) => {
  const [isOffCanvasOpen, setIsOffCanvasOpen] = useState(false);
  const toggleOffCanvas = () => {
    setIsOffCanvasOpen(!isOffCanvasOpen);
  };

  return (
    <OffCanvasContext.Provider value={{ isOffCanvasOpen, toggleOffCanvas }}>
      {children}
    </OffCanvasContext.Provider>
  );
};
