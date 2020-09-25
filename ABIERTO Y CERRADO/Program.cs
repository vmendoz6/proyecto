using System;
using System.Collections.Generic;

namespace principio_solid_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Cbase> articulos = new List<Cbase>
            {
                new CComida(new CArticulo("tomates",1,200)),
                new Cmedicamento(new CArticulo("aspirina",2,500)),
                new CComida(new CArticulo("cebolla",1,300)),
                new Cmedicamento(new CArticulo("ibuprofeno",2,600))
            };
            CMercado miMercado = new CMercado(articulos);
            miMercado.calcularInventario();
               
        }
    }
}
