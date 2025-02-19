import React, { SyntheticEvent, useState } from "react";

interface Props {
  search: string | undefined;
  handleChange: (e: React.ChangeEvent<HTMLInputElement>) => void;
  onClick: (e: SyntheticEvent) => void;
}

const Search = ({ search, handleChange, onClick }: Props) => {
  return (
    <div>
      <input value={search} onChange={(e) => handleChange(e)}></input>
      <button onClick={(e) => onClick(e)}></button>
    </div>
  );
};

export default Search;
