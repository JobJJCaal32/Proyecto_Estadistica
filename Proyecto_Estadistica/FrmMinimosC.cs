using System;
using System.Windows.Forms;

namespace Proyecto_Estadistica
{
    public partial class FrmMinimosC : Form
    {
        //instancia a la clase Media para poder usar sus metodos y acceder a sus atributos
        Media datos = new Media();
        public FrmMinimosC()
        {
            InitializeComponent();
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
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            imprecion();
        }

        public void imprecion()
        {
            //se usa cout para poder obtener la cantidad de elementos que tenga el LbdatosX
            int contador = LbDatosX.Items.Count;
            //son las medias aritmeticas
            double sumaX = 0, sumaY = 0;
            //para poder obetener el valor del ListBox
            String Valor;
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

        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            Principal fp = new Principal();
            this.Dispose();
            fp.Show();
        }
    }
}
