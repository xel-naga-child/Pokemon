import { Tree } from "antd";
import { usePokeTree } from "./PokeTree.cb.ts";
import { useInView, useOnInView } from "react-intersection-observer";

export const PokeTree = () => {
  //#hooks
  // const { ref, inView } = useInView({});

  const trackingRef = useOnInView(
    (inView, entry) => {
      console.log("inView", inView, entry);

      if (inView) {
        // Element is in view, so log an impression
        console.log("Element appeared in view", entry.target);
      } else {
        console.log("Element left view", entry.target);
      }
    },
    {
      /* Optional options */
      threshold: 0.5,
      triggerOnce: true,
    },
  );
  const method = usePokeTree();

  const treeData = method.pokemonList.map((pokemon, index) => {
    const isLast = index === method.pokemonList.length - 1;

    return {
      title: isLast ? (
        <span ref={trackingRef}>{pokemon.name}</span>
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

  return <Tree treeData={treeData} showIcon={true} />;
};
