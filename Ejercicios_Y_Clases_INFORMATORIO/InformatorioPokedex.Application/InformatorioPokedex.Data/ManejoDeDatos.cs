using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InformatorioPokedex.Data.PokemonDA;

namespace InformatorioPokedex.Data
{
    public class ManejoDeDatos
    {
        public PokemonContext PokemonContext { get; set; }
        public ManejoDeDatos()
        {
            this.PokemonContext = new PokemonContext();
        }

        public void Add (Pokemon p)
        {
            var pokemonDb = new InformatorioPokedex.Data.PokemonDA.Pokemon();
            
            this.PokemonContext.Pokemon.Add(p);

            this.PokemonContext.SaveChanges();
        }


    
    
        //agregar pokemons
        //devolver una lista con todos los pokemon registrados hasta el momento

        public void registroPokemon(string nombre, string tipo, string alias, float peso, float altura)
        {
            if (tipo == "Fuego")
            {
                DatosPokemon.pokemons.Add(new TipoFuego(nombre, tipo, alias, peso, altura));
                Console.WriteLine("Registrando nuevo Pokemon");
                Console.WriteLine("Done");
            }
            else if (tipo == "Agua")
            {
                DatosPokemon.pokemons.Add(new TipoAgua(nombre, tipo, alias, peso, altura));
                Console.WriteLine("Registrando nuevo Pokemon");
                Console.WriteLine("Done");
            }
            else if (tipo == "Planta")
            {
                DatosPokemon.pokemons.Add(new TipoPlanta(nombre, tipo, alias, peso, altura));
                Console.WriteLine("Registrando nuevo Pokemon");
                Console.WriteLine("Done");
            }

        }

        public void mostrarListaCapturados()
        {
            foreach (Pokemon pkm in DatosPokemon.pokemons)
            {          
                Console.WriteLine(pkm.nombre);

                Console.WriteLine(pkm.tipo);

                Console.WriteLine(pkm.alias);

                Console.WriteLine(pkm.peso);

                Console.WriteLine(pkm.altura);

                if (pkm.tipo == "Agua")
                {
                    TipoAgua agua = new TipoAgua(pkm.nombre, pkm.tipo, pkm.alias, pkm.peso, pkm.altura);
                    Console.WriteLine(agua.chorroDeAgua());
                }
                else if (pkm.tipo == "Fuego")
                {
                    TipoFuego fuego = new TipoFuego(pkm.nombre, pkm.tipo, pkm.alias, pkm.peso, pkm.altura);
                    Console.WriteLine(fuego.Lanzallamas());
                }
                else
                {
                    TipoPlanta planta = new TipoPlanta(pkm.nombre, pkm.tipo, pkm.alias, pkm.peso, pkm.altura);
                    Console.WriteLine(planta.LatigoCepa());
                }
            }
        }


    }
}
