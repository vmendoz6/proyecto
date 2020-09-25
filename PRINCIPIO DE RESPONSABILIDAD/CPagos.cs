using System;
using System.Collections.Generic;
using System.Text;

namespace Principio_solid
{
    class CPagos
    {
        public static double calcularImpuesto(CEmpleado pEmpleado)
        {
            return pEmpleado.Sueldo * 0.19;

        }

        public static void PagarImpuesto(CEmpleado pEmpleado)
        {
            double imp = calcularImpuesto(pEmpleado);
            Console.WriteLine("el impuesto es {0} del señor {1}", imp, pEmpleado.Nombre);
        }

        
    }
}
