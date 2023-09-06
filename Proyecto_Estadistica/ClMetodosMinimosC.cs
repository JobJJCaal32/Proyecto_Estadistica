using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Estadistica
{
    internal class ClMetodosMinimosC
    {
        public double sumaC1, sumaC2, Columna3, sumaC4, sumaC5, b1, b0, sumaSCR,sumaSCE, R;
        public List<double> DatoColumna3 = new List<double>();

        public double Columna1(double Columna1)
        {
            return sumaC1 += Columna1;
        }

        public double Columna2(double Columna2)
        {
            return sumaC2 += Columna2;
        }

        public double Datob1()
        {
            return b1 = sumaC1 / sumaC2;
        }

        public double Datob0(double Mediax, double MediaY)
        {
            return b0 = MediaY - (b1 * Mediax);
        }

        public double DatoC3(double ValorX, int contador)
        {
            Columna3 = b0 + (b1 * ValorX);
            DatoColumna3.Add(Columna3);
            return Columna3;
        }

        public double Columna4(double SCT)
        {
            sumaC4 += SCT;
            return sumaC4;
        }

        public double SumaSCR(double SCR) {
            sumaSCR += SCR;

            return sumaSCR;
        } 

        public double SumaSCE(double SCE)
        {
            return sumaSCE += SCE;
        }


        public double DatoR(double R2)
        {
            return R = Math.Sqrt(R2);
        }



    }
}
