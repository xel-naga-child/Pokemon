using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PokeBl.BL.PokemonBL;
using PokeBl.Model.Pokemon;

namespace PokeApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PokemonController : ControllerBase
    {

        PokemonGet _pokemonGet;

        public PokemonController(PokemonGet pokemonGet)
        {
            _pokemonGet = pokemonGet;
        }

        [HttpGet]
        [Route("{id}")]
        public Task<IActionResult> GetPokemon(int id)
        {
            var pokemon = _pokemonGet.GetSinglePokemonAsync<Pokemon>(id);
            return Task.FromResult<IActionResult>(Ok(pokemon));
        }

    }
}
