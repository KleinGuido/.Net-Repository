using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.WriteLine("Ingrese un numero del 1 al 7 : ");

            numero = Convert.ToInt32(Console.ReadLine());

            while (numero < 1 || numero > 7){

                Console.WriteLine("Vuelva a intentar. Ingrese un numero del 1 al 7 : ");

                numero = Convert.ToInt32(Console.ReadLine());
            };

            if (numero == 1)
            {
                Console.WriteLine("El dia 1 es Lunes");
            }
            else if (numero == 2)
            {
                Console.WriteLine("El dia 2 es Martes");
            }
            else if (numero == 3)
            {
                Console.WriteLine("El dia 3 es Miercoles");
            }
            else if (numero == 4)
            {
                Console.WriteLine("El dia 4 es Jueves");
            }
            else if (numero == 5)
            {
                Console.WriteLine("El dia 5 es Viernes");
            }
            else if (numero == 6)
            {
                Console.WriteLine("El dia 6 es Sabado");
            }
            else if (numero == 7)
            {
                Console.WriteLine("El dia 7 es Domingo");
            }

            Console.ReadLine();
        }
    }
}
