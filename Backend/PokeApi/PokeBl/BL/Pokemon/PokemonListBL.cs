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
        private IPokeApiGet<PokemonDTO> _pokeApiGetDetails;


        public PokemonListBL(IPokeApiGet<PokemonListDTO> pokeApiGet, IPokeApiGet<PokemonDTO> pokeApiGetDetails)
        {
            this._pokeApiGet = pokeApiGet;
            this._pokeApiGetDetails = pokeApiGetDetails;
        }
    

        public async Task<PokemonListDTO> ListPokemonAsync(int offSet = 0, int limit = 20)
        {
            return await _pokeApiGet.GetListAsync(offset: offSet, limit: limit);

        }

        public async Task<List<PokemonDTO>> ListPokemonDetailsAsync(int offSet = 0, int limit = 20)
        {
            var taskList = new List<Task<PokemonDTO>>();

            for (int i = offSet + 1; i <= offSet + limit; i++)
            {
                var pokemonDetails = _pokeApiGetDetails.GetAsync(i);
                taskList.Add(pokemonDetails);
            }

            var pokemonList = await Task.WhenAll(taskList);

            return pokemonList.ToList();

        }
    }
}
