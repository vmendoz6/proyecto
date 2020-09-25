using System;
using System.Collections.Generic;
using System.Text;

namespace principio_solid_2
{
    class CComida : Cbase
    {
        public CComida(CArticulo pArticulo) :base(pArticulo)
        {

        }
        public override double calcularArticulo()
        {
            articulo.Precio *= 0.19;
            return articulo.Precio;
        }
    }
}
