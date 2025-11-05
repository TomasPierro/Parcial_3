namespace ClasesParcial3.Modelo
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public int Cantidad { get; set; }
        public decimal Precio { get; set; }


        public Producto( string nombre, int cantidad, decimal precio)
        {
            this.Nombre = nombre;
            this.Cantidad = cantidad;
            this.Precio = precio;
        }

    }
}
