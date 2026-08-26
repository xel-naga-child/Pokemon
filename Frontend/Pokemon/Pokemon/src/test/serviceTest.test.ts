import { expect, test } from "vitest";
import { PokemonListDetailService, PokemonListService } from "../services/PokeServices";

test("PokemonListServiceTest", async () => {
    
  expect(await PokemonListService(0, 10)).toBeDefined();
});


test("PokemonListDetailServiceTest", async () => {
    
  expect(await PokemonListDetailService(0, 20)).toBeDefined();
});
