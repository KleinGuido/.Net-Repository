using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1.Transporte;

namespace Poo
{
    class Program
    {
        static void Main(string[] args)
        {
            var auto1 = new Auto("Rosado","BMW","Un modelo ahi",2016);
            auto1.Mover(100, "Norte");
            string nombreCompleto = auto1.NombreCompleto();
            Console.WriteLine(nombreCompleto);

            Console.ReadLine();
        }
    }
}
