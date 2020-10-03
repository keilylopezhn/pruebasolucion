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
    public partial class FrmConversordeMillasaMetros : Form
    {
        public FrmConversordeMillasaMetros()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void BtmConvertir_Click(object sender, EventArgs e)
        {
            if (TxtMillas.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ingresar el Valor de las Millas");
                TxtMillas.Focus();
                return;
            }  double  mi, conv;

            mi = Convert.ToDouble(TxtMillas.Text);
           
            conv = mi * 1609.34;

            TxtResultado.Text = conv.ToString();






        }

        private void TxtResultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmConversordeMillasaMetros_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TxtMillas.Clear();
            TxtResultado.Clear();
        }
    }
}
