using ClasesParcial3.Repositorios;
using ClasesParcial3.Modelo;
using ClasesParcial3.Data;




internal class Program
{
    private static void Main(string[] args)
    {
        int opcion = 0;
        while (opcion != 5)
        {
            Console.Clear();
            Console.WriteLine("Seleccione una opción:");
            Console.WriteLine("1. Registrar Nuevo Producto");
            Console.WriteLine("2. Registrar Nuevo Clinete");
            Console.WriteLine("3. Registrar Nueva venta");
            Console.WriteLine("4. Mostrar reporte de ventas");
            int Entrada = int.Parse(Console.ReadLine());
            switch (Entrada)
            {
                case 1:
                    if (Entrada == 1)
                    {
                        Console.WriteLine("Ingrese Nombre del Producto:");
                        string nombreProducto = Console.ReadLine();
                        Console.WriteLine("Ingrese Cantidad del Producto:");
                        int cantidadProducto = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese Precio del Producto:");
                        decimal precioProducto = decimal.Parse(Console.ReadLine());
                        Producto nuevoProducto = new Producto(nombreProducto, cantidadProducto, precioProducto);
                        RepoProductos.AgregarProductos(nuevoProducto);
                        Console.WriteLine("Producto registrado con éxito. Presione cualquier tecla para continuar.");
                    }

                    break;

                case 2:
                    if (Entrada == 2)
                    {
                        Console.WriteLine("Ingrese DNI del Cliente:");
                        int DNI = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese Nombre del Cliente:");
                        string nombreCliente = Console.ReadLine();
                        Console.WriteLine("Ingrese Apellido del Cliente:");
                        string apellidoCliente = Console.ReadLine();
                        Console.WriteLine("Ingrese Gmail del Cliente:");
                        string gmailCliente = Console.ReadLine();
                        Cliente nuevoCliente = new Cliente(DNI, nombreCliente, apellidoCliente, gmailCliente);
                        RepoCliente.AgregarCliente(nuevoCliente);
                        Console.WriteLine("Cliente registrado con éxito. Presione cualquier tecla para continuar.");
                    }

                    break;

                case 3:
                    if (Entrada == 3)
                    {
                        Console.WriteLine("ingrese nombre cliente");
                        string nombreClienteVenta = Console.ReadLine();
                        Console.WriteLine("ingrese nombre producto");
                        string nombreProductoVenta = Console.ReadLine();
                        Console.WriteLine("ingrese cantidad");
                        int cantidadProductoventa = int.Parse(Console.ReadLine());
                        Venta nuevaVenta = new Venta(nombreClienteVenta, nombreProductoVenta);
                        RepoVenta.NuevaVenta(nuevaVenta);
                        Console.WriteLine("Venta registrada con éxito. Presione cualquier tecla para continuar.");

                    }
                    break;

                case 4:
                    if (Entrada == 4)
                    {
                        Console.WriteLine("reporte de ventas:");
                        RepoVenta.MostrarVentas();
                        Console.WriteLine("Presione cualquier tecla para continuar.");

                    }
                    break;

            }
        }
    }
}