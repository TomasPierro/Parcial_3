using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesParcial3.Modelo
{
    public class Venta
    {
        public string NombreProducto { get; set; }
        public int CantidadVendida { get; set; }

        public Venta (string nombreProducto, int cantidadVendida)
        {
            this.NombreProducto = nombreProducto;
            this.CantidadVendida = cantidadVendida;
        }
    }
}
