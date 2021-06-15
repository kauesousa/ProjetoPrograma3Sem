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
    public partial class FormLista : Form
    {
        public FormLista()
        {
            InitializeComponent();
        }

        private void FormLista_Load(object sender, EventArgs e)
        {
            this.remediooBindingSource.DataSource = DataContextFactory.DataContext.Remedioo;
        }

        private void picVoltar_Click(object sender, EventArgs e)
        {
            if (MeusFormularios.FormPrincipal == null)
                MeusFormularios.FormPrincipal = new FormPrincipal();

            MeusFormularios.FormPrincipal.Show();
            MeusFormularios.FormPrincipal.Focus();
            this.Hide();
        }
    }
}
