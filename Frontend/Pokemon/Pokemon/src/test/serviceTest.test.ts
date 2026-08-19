import { expect, test } from "vitest";
import { PokemonListService } from "../services/PokeServices";

test("PokemonListServiceTest", async () => {
    
  expect(await PokemonListService(0, 10)).toBeDefined();
});
