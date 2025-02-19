import { SyntheticEvent, useState } from "react";
import "./App.css";
import Card from "./Components/Card/Card";
import CardList from "./Components/CardList/CardList";
import Search from "./Components/Search/Search";

interface Props {}

function App() {
  const [search, setSearch] = useState<string>("");

  const handleChange = (e: React.ChangeEvent<HTMLInputElement>) => {
    setSearch(e.target.value);
  };

  const onClick = (e: SyntheticEvent) => {
    console.log("maximus");
  };

  return (
    <div className="App">
      <Search onClick={onClick} search={search} handleChange={handleChange} />
      <CardList />
    </div>
  );
}

export default App;
