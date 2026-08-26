import { useState, useEffect } from "react";
import { PokemonListDetailService } from "../../../services/PokeServices.ts";
import type { Pokemon } from "../../../dto/Pokemon.ts";

export function usePokeTree() {
  const [pokemonList, setPokemonList] = useState<Pokemon[]>([]);

  useEffect(() => {
    const fetchPokemonList = async () => {
      const pokemonList = await PokemonListDetailService(0, 20);
      
      setPokemonList(pokemonList);
    };

    fetchPokemonList();
  }, []);

  return { pokemonList };
}
