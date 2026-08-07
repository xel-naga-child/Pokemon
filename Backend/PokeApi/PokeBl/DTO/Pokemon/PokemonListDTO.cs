using PokeBl.Model.Pokemon;
using System;
using System.Collections.Generic;
using System.Text;

namespace PokeBl.DTO.Pokemon
{
    public class PokemonListDTO
    {
        public int count { get; set; }
        public string next { get; set; }
        public string previous { get; set; }
        public List<PokemonDTO> results { get; set; }
    }
}
