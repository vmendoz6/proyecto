﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Principio_solid
{
    class CEmpleado
    {
        private String nombre;
        private string puesto;
        private int edad;
        private double sueldo;

        public string Nombre { get => nombre; set => nombre = value; }
        public double Sueldo { get => sueldo; set => sueldo = value; }


        public CEmpleado (string pNombre, string pPuesto, int pEdad, double pSueldo)
            {
            nombre = pNombre;
            puesto = pPuesto;
            edad = pEdad;
            sueldo = pSueldo;
           
            }
    public override  string ToString()
    {
        return string.Format("{0},{1},{2},{3}", nombre, puesto, edad, sueldo);
    }
     
    }
}
