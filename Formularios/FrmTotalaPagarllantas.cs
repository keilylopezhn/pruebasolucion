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
    public partial class FrmTotalaPagarllantas : Form
    {
        public FrmTotalaPagarllantas()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TxtProducto_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TxtProducto.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ingresar la cantidad del Producto");
                TxtProducto.Focus();
                return;

            }
            if (TxtPrecio.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ingresar el Precio del Producto");
                TxtPrecio.Focus();
                return;
            }

       

            double prod, prec, impto, tot, totisv;


            prod = Convert.ToDouble(TxtProducto.Text);
            prec = Convert.ToDouble(TxtPrecio.Text);
            

            tot = prod * prec;
            impto = tot * 0.15;
            totisv = tot + impto;
            
            TxtTotal.Text = tot.ToString();
            TxtImpto.Text = impto.ToString();
            TxtTotalISV.Text = totisv.ToString();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            TxtImpto.Clear();
            TxtPrecio.Clear();
            TxtProducto.Clear();
            TxtTotal.Clear();
            TxtTotalISV.Clear();
        }
    }
}
