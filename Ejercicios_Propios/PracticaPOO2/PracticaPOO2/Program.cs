using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPOO2
{
    class Program
    {
        static void Main(string[] args)
        {
            datos d = new datos();

            Console.WriteLine("Nombre PKM: ");

            d.setNombrePkm(Console.ReadLine());

            Console.WriteLine("El PKM capturado es: " + d.getNombrePkm());

            Console.ReadKey();
        }
    }
}
