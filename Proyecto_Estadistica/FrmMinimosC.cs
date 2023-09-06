using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Proyecto_Estadistica
{
    public partial class FrmMinimosC : Form
    {
        //instancia a la clase Media para poder usar sus metodos y acceder a sus atributos
        Media datos = new Media();
        //instancia a la clase ClMetodosMinimosC
        ClMetodosMinimosC metodos = new ClMetodosMinimosC();
        public FrmMinimosC()
        {
            InitializeComponent();
            label19.Enabled = false;
        }

        private void BtnIDatos_Click(object sender, EventArgs e)
        {
            double x, y;

            if (TxtDatoX.Text == "")
            {
                MessageBox.Show("Por favor ingrese los dos dato para que no haya errores");
                TxtDatoX.Focus();
                TxtDatoX.Clear();
            }
            else if (TxtDatoY.Text == "")
            {
                MessageBox.Show("Por favor ingrese los dos dato para que no haya errores");
                TxtDatoY.Focus();
                TxtDatoY.Clear();
            }
            else
            {
                x = Convert.ToDouble(TxtDatoX.Text);
                y = Convert.ToDouble(TxtDatoY.Text);
                //se agregan los datos a los listbox
                LbDatosX.Items.Add(x);
                LbDatosY.Items.Add(y);

                TxtDatoX.Clear();
                TxtDatoY.Clear();
                TxtDatoX.Focus();

            }
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            imprecion();
            int contador = LbDatosX.Items.Count;
            double SCR, R2;
            for (int i=0; i<contador; i++)
            {
                SCR = Math.Pow((metodos.DatoColumna3[i] - datos.MediaY),2);
                metodos.SumaSCR(SCR);
                LbColumna5.Items.Add("( " + metodos.DatoColumna3[i] + " - " + datos.MediaY + ") = " + SCR);
            }
            TxtSumaC5.Text = Convert.ToString(metodos.sumaSCR);
            R2 = metodos.sumaSCR / metodos.sumaC4;
            metodos.DatoR(R2);
            TxtR2.Text = Convert.ToString(R2);
            TxtR.Text = Convert.ToString(metodos.R);
            label19.Text = "Suma∑SCR";


        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            imprecion();
            int contador = LbDatosX.Items.Count;
            double SCE, ValorY, R2;
            String Valor;
            for (int i = 0; i < contador; i++)
            {
                Valor = LbDatosY.Items[i].ToString();
                ValorY = Convert.ToDouble(Valor);
                SCE = Math.Pow((ValorY - metodos.DatoColumna3[i]), 2);
                metodos.SumaSCE(SCE);
                LbColumna5.Items.Add("( " + metodos.DatoColumna3[i] + " - " + datos.MediaY + ") = " + SCE);
            }

            TxtSumaC5.Text = Convert.ToString(metodos.sumaSCE);
            R2 = 1 - (metodos.sumaSCE / metodos.sumaC4);
            metodos.DatoR(R2);
            TxtR2.Text = Convert.ToString(R2);
            TxtR.Text = Convert.ToString(metodos.R);
            label19.Text = "Suma∑SCE";
        }

        public void imprecion()
        {
            #region Variables 
            //se usa cout para poder obtener la cantidad de elementos que tenga el LbdatosX
            int contador = LbDatosX.Items.Count;
            //son las medias aritmeticas
            double sumaX = 0, sumaY = 0, ValorX = 0, ValorY = 0;
            double Columna1 = 0, Columna2 = 0, SCT = 0, b1 = 0, b0 = 0;
            //para poder obetener el valor del ListBox
            String Valor;
            #endregion

            #region Primera parte Impresion Datos
            //para poder sumar los datos
            for (int i = 0; i < contador; i++)
            {
                Valor = LbDatosX.Items[i].ToString();
                sumaX += Convert.ToDouble(Valor);

                Valor = LbDatosY.Items[i].ToString();
                sumaY += Convert.ToDouble(Valor);

            }
            //se manda los datos al metodo media y que calcule la media de cada uno 
            //a su vez se llama a las variables de la clase Metodos mediax y mediay para poder asignarles el valor
            datos.MediaX = datos.DatoMedia(sumaX, contador);
            datos.MediaY = datos.DatoMedia(sumaY, contador);
            //se imprime las medias
            TxtMediaX.Text = Convert.ToString(datos.MediaX);
            TxtMediaY.Text = Convert.ToString(datos.MediaY);
            #endregion

            //se hizo una segunda parte porque en la primera solo obtenenmos las medias y no se puede hacer 
            //todo en un for ya que no se puede operar sin las medias 
            #region Segunda Parte Impresion Datos
            for (int i = 0; i < contador; i++)
            {
                Valor = LbDatosX.Items[i].ToString();
                ValorX = Convert.ToDouble(Valor);
                sumaX += ValorX;

                Valor = LbDatosY.Items[i].ToString();
                ValorY = Convert.ToDouble(Valor);
                sumaY += ValorY;

                //datos de la Columna1 (X-X)(Y-Y)
                Columna1 = (ValorX - datos.MediaX) * (ValorY - datos.MediaY);
                LbColumna1.Items.Add("(" + ValorX + " - " + datos.MediaX + " ) " +
                    "(" + ValorY + " - " + datos.MediaY + " ) = " + Columna1);
                metodos.Columna1(Columna1);

                //datos de la columna2 
                Columna2 = Math.Pow((ValorX - datos.MediaX), 2);
                LbColumna2.Items.Add("(" + ValorX + " - " + datos.MediaX + " ) = " + Columna2);
                metodos.Columna2(Columna2);


            }
            metodos.Datob1();
            metodos.Datob0(datos.MediaX, datos.MediaY);
            //impresion de sumas en los TextBox de cada columna 
            TxtSumaC1.Text = Convert.ToString(metodos.sumaC1);
            TxtSumaC2.Text = Convert.ToString(metodos.sumaC2);
            TxtB1.Text = Convert.ToString(metodos.b1);
            TxtBo.Text = Convert.ToString(metodos.b0);
            #endregion
            //se hace una tercera parte para los ultimos datos
            #region Tercera Parte Impresion Datos
            for (int i = 0; i < contador; i++)
            {
                Valor = LbDatosX.Items[i].ToString();
                ValorX = Convert.ToDouble(Valor);
                sumaX += ValorX;

                Valor = LbDatosY.Items[i].ToString();
                ValorY = Convert.ToDouble(Valor);
                sumaY += ValorY;

                //datos de la Columna 3
                metodos.DatoC3(ValorX, contador);
                LbColumna3.Items.Add(metodos.b0 + " -" + "( " + metodos.b1 + " * " +
                                     ValorX + " ) = " + metodos.Columna3);

                //Datos de la Columna 4
                SCT = Math.Pow((ValorY - datos.MediaY),2);
                metodos.Columna4(SCT);
                LbColumna4.Items.Add("(" + ValorY + " - " + datos.MediaY + " ) = " + SCT );

            }

            TxtSumaC4.Text = Convert.ToString(metodos.sumaC4);
                #endregion

            }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            Principal fp = new Principal();
            this.Dispose();
            fp.Show();
        }

        private void FrmMinimosC_Load(object sender, EventArgs e)
        {

        }
    }
}
