using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.WriteLine("Ingrese un numero :");

            numero = Convert.ToInt32(Console.ReadLine());

            if (numero % 2 == 0)
            {

                Console.WriteLine("El numero es par");
            }
            else
            {
                Console.WriteLine("El numero es impar");
            }
            ;

            Console.ReadLine();

        }
    }
}
