using PokeApiConnection.PokeConnection;
using PokeBl.DTO.Pokemon;
using PokeBl.Model.Pokemon;
using System;
using System.Collections.Generic;
using System.Text;

namespace PokeBl.BL.Pokemon
{
    public class PokemonListBL : IPokemonListBL
    {
        private IPokeApiGet<PokemonListDTO> _pokeApiGet;

        public PokemonListBL(IPokeApiGet<PokemonListDTO> pokeApiGet)
        {
            this._pokeApiGet = pokeApiGet;
        }
    

        public async Task<PokemonListDTO> ListPokemonAsync(int offSet = 0, int limit = 20)
        {
            return await _pokeApiGet.GetListAsync(offset: offSet, limit: limit);

        }

    }
}
