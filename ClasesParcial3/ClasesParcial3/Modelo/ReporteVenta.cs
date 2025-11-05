using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesParcial3.Modelo
{
    public class ReporteVenta 
    {
        public int Id { get; set; }
        public string NombreCliente { get; set; }
        public decimal TotalVenta { get; set; }
    
          public ReporteVenta(string nombreProducto, string nombreCliente, decimal totalVenta) 
          {
                this.NombreCliente = nombreCliente;
                this.TotalVenta = totalVenta;
          }

    }
}
