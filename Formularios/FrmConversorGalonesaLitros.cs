using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea1_KeyliLisbethLopezMenjivar.Formularios
{
    public partial class FrmConversorGalonesaLitros : Form
    {
        public FrmConversorGalonesaLitros()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnConvertir_Click(object sender, EventArgs e)
        {
            if (TxtGal.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ingresar la Cantidad de Galones");
                TxtGal.Focus();
                return;
            }
            double gal, conv;

            gal = Convert.ToDouble(TxtGal.Text);

            conv = gal * 3.787;

            TxtResultado.Text = conv.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TxtGal.Clear();
            TxtResultado.Clear();
        }
    }
}
