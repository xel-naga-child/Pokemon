import "./App.css";
import { PokemonList } from "./presentation/Pages/PokemonList/PokemonList.uc.tsx";
import { Menu } from "antd";

function App() {
  let items = [
    {
      label: "Pokemon",
      key: "pokemon",
    },
    {
      label: "Pokemon2",
      key: "pokemon2",
    },
  ];
  return (
    <>
      <Menu items={items} mode="vertical" className="menu" />
      <PokemonList />
    </>
  );
}

export default App;
