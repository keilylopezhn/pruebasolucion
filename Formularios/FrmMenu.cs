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
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Formularios.FrmConversordeMillasaMetros Millametro = new Formularios.FrmConversordeMillasaMetros();
            Millametro.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Formularios.FrmLempirasaDolares Lempdol = new Formularios.FrmLempirasaDolares();
            Lempdol.ShowDialog();
        }

        private void BtnSuma_Click(object sender, EventArgs e)
        {
            Formularios.FrmSumario Sumario = new Formularios.FrmSumario();
            Sumario.ShowDialog();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnPromedio_Click(object sender, EventArgs e)
        {
            Formularios.FrmPromedio Promedio = new Formularios.FrmPromedio();
            Promedio.ShowDialog();
        }

        private void BtmMillasaKm_Click(object sender, EventArgs e)
        {
            Formularios.FrmConversorMillasaKm Mikilo = new Formularios.FrmConversorMillasaKm();
            Mikilo.ShowDialog();
        }

        private void BtnLpsaEuros_Click(object sender, EventArgs e)
        {
            Formularios.FrmConversordeLempirasaEuros Lempeuro = new Formularios.FrmConversordeLempirasaEuros();
            Lempeuro.ShowDialog();
        }

        private void BtnVentaLlantas_Click(object sender, EventArgs e)
        {
            Formularios.FrmTotalaPagarllantas Totllanta = new Formularios.FrmTotalaPagarllantas();
            Totllanta.ShowDialog();
        }

        private void BtnSalario_Click(object sender, EventArgs e)
        {
            Formularios.FrmSalarioenBaseaDiasTrabajados Salbase = new Formularios.FrmSalarioenBaseaDiasTrabajados();
            Salbase.ShowDialog();
        }

        private void BtmHorasExtra_Click(object sender, EventArgs e)
        {
            Formularios.FrmSalarioenBaseaHorasExtras Salex = new Formularios.FrmSalarioenBaseaHorasExtras();
            Salex.ShowDialog();
        }

        private void BtnGalonesaLitros_Click(object sender, EventArgs e)
        {
            Formularios.FrmConversorGalonesaLitros Galitro = new Formularios.FrmConversorGalonesaLitros();
            Galitro.ShowDialog();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
