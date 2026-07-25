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
      
        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetPokemon(int id)
        {
            throw new NotImplementedException();
        }
    }
}
