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
    public partial class FrmSumario : Form
    {
        public FrmSumario()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmSumario_Load(object sender, EventArgs e)
        {

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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            if (TxtPrimerValor.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ingresar Primer Valor");
                TxtPrimerValor.Focus();
                return;
            }
            if (TxtSegundoValor.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ingresar Segundo Valor");
               TxtSegundoValor.Focus();
                return;

            }
            if (TxtTercerValor.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ingresar Tercer Valor");
                TxtTercerValor.Focus();
                return; }

            double valor1, valor2, valor3, res;
            valor1 = Convert.ToDouble(TxtPrimerValor.Text);
            valor2 = Convert.ToDouble(TxtSegundoValor.Text);
            valor3 = Convert.ToDouble(TxtTercerValor.Text);

            res = valor1 + valor2 + valor3;

            TxtResultado.Text = res.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TxtPrimerValor.Clear();
            TxtSegundoValor.Clear();
            TxtTercerValor.Clear();
            TxtResultado.Clear();
            
        }
    }
}
