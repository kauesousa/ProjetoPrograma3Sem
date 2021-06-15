using Saude_Day.Modelo;
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
    public partial class FormCadastrar : Form
    {
        public FormCadastrar()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnCad_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            String mensagem = controle.cadastrar(txtUsuario.Text, txtSenha.Text, txtConfSenha.Text);
            if (controle.tem)
            {
                MessageBox.Show(mensagem, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(controle.mensagem);
            }

            if (MeusFormularios.FormLogin == null)
                MeusFormularios.FormLogin = new FormLogin();

            MeusFormularios.FormLogin.Show();
            MeusFormularios.FormLogin.Focus();
            this.Hide();
        }

        private void picVoltar_Click(object sender, EventArgs e)
        {
            if (MeusFormularios.FormLogin == null)
                MeusFormularios.FormLogin = new FormLogin();

            MeusFormularios.FormLogin.Show();
            MeusFormularios.FormLogin.Focus();
            this.Hide();
        }
    }
}
