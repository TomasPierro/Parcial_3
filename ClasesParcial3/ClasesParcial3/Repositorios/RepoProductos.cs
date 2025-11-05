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
    public class RepoProductos
    {
        public static void AgregarProductos(Producto productos)
        {
            using (var context = new AplicationDbContext())
            {
                context.Productos.Add(productos);
                context.SaveChanges();
            }
        }
    }
}
    