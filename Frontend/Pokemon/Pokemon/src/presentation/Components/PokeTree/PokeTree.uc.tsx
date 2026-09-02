import { Tree } from "antd";
import { usePokeTree } from "./PokeTree.cb.ts";

export const PokeTree = () => {
  const method = usePokeTree();
  const treeData = method.pokemonList.map((pokemon) => ({
    title: pokemon.name,
    key: pokemon.id,
    icon: 
      <img
        src={pokemon.sprites.front_default}
        alt={pokemon.name}
        style={{ width: 20, height: 20 }}
      />
    ,
  }));

  return <Tree
  treeData={treeData}
  showIcon={true}
  />;
};
