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
    public partial class FrmSalarioenBaseaDiasTrabajados : Form
    {
        public FrmSalarioenBaseaDiasTrabajados()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();        }

        private void FrmSalarioenBaseaDiasTrabajados_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            if (TxtDias.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ingresar los Dias Trabajados");
                TxtDias.Focus();
                return;
            }
            if(TxtPrecio.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ingresar los Dias Trabajados");
               TxtPrecio.Focus();
                return;
            }

            double d, p, tot;

            d = Convert.ToDouble(TxtDias.Text);

            p = Convert.ToDouble(TxtPrecio.Text);

            tot = d * p;

            TxtSalario.Text = tot.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TxtDias.Clear();
            TxtPrecio.Clear();
            TxtSalario.Clear();
        }
    }
}
