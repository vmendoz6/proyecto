using System;
using System.Collections.Generic;
using System.Text;

namespace INVERSION_DE_DEPENDENCIA
{
    class Administrador
    {
        private IAdministrar miTienda;

        public Administrador(IAdministrar pTienda)
        {
            miTienda = pTienda;
        }

        public double totalComida()
        {
            double total = 0;

            IEnumerable<Articulo> listado = miTienda.ObtenerArticulos(0);

            foreach (Articulo p in listado)
            {
                Console.WriteLine(p);
                total += p.Precio;
            }
            return total;
        }
    }
}
