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
    public partial class FrmConversorMillasaKm : Form
    {
        public FrmConversorMillasaKm()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TxtMillas.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ingresar el Valor de las Millas");
                TxtMillas.Focus();
                return;
            }
            double mil, resu;

            mil = Convert.ToDouble(TxtMillas.Text);

            resu = mil * 1.609;

            TxtResultado.Text = resu.ToString();



        }

        private void button2_Click(object sender, EventArgs e)
        {
            TxtMillas.Clear();
            TxtResultado.Clear();
        }
    }
}
