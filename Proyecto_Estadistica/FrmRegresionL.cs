using System;
using System.Windows.Forms;

namespace Proyecto_Estadistica
{
    public partial class FrmRegresionL : Form
    {
        //instancia a la clase Media para poder usar sus metodos y acceder a sus atributos
        Media datos = new Media();
        //instancia a la clase ClMetodosRegresionL
        ClMetodosRegresionL metodos = new ClMetodosRegresionL();
        public FrmRegresionL()
        {
            InitializeComponent();
        }

        private void BtnIDato_Click(object sender, EventArgs e)
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

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            #region Variables
            //se usa cout para poder obtener la cantidad de elementos que tenga el LbdatosX
            int contador = LbDatosX.Items.Count;
            //son las medias aritmeticas
            double sumaX = 0, sumaY = 0, ValorX = 0, ValorY = 0, Columna1, Columna2, Columna3;
            //para poder obetener el valor del ListBox
            String Valor;
            #endregion

            #region Impresion de Datos
            //para poder sumar los datos
            for (int i = 0; i < contador; i++)
            {

                Valor = LbDatosX.Items[i].ToString();
                ValorX = Convert.ToDouble(Valor);
                sumaX += ValorX;

                Valor = LbDatosY.Items[i].ToString();
                ValorY = Convert.ToDouble(Valor);
                sumaY += ValorY;

                //impresion en la primera columna de XY
                Columna1 = ValorX * ValorY;
                LbColumna1.Items.Add(LbDatosX.Items[i] + " * " + LbDatosX.Items[i] + " = " + Columna1);
                metodos.Columna1(Columna1);

                //impresion en la primera columna de X^2
                Columna2 = Math.Pow(ValorX, 2);
                LbColumna2.Items.Add(LbDatosX.Items[i] + " ^2 = " + Columna2);
                metodos.Columna2(Columna2);

                //impresion en la primera columna de Y^2
                Columna3 = Math.Pow(ValorY, 2);
                LbColumna3.Items.Add(LbDatosY.Items[i] + " ^2 = " + Columna3);
                metodos.Columna3(Columna3);

            }
            //se manda los datos al metodo media y que calcule la media de cada uno 
            //a su vez se llama a las variables de la clase Metodos mediax y mediay para poder asignarles el valor
            datos.MediaX = datos.DatoMedia(sumaX, contador);
            datos.MediaY = datos.DatoMedia(sumaY, contador);
            //se imprime las medias
            TxtMediaX.Text = Convert.ToString(datos.MediaX);
            TxtMediaY.Text = Convert.ToString(datos.MediaY);

            //se imprimi la suma de la multiplicacion de XY
            TxtSumaXY.Text = Convert.ToString(metodos.sumaC1);
            //se imprimi la suma de X^2
            TxtSuma1.Text = Convert.ToString(metodos.sumaC2);
            //se imprimi la suma de Y^2
            TxtSuma2.Text = Convert.ToString(metodos.sumaC3);
            #endregion

            #region calculo formulas
            // se hace llamado a los metodos que van a necesitar datos
            metodos.DatoA(sumaX, sumaY, contador);
            metodos.DatoB(sumaX, sumaY, contador);
            metodos.DatoCovX(contador, datos.MediaX);
            metodos.DatoCovY(contador, datos.MediaY);
            metodos.DatoCovXY(contador, datos.MediaX, datos.MediaY);
            metodos.DatoR();
            
            //impresion de datos en los TextBox
            TxtA.Text = Convert.ToString(Math.Round(metodos.A,3));
            TxtB.Text = Convert.ToString(Math.Round(metodos.B, 3));
            TxtCovX.Text = Convert.ToString(Math.Round(metodos.CovX,3));
            TxtCovY.Text = Convert.ToString(Math.Round(metodos.CovY, 3));
            TxtCovXY.Text = Convert.ToString(Math.Round(metodos.CovXY, 3));
            TxtR.Text = Convert.ToString(Math.Round(metodos.R, 3));

            #endregion

        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            Principal fp = new Principal();
            this.Dispose();
            fp.Show();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {

        }

        private void LbColumna3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}