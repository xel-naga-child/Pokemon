using System;
using System.Collections.Generic;
using System.Text;

namespace PokeApiConnection.PokeConnection
{
    internal interface IPokeApiPost<T> where T : class
    {
        public Task<T> PostAsync<TT>(string url, string jsonParams);
    }
}
