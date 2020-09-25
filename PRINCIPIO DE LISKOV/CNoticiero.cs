using System;
using System.Collections.Generic;
using System.Text;

namespace De_LISKOV
{
    class CNoticiero: CInicial
    {
        

        public CNoticiero(string pMensaje): base (pMensaje)
        {
            mensaje = pMensaje;
        }

        public override   void Muestra()
        {
            Console.WriteLine("emitiendo desde el noticiero: {0}", mensaje);
        }
    }
}
