using System;
using System.Collections.Generic;
using System.Text;

namespace De_LISKOV
{
    class CRadio : CInicial
    {
        public CRadio(string pMensaje):base (pMensaje)
        {

        }

        public override void Muestra()
        {
            Console.WriteLine("emitiendo desde el radio:{0}", mensaje);
        }
    }
}
