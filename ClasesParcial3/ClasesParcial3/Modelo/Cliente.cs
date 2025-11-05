using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesParcial3.Modelo
{
    public class Cliente
    {
        public int ID { get; set; }
        public int DNI { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Gmail { get; set; }


        public Cliente (int DNI, string Nombre, string Apellido)
        {
            this.DNI = DNI;
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.Gmail = Gmail;
        }
    }
}
