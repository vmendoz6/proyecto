using System;

namespace INVERSION_DE_DEPENDENCIA
{
    class Program
    {
        static void Main(string[] args)
        {
            Tienda miTienda = new Tienda();
            double total = 0;

            miTienda.AgregarArticulo(new Articulo("cebolla", 0, 1000));
            miTienda.AgregarArticulo(new Articulo("camisa", 1, 2000));
            miTienda.AgregarArticulo(new Articulo("ibuprofeno", 2, 3000));

            Console.WriteLine("-------");

            Administrador miAdministrador = new Administrador(miTienda);
            total = miAdministrador.totalComida();

            Console.WriteLine(" comida total es {0}", total);
        }
    }
}
