using System;
using System.Collections.Generic;
using System.Text;

namespace INVERSION_DE_DEPENDENCIA
{
    class Articulo
    {
        private string nombre;
        private int categoria;
        private double precio;

        public string Nombre { get => nombre; set => nombre = value; }
        public int Categoria { get => categoria; set => categoria = value; }
        public double Precio { get => precio; set => precio = value; }

        public Articulo (string pNombre, int pCategoria,  double pPrecio)
        {
            nombre = pNombre;
            categoria = pCategoria;
            precio = pPrecio;
        }

        public override string ToString()
        {
            string strCategoria = "";

            if (categoria == 0)
                strCategoria = "Comida";
            else if (categoria == 1)
                strCategoria = ",medicamento";
            else if (categoria == 2)
                strCategoria = "ropa";

            return string.Format("{0}, categoria {1}, precio {2}", nombre, strCategoria, precio);
        }
    }
}
