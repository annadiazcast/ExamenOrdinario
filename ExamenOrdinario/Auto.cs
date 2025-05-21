﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenOrdinario
{
    internal class Auto:Vehiculo
    {
        public Auto(int id, string marca, string modelo, int anio, string color, double precio, string estado)
         : base(id, marca, modelo, anio, color)
        {
            Precio = precio;
            Estado = estado;
        }

        public Auto() { }

        public double Precio { get; set; }
        public string Estado { get; set; }
    }
}
