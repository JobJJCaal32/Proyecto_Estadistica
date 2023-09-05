using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Estadistica
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void BrnRegresionLineal_Click(object sender, EventArgs e)
        {
            FrmRegresionL fp = new FrmRegresionL();
            this.Hide();
            fp.Show();
        }

        private void BtnMinimosCuadrados_Click(object sender, EventArgs e)
        {
            FrmMinimosC fp = new FrmMinimosC();
            this.Hide();
            fp.Show();
        }
    }
}
