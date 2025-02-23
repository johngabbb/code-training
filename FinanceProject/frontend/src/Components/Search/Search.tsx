import { execArgv } from "process";
import React, { SyntheticEvent, useState } from "react";

interface Props {
  search: string | undefined;
  handleSearchChange: (e: React.ChangeEvent<HTMLInputElement>) => void;
  onSearchSubmit: (e: SyntheticEvent) => void;
}

const Search = ({ search, handleSearchChange, onSearchSubmit }: Props) => {
  return (
    <>
      <form onSubmit={onSearchSubmit}>
        <input value={search} onChange={(e) => handleSearchChange(e)}></input>
      </form>
    </>
  );
};

export default Search;
