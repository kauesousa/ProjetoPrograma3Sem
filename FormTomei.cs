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
    public partial class FormTomei : Form
    {
        public FormTomei()
        {
            InitializeComponent();
        }

        private void FormTomei_Load(object sender, EventArgs e)
        {
            this.remediooBindingSource.DataSource = DataContextFactory.DataContext.Remedioo;

        }

        private void btnTomei_Click(object sender, EventArgs e)
        {
            horaTomouTextBox.Text = DateTime.Now.ToString();
            this.remediooBindingSource.EndEdit();
            DataContextFactory.DataContext.SubmitChanges();
            MessageBox.Show("Tomado!");
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
