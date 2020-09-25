using System;
using System.Collections.Generic;
using System.Text;

namespace INVERSION_DE_DEPENDENCIA
{
    interface IAdministrar
    {
        IEnumerable<Articulo> ObtenerArticulos(int pCategoria);

    }
}
