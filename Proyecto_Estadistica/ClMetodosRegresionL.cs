using System;

namespace Proyecto_Estadistica
{
    internal class ClMetodosRegresionL
    {
        public double sumaC1, sumaC2, sumaC3, A, B, CovX, CovY, CovXY, R;
        //suma de cada columna
        public double Columna1(double dato)
        {
            sumaC1 += dato;
            return sumaC1;
        }

        public double Columna2(double dato)
        {
            sumaC2 += dato;
            return sumaC2;
        }

        public double Columna3(double dato)
        {
            sumaC3 += dato;
            return sumaC3;
        }

        public double DatoA(double sumaX, double sumaY, int contador)
        {
            A = (((contador * sumaC1) - (sumaX * sumaY)) / ((contador * sumaC2) - (Math.Pow(sumaX, 2))));
            return A;
        }
        public double DatoB(double sumaX, double sumaY, int contador)
        {
            B = (sumaY - (A * sumaX)) / (contador);
            return B;
        }

        public double DatoCovX(int contador, double MediaX)
        {
            CovX = Math.Sqrt((sumaC2 / contador) - (Math.Pow(MediaX, 2)));
            return CovX;
        }

        public double DatoCovY(int contador, double MediaY)
        {
            CovY = Math.Sqrt((sumaC3 / contador) - (Math.Pow(MediaY, 2)));
            return CovY;
        }

        public double DatoCovXY(int contador, double MediaX, double MediaY)
        {
            CovXY = (sumaC1 / contador) - (MediaX * MediaY);
            return CovXY;
        }

        public double DatoR()
        {
            return R = CovXY / (CovX * CovY);
        }

    }
}
