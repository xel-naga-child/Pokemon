import { useState, useEffect } from "react";
import { PokemonListService } from "../../../services/PokeServices.ts";
import type { Pokemon } from "../../../dto/Pokemon.ts";

export function usePokeTree() {
  const [pokemonList, setPokemonList] = useState<Pokemon[]>([]);

  useEffect(() => {
    const fetchPokemonList = async () => {
      const pokemonList = await PokemonListService(0, 20);
      setPokemonList(pokemonList.results);
    };

    fetchPokemonList();
  }, []);

  return { pokemonList };
}
