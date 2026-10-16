import { Tree, Spin } from "antd";
import { usePokeTree } from "./PokeTree.cb.ts";
import { useOnInView } from "react-intersection-observer";

export const PokeTree = () => {
  //#hooks
  const { pokemonList, loadMore } = usePokeTree();

  const trackingRef = useOnInView((inView) => inView && loadMore(), {
    threshold: 0.5,
  });

  const treeData = pokemonList.map((pokemon, index) => {
    const isLast = index === pokemonList.length - 1;

    return {
      title: isLast ? (
        <span ref={trackingRef}>
          {pokemon.name}
          <Spin size="small" style={{ marginLeft: 8 }} />
        </span>
      ) : (
        pokemon.name
      ),
      key: pokemon.id,
      icon: (
        <img
          src={pokemon.sprites.front_default}
          alt={pokemon.name}
          style={{ width: 20, height: 20 }}
        />
      ),
    };
  });

  return (
    <>
      <Tree treeData={treeData} showIcon={true} />;<div ref={trackingRef}></div>
    </>
  );
};
