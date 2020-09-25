using System;

namespace De_LISKOV
{
    class Program
    {
        static void Main(string[] args)
        {
            CInicial miNoticiero = new CNoticiero(" buenos dias");
            miNoticiero.Muestra();

            CInicial miRadio = new CRadio(" como estan?");
            miRadio.Muestra();

            
        }
    }
}
