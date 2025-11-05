bool consola = true;

while (consola)
{
    Console.Clear();
    Console.WriteLine("Seleccione una opción:");
    Console.WriteLine("1. Registrar Nuevo Producto");
    Console.WriteLine("2. Registrar Nuevo Clinete");
    Console.WriteLine("3. Registrar Nueva Compra");
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
            }

            
            break;

        case 2:
            if (Entrada == 2)
            {

            }
            break;

        case 3:
            if (Entrada == 3)
            {

            }
            break;

        case 4:
            if (Entrada == 4)
            {

            }
            break;

        case 5:
            if (Entrada == 5)
            { }
            break;
    }
}

