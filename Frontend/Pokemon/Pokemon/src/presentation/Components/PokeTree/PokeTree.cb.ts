import { useState, useEffect, useRef } from "react";
import { PokemonListDetailService } from "../../../services/PokeServices.ts";
import type { Pokemon } from "../../../dto/Pokemon.ts";

export function usePokeTree() {
  const [pokemonList, setPokemonList] = useState<Pokemon[]>([]);
  const offsetRef = useRef(0);
  const loadingRef = useRef(false);

  const loadMore = async () => {
    if (loadingRef.current) return;
    loadingRef.current = true;
    const offSet = offsetRef.current;
    offsetRef.current += 20;
    try {
      const list = await PokemonListDetailService(offSet, 20);
      setPokemonList((prev) => [...prev, ...list]);
    } finally {
      loadingRef.current = false;
    }
  };

  return { pokemonList, loadMore };
}
