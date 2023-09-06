using System;
using System.Collections.Generic;

namespace Proyecto_Estadistica
{
    internal class Media
    {
        public double MediaX = 0, MediaY;
        public double DatoMedia(Double suma, int Contador)
        {
            return suma/Contador;
        }
    }
}
