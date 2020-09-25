using System;
using System.Collections.Generic;
using System.Text;

namespace SEGREGACION
{
    class CMultiAccion : IMultiCompleto
    {
        public void Imprimir()
        {
            Console.WriteLine("imprimiendo");
        }
        public void Escanear()
        {
            Console.WriteLine("Escaneando");
        }
        public void Telefono()
        {
            Console.WriteLine("llamando");
        }

    }
}
