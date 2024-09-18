import { React, useState } from "react";
import classes from "./SearchBar.module.css";
import { useSearchState } from "../../../hooks/useSearchState";
import SearchPosts from "../../SearchPosts/SearchPosts";
export default function SearchBar() {
  const {
    isListVisible,
    setIsListVisible,
    handleListVisibility,
    handleInputChange,
  } = useSearchState();

  let inputHandler = (e) => {
    handleInputChange(e);
  };

  return (
    <div className={classes.searchBarContainer}>
      <div className={classes.searchContent}>
        <input
          className={classes.searchBar}
          type="text"
          placeholder="Search..."
          onChange={inputHandler}
          onFocus={handleListVisibility}
          onBlur={handleListVisibility}
        ></input>
        {isListVisible && <SearchPosts />}
      </div>
    </div>
  );
}
