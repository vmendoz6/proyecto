using System;
using System.Collections.Generic;
using System.Text;

namespace De_LISKOV
{
     abstract    class CInicial
    {
        protected string mensaje;

        public CInicial(string pMensaje)
        {
            mensaje = pMensaje;
        }
        public abstract void Muestra();
    }
}
