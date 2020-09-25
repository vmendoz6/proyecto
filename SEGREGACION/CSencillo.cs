using System;
using System.Collections.Generic;
using System.Text;

namespace SEGREGACION
{
    class CSencillo: IMultiSencillo
    {
        public void Imprimir()
        {
            Console.WriteLine("imprimiendo");
        }
        public void Escanear()
        {
            Console.WriteLine("Escanenado");
        }
        public void Telefono()
        {
            Console.WriteLine("llamando");
        }

    }
}
