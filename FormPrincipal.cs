using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SaudeDay.DAL;

namespace Saude_Day
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            this.remediooBindingSource.DataSource = DataContextFactory.DataContext.Remedioo;

        }

        private void btnAddAlt_Click(object sender, EventArgs e)
        {
            if (MeusFormularios.FormAddAlt == null)
                MeusFormularios.FormAddAlt = new FormAddAlt();

            MeusFormularios.FormAddAlt.Show();
            MeusFormularios.FormAddAlt.Focus();
            this.Hide();

        }

        private void btnLista_Click(object sender, EventArgs e)
        {
            if (MeusFormularios.FormLista == null)
                MeusFormularios.FormLista = new FormLista();

            MeusFormularios.FormLista.Show();
            MeusFormularios.FormLista.Focus();
            this.Hide();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MeusFormularios.FormExcluir == null)
                MeusFormularios.FormExcluir = new FormExcluir();

            MeusFormularios.FormExcluir.Show();
            MeusFormularios.FormExcluir.Focus();
            this.Hide();
        }

        private void btnTomei_Click(object sender, EventArgs e)
        {
            if (MeusFormularios.FormTomei == null)
                MeusFormularios.FormTomei = new FormTomei();

            MeusFormularios.FormTomei.Show();
            MeusFormularios.FormTomei.Focus();
            this.Hide();
        }

        private void btnIMC_Click(object sender, EventArgs e)
        {
            if (MeusFormularios.FormIMC == null)
                MeusFormularios.FormIMC = new FormIMC();

            MeusFormularios.FormIMC.Show();
            MeusFormularios.FormIMC.Focus();
            this.Hide();
        }

        private void btnDica_Click(object sender, EventArgs e)
        {
            if (MeusFormularios.FormDica == null)
                MeusFormularios.FormDica = new FormDica();

            MeusFormularios.FormDica.Show();
            MeusFormularios.FormDica.Focus();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (MeusFormularios.FormLogin == null)
                MeusFormularios.FormLogin = new FormLogin();

            MeusFormularios.FormLogin.Show();
            MeusFormularios.FormLogin.Focus();
            this.Hide();
        }
    }
}
