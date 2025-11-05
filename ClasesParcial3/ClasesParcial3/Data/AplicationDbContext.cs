using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClasesParcial3.Modelo;
using Microsoft.EntityFrameworkCore;


namespace ClasesParcial3.Data
{
    public class AplicationDbContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Venta> Ventas { get; set; }
        public DbSet<ReporteVenta> ReporteVentas { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=ParcialFinal;Trusted_Connection=true;TrustServerCertificate=True;");
        }
    }
}

