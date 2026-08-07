using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PokeBl.BL.Pokemon;
using PokeBl.BL.PokemonBL;
using PokeBl.Model.Pokemon;

namespace PokeApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PokemonController : ControllerBase
    {
        private readonly IPokemonBL _pokemonBL;

        public PokemonController(IPokemonBL pokemonBL)
        {
            this._pokemonBL = pokemonBL;
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
    }
}
