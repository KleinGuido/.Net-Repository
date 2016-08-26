using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformatorioPokedex.Data
{
    class TipoPlanta : Pokemon
    {
        public TipoPlanta(string n, string t, string ali, float p, float alt):base(n,t,ali,p,alt)
        {

        }

        public string LatigoCepa()
        {
            return "Pokemon usa Latigo Cepa! ";
        }
    }
}
