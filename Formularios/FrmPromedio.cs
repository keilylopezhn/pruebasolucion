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
    public partial class FrmPromedio : Form
    {
        public FrmPromedio()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void FrmSegundaCal_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            if (TxtPrimerCal.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ingresar Primer Calificacion");
                TxtPrimerCal.Focus();
                return;
            }

            if (TxtSegundaCal.Text.Trim().Length==0)
            {
                MessageBox.Show("Ingresar Segunda Calificacion");
                TxtSegundaCal.Focus();
                return;
            }

            if (TxtTercerCal.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ingresar Tercer Calificacion");
                TxtTercerCal.Focus();
                return;
            }

            if (TxtCuartaCal.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ingresar Cuarta Calificacion");
                TxtCuartaCal.Focus();
                return;
            }

            double cal1, cal2, cal3, cal4, prom, sum;

            cal1 = Convert.ToDouble(TxtPrimerCal.Text);
            cal2 = Convert.ToDouble(TxtSegundaCal.Text);
            cal3 = Convert.ToDouble(TxtTercerCal.Text);
            cal4 = Convert.ToDouble(TxtCuartaCal.Text);


            sum=cal1 + cal2 + cal3 + cal4;

            prom = sum / 4;

            TxtPromedio.Text = prom.ToString();

        }

        private void TxtPromedio_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TxtPrimerCal.Clear();
            TxtSegundaCal.Clear();
            TxtTercerCal.Clear();
            TxtCuartaCal.Clear();
            TxtPromedio.Clear();

        }
    }
}

