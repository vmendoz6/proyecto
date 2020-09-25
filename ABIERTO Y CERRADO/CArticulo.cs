using System;
using System.Collections.Generic;
using System.Text;

namespace principio_solid_2
{
    class CArticulo
    {
        private string nombre;
        private int categoria;
        private double precio;

        public string Nombre { get => nombre; set => nombre = value; }
        public int Categoria { get => categoria; set => categoria = value; }
        public double Precio { get => precio; set => precio = value; }
        public CArticulo(string pNombre, int pCategoria,  double pPrecio)
        {
            nombre = pNombre;
            categoria = pCategoria;
            precio = pPrecio;
           

        }
        public override string ToString()
        {
            return string.Format("el articulo cuesta {0} cuesta {1}",nombre, precio);
        }


    }
}
