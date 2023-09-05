using System;
using System.Collections.Generic;

namespace Proyecto_Estadistica
{
    internal class Media
    {
        public double MediaX = 0, MediaY;
        public List<double> datoX = new List<double>();
        public List<double> datoY = new List<double>();
        public double DatoMedia(Double suma, int Contador)
        {
            return suma/Contador;
        }
    }
}
