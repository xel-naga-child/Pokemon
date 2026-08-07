using System;
using System.Collections.Generic;
using System.Text;

namespace PokeBl.Model.Pokemon
{
    public class PokemonDTO
    {
        public int id { get; set; }
        public string name { get; set; }
        public int base_experience { get; set; }
        public int height { get; set; }
        public int order { get; set; }
        public int weight { get; set; }
        //TODO: abilities, forms, game_indices, held_items, location_area_encounters, moves, species, sprites, stats, types

    }
}
