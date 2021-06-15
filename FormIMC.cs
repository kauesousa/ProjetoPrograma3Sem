using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Saude_Day
{
    public partial class FormIMC : Form
    {
        public FormIMC()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double imc, altura, peso;
            peso = double.Parse(txtPeso.Text);
            altura = double.Parse(txtAltura.Text);
            imc = peso / (altura * altura);
            double casasDecimais = Math.Round(imc, 6);
            string converterIMC = Convert.ToString(casasDecimais).TrimStart('0');
            MessageBox.Show("Seu IMC é: " +converterIMC, " Resultado IMC", MessageBoxButtons.OK);
        }

        private void picVoltar_Click(object sender, EventArgs e)
        {
            if(MeusFormularios.FormPrincipal == null)
                MeusFormularios.FormPrincipal = new FormPrincipal();

            MeusFormularios.FormPrincipal.Show();
            MeusFormularios.FormPrincipal.Focus();
            this.Hide();
        }
    }
}
