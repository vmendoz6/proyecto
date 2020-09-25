using System;
using System.Collections.Generic;
using System.Text;

namespace principio_solid_2
{
    class CMercado
    {
        private List<Cbase> articulos;
        public CMercado(List<Cbase> pArticulos)
        {
            articulos= pArticulos;
        }
        public void calcularInventario()
        {
            double total = 0;
            foreach (var articulo in articulos)
            {
                Console.WriteLine(articulo);
                total += articulo.articulos.Precio;
                Console.WriteLine("el total de articulos en inventario es {0}", total);
            }
            
        }
    }
}
