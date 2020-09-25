using System;
using System.Collections.Generic;
using System.Text;

namespace principio_solid_2
{
    class Cmedicamento : Cbase
    {
        public Cmedicamento(CArticulo pArticulo) : base (pArticulo)
        {

        }

        public override double calcularArticulo()
        {
            articulo.Precio *= 0.10;
            return articulo.Precio;
        }
    }
}
