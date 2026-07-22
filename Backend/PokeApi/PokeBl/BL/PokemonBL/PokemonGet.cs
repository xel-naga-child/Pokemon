using PokeApiConnection.PokeConnection;
using PokeBl.Model.Pokemon;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace PokeBl.BL.PokemonBL
{
    public class PokemonGet
    {
        PokeApiGet<Pokemon> _pokeApiGet;
        string _url;

        public PokemonGet(string url, PokeApiGet<Pokemon> pokeApiGet)
        {
            _pokeApiGet = pokeApiGet;
            _url = url;
        }

        public async Task<Pokemon> GetSinglePokemonAsync<T>(int id) where T : class
        {
            Pokemon pokemon = await _pokeApiGet.GetAsync(_url+id);
            return pokemon;
        }
    }
}
