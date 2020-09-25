using System;
using System.Collections.Generic;
using System.Text;

namespace principio_solid_2
{
    abstract class Cbase
    {
        protected CArticulo articulo;
        public CArticulo articulos { get => articulo; set => articulo = value; }

        public Cbase(CArticulo pArticulo)
        {

            articulos = pArticulo;
        }

        public override string ToString()
        {
            return articulo.ToString();
        }
        public abstract double calcularArticulo();
    }
    }
