using InformatorioPokedex.Bussiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformatorioPokedex.Application
{
    class Program
    {
        static void Main(string[] args)
        {
            var pokedex = new Pokedex();

            Console.WriteLine("Bienvenido a POKEMON");
            Console.ReadKey();

            Console.Write("Desea registrar POKEMON (S/N) ");
            string dato = Console.ReadLine();

            while (dato == "S")
            {
                Console.Write(" 1-Registrar 2-VerLista: ");
                dato = Console.ReadLine();
            }

            if (dato == "1")
            {
                Console.WriteLine("Registrando un nuevo POKEMON: ");

                Console.Write("Escriba el POKEMON a registrar: Squartle / Charmander / Bulbasaur "); 
                string nombre = Console.ReadLine();

                Console.Write("Tipo: Fuego, Agua, Planta: ");
                string tipo = Console.ReadLine();

                Console.Write("Alias: ");
                string alias = Console.ReadLine();

                Console.Write("Peso: ");
                string peso = Console.ReadLine();

                Console.Write("Altura: ");
                string altura = Console.ReadLine();

                pokedex.registro (nombre, tipo, alias, peso, altura);

                Console.Write("Seguir utilizando la Pokédex? S-N: ");
                dato = Console.ReadLine();
                
            }
            else
            {
                pokedex.mostrarCapturados();
              
            }
        }
    }
}    

