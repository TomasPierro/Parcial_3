using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesParcial3.Modelo
{
    public class Venta 
    {
        public int Id { get; set; }
        public string NombreClinete { get; set; }
        public Cliente Cliente { get; set; }
        public string NombreProducto { get; set; }
        public string CantidadProducto { get; set; }
        public Producto Producto { get; set; }


        public Venta(string NombreCliente ,string nombreProducto) 
        {
            this.NombreClinete = NombreCliente;

        }
        
    }
}
