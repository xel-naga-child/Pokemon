import { useState, useEffect } from "react";
import { PokemonListDetailService } from "../../../services/PokeServices.ts";
import type { Pokemon } from "../../../dto/Pokemon.ts";

export function usePokeTree() {
  const [pokemonList, setPokemonList] = useState<Pokemon[]>([]);
  const [offset, setOffset] = useState<number>(0);

  const fetchPokemonList = async () => {
    
    const newPokemonList = await PokemonListDetailService(offset, 20);

    setPokemonList((pokemonList) => [...pokemonList, ...newPokemonList]);
  };

  useEffect(() => {
    let ignore = false;
    PokemonListDetailService(offset, 20).then((list) => {
      if (!ignore) {
        setPokemonList((prev) => [...prev, ...list]);
        setOffset((prevOffset) => prevOffset + 20);
      }
    });

    return () => {
      ignore = true;
    };
  }, []);

  return { pokemonList, fetchPokemonList, setOffset };
}
