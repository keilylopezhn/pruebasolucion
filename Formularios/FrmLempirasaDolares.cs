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
    public partial class FrmLempirasaDolares : Form
    {
        public FrmLempirasaDolares()
        {
            InitializeComponent();
        }

        private void FrmLempirasaDolares_Load(object sender, EventArgs e)
        {

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

        private void button1_Click(object sender, EventArgs e)
        {
            if (TxtLempiras.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ingresar la Cantidad de Lempiras");
                TxtLempiras.Focus();
                return;
            }
            double lps, res;

            lps = Convert.ToDouble(TxtLempiras.Text);

            res = lps / 25;

            TxtDolares.Text = res.ToString();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            TxtLempiras.Clear();
            TxtDolares.Clear();
        }
    }
}
