using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Transporte
{
    public class Moto : MedioDeTransporte
    {
        public string Cilindrada { get; set; }

        public Moto(string color):base(color)
        {

        }
    }

}
