using System;
using System.Collections.Generic;
using System.Text;
using PokeBl.Model.Pokemon;

namespace PokeBl.BL.Pokemon
{
    public interface IPokemonBL
    {
        public Task<PokemonDTO> GetPokemonAsync(int id);
    }
}
