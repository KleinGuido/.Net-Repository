using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1, numero2, numero3;

            Console.WriteLine("Ingrese el primer numero: ");

            numero1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo numero: ");

            numero2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el tercer numero: ");

            numero3 = Convert.ToInt32(Console.ReadLine());

            if (numero1 < numero2)
            {
                if (numero2 < numero3)
                {
                    Console.WriteLine("Los numeros fueron ingresados en orden creciente");
                }

                else
                {
                    Console.WriteLine("Los numerons no fueron ingresados en orden creciente");
                }
            }
            else
            {
                Console.WriteLine("Los numerons no fueron ingresados en orden creciente");
            }

            Console.ReadLine();
        }
    }
}
