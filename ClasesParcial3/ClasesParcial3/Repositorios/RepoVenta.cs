using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClasesParcial3.Modelo;
using ClasesParcial3.Data;
using Microsoft.EntityFrameworkCore;

namespace ClasesParcial3.Repositorios
{
    public class RepoVenta
    {
        public static void NuevaVenta(Venta venta)
        {
            using (var context = new AplicationDbContext())
            {
                context.Ventas.Add(venta);
                context.SaveChanges();
            }

        }
        public static List<Venta> ObtenerVentas() 
        { using (var context = new AplicationDbContext())
         { return context.Ventas.ToList(); 
         } 
        }
        public static void MostrarVentas()
        {
            var ventas = RepoVenta.ObtenerVentas();

            if (ventas.Count == 0)
            {
                Console.WriteLine("No hay ventas registradas todavía.");
                return;
            }

            foreach (var venta in ventas)
            {
                Console.WriteLine($"Venta N°{venta.Id} - Cliente ID: {venta.NombreClinete} - Producto ID: {venta.NombreProducto}");
            }
        }



    }
}
