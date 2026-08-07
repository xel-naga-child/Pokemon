using PokeBl.BL.Pokemon;
using System;
using System.Collections.Generic;
using System.Text;
using PokeBl.Model.Pokemon;
using PokeApiConnection.PokeConnection;
namespace PokeBl.BL.PokemonBL
{
    public class PokemonBL : IPokemonBL
    {
        private IPokeApiGet<PokemonDTO> _pokeApiGet;

        public PokemonBL(IPokeApiGet<PokemonDTO> pokeApiGet)
        {
            this._pokeApiGet = pokeApiGet;
        }
        public async Task<PokemonDTO> GetPokemonAsync(int id)
        {
            
            return await _pokeApiGet.GetAsync(id);
        }
    }
}
