using PokeBl.DTO.Pokemon;
using System;
using System.Collections.Generic;
using System.Text;

namespace PokeBl.BL.Pokemon
{
    public interface IPokemonListBL
    {
        public Task<PokemonListDTO> ListPokemonAsync(int offSet = 0, int limit = 20);
    }
}
