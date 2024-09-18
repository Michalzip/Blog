import { useState, useContext } from "react";

import { SearchContext } from "../context/SearchContext";

export const useSearchState = () => {
  const [isListVisible, setIsListVisible] = useState(false);
  const { setInputText, inputText } = useContext(SearchContext);

  const handleInputChange = (e) => {
    setInputText(e.target.value.toLowerCase());
  };

  const handleListVisibility = () => {
    setIsListVisible(!isListVisible);
    console.log(isListVisible);
  };

  const filteredData = (posts) => {
    return posts.filter((post) => {
      if (inputText === "") return true;
      return post.title.toLowerCase().includes(inputText.toLowerCase());
    });
  };

  return {
    isListVisible,
    filteredData,
    setIsListVisible,
    handleListVisibility,
    handleInputChange,
  };
};
