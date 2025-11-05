using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesParcial3.Modelo
{
    public class ReporteVenta : Venta
    {
       public string NombreCliente { get; set; }
         public decimal TotalVenta { get; set; }
    
          public ReporteVenta(string nombreProducto, int cantidadVendida, string nombreCliente, decimal totalVenta) : base(nombreProducto, cantidadVendida)
          {
                this.NombreCliente = nombreCliente;
                this.TotalVenta = totalVenta;
          }

    }
}
