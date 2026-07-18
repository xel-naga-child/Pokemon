using System;
using System.Collections.Generic;
using System.Text;

namespace PokeApiConnection.PokeConnection
{
    public interface IPokeApiGet<T> where T : class
    {
        public Task<T> GetAsync(string url);
    }
}
