using System;

namespace SEGREGACION
{
    class Program
    {
        static void Main(string[] args)
        {
            CMultiAccion accion = new CMultiAccion();
            accion.Imprimir();
            accion.Escanear();
            accion.Telefono();

            Console.WriteLine("-------");

            CTelefono miTelefono =  new  CTelefono ();
            miTelefono.Imprimir();
            miTelefono.Escanear();

            Console.WriteLine("------");

            CSencillo sencillo = new CSencillo();
            sencillo.Imprimir();
            sencillo.Escanear();

        }
    }
}
