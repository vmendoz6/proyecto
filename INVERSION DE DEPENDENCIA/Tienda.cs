using System;
using System.Collections.Generic;
using System.Text;

namespace INVERSION_DE_DEPENDENCIA
{
    class Tienda: IAdministrar
    {
        private List<Articulo> inventario;

        
        public Tienda()
        {
            inventario = new List<Articulo>();
        }

        public void AgregarArticulo(Articulo pArticulo)
        {
            inventario.Add(pArticulo);
            Console.WriteLine(" Agregar {0}", pArticulo.Nombre);
        }

        public IEnumerable<Articulo> ObtenerArticulos (int pCategoria)
        {
            List<Articulo> encontrados = new List<Articulo>();

            foreach (Articulo p in inventario)
            {
                if (p.Categoria == pCategoria)
                    encontrados.Add(p);
            }

            return encontrados;

        }
    }
}
