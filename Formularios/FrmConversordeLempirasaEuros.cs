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
    public partial class FrmConversordeLempirasaEuros : Form
    {
        public FrmConversordeLempirasaEuros()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtmConvertir_Click(object sender, EventArgs e)
        {
      

        }

        private void FrmConversordeLempirasaEuros_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnConvertir_Click(object sender, EventArgs e)
        {
            if (TxtLps.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ingresar la Cantidad en Lempiras");
                TxtLps.Focus();
                return;
            }
            double lps, eu;

            lps = Convert.ToDouble(TxtLps.Text);

            eu = lps / 30;
            TxtEuros.Text = eu.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            TxtLps.Clear();
            TxtEuros.Clear();
        }
    }
    }
   
