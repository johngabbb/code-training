import React, { SyntheticEvent, useState } from "react";

interface Props {}

const Search = (props: Props) => {
  const [search, setSearch] = useState<string>("");

  const handleChange = (e: React.ChangeEvent<HTMLInputElement>) => {
    setSearch(e.target.value);
  };

  const onClick = (e: SyntheticEvent) => {
    console.log("maximus");
  };

  return (
    <div>
      <input value={search} onChange={(e) => handleChange(e)}></input>
      <button onClick={(e) => onClick(e)}></button>
    </div>
  );
};

export default Search;
