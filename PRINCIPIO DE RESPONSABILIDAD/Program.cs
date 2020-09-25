using System;
using System.Runtime.ConstrainedExecution;

namespace Principio_solid
{
    class Program
    {
        static void Main(string[] args)
        {
            CEmpleado empleado = new CEmpleado("victor", "operario", 34, 200000);

            Console.WriteLine(empleado);
            Console.WriteLine(CPagos.calcularImpuesto(empleado));

            CPagos.PagarImpuesto(empleado);
        }
    }
}
