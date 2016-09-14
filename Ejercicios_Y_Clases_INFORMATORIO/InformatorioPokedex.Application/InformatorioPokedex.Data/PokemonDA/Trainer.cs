using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformatorioPokedex.Data.PokemonDA
{
    public class Trainer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Pokemon> Pokemon { get; set}
    }
}
