using System;
using System.Collections.Generic;
using System.Text;

namespace SEGREGACION
{
    class CTelefono: ITelefono
    {
        public void Imprimir()
        {
            Console.WriteLine("no permite imprimir");
        }
        public void Escanear()
        {
            Console.WriteLine("no permite escanear");
        }

        public void Telefono()
        {
            Console.WriteLine("llamando");
        }
    }
}
