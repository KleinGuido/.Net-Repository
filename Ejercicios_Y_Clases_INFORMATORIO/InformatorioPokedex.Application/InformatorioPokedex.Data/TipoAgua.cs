using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformatorioPokedex.Data
{
    class TipoAgua :Pokemon
    {
        public TipoAgua(string n, string t, string ali, float p, float alt):base(n,t,ali,p,alt)
        {

        }

        public string chorroDeAgua()
        {
            return "Pokemon usa Chorro de Agua! ";
        }
    }
}
