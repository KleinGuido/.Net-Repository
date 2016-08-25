using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformatorioPokedex.Data
{
    public class Pokemon
    {
        public string nombre { get; set; }
        public string tipo { get; set; }
        public string alias { get; set; }
        public float peso { get; set; }
        public float altura { get; set; }

        public Pokemon(string n, string t, string ali, float p, float alt)
        {
            nombre = n;
            tipo = t;
            alias = ali;
            peso = p;
            altura = alt;
        }
    }
}
