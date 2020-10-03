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
    public partial class FrmSalarioenBaseaHorasExtras : Form
    {
        public FrmSalarioenBaseaHorasExtras()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            if (TxtDias.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ingresar los Dias Trabajados");
                TxtDias.Focus();
                return;
            }
            if (TxtPrecio.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ingresar Precio por Dia Trabajado");
                TxtPrecio.Focus();
                return;
            }
            if (TxtHe.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ingresar la Cantidad de Horas Extras");
                TxtHe.Focus();
                return;
            }
            if (TxtPhe.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ingresar la Precio por Hora Extra");
                TxtPhe.Focus();
                return;
            }
            double d, p, t, he, ph,the,sn;
            d = Convert.ToDouble(TxtDias.Text);
            p = Convert.ToDouble(TxtPrecio.Text);
            he = Convert.ToDouble(TxtHe.Text);
            ph = Convert.ToDouble(TxtPhe.Text);
            t = d * p;
            the = he*ph;
            sn = t + the;
         
            TxtSalarioBase.Text = t.ToString();
            TxtSalarioExtra.Text = the.ToString();
            TxtSalarioNeto.Text = sn.ToString();


        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
