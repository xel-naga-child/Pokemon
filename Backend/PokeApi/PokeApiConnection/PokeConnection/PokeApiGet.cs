using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;

namespace PokeApiConnection.PokeConnection
{
    public class PokeApiGet<T> : IPokeApiGet<T> where T : class
    {
        public async Task<T> GetAsync(string url)
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
    }
}
