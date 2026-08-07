using Microsoft.AspNetCore.Mvc;
using PokeBl.BL.Pokemon;

namespace PokeApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PokemonController : ControllerBase
    {
        private readonly IPokemonBL _pokemonBL;
        private readonly IPokemonListBL _pokemonListBL;

        public PokemonController(IPokemonBL pokemonBL, IPokemonListBL pokemonListBL)
        {
            this._pokemonBL = pokemonBL;
            this._pokemonListBL = pokemonListBL;
        }


        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetPokemon(int id)
        {
            var pokemon = await _pokemonBL.GetPokemonAsync(id);
            if (pokemon == null)
            {
                return NotFound();
            }
            return Ok(pokemon);
        }

        [HttpGet]
        [Route("list")]
        public async Task<IActionResult> GetPokemonList(int offset = 0, int limit = 20)
        {
            var pokemons = await _pokemonListBL.ListPokemonAsync(offset, limit);
            return Ok(pokemons);
        }
    }
}
