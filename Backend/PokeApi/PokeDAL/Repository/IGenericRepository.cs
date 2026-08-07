using System;
using System.Collections.Generic;
using System.Text;

namespace PokeDAL.Repository
{
    internal interface IGenericRepository
    {
        public Task<T> GetByIdAsync<T>(int id) where T : class;
    }
}
