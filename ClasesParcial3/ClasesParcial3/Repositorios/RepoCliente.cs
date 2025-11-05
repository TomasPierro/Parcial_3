using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClasesParcial3.Data;
using ClasesParcial3.Modelo;

namespace ClasesParcial3.Repositorios
{
    public class RepoCliente
    {
        public static void AgregarCliente(Cliente cliente)
        {
            using (var context = new AplicationDbContext())
            {
                context.Clientes.Add(cliente);
                context.SaveChanges();
            }
        }
    }
}
