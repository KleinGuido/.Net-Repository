using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Transporte
{
    public class Auto : MedioDeTransporte
    {

        public Auto(string color, string marca, string modelo, int añoFabricacion):base(color)
        {
            this.Color = color;
            this.Marca = marca;
            this.Modelo = modelo;
            this.AñoFabricacion = añoFabricacion;
        }

        public string Color { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int AñoFabricacion { get; set; }


        public void Mover (int metros, string direccion)
        {
            Console.WriteLine("El auto se movio {0} hacia {1}", metros, direccion);

        }

        public string NombreCompleto()
        {
            var NombreCompleto = Marca + " " + Modelo + " " + AñoFabricacion;
            return NombreCompleto;
        }
    }

}
