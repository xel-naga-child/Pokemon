using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;
using PokeApiConnection.Configuration;

namespace PokeApiConnection.PokeConnection
{
    public class PokeApiGet<T> : IPokeApiGet<T> where T : class
    {
        public PokemonOptions _pokemonOptions;


        public PokeApiGet(PokemonOptions pokemonOptions)
        {
            this._pokemonOptions = pokemonOptions;
        }
        public async Task<T> GetAsync(int id)
        {
            string url = $"{_pokemonOptions.ApiUrl}/{id}";
            try
            {
                using (var httpClient = new HttpClient())
                {
                    var response = await httpClient.GetAsync(url);
                    response.EnsureSuccessStatusCode();
                    var jsonResponse = await response.Content.ReadAsStringAsync();
                    var deserializedObject = JsonSerializer.Deserialize<T>(jsonResponse);
                    return deserializedObject;
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException($" {url}: {ex.Message}", ex);
            }
        }
    }
}
