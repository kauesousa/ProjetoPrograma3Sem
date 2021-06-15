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
    public partial class FormAddAlt : Form
    {
        public FormAddAlt()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MeusFormularios.FormAddAlt == null)
                MeusFormularios.FormAddAlt = new FormAddAlt();

            MeusFormularios.FormAddAlt.Show();
            MeusFormularios.FormAddAlt.Focus();

        }

        private void FormAddAlt_Load(object sender, EventArgs e)
        {
            this.remediooBindingSource.DataSource = DataContextFactory.DataContext.Remedioo;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.remediooBindingSource.EndEdit();
            DataContextFactory.DataContext.SubmitChanges();
            MessageBox.Show("Salvo!");
        }

        private void btnAlt_Click(object sender, EventArgs e)
        {
            this.remediooBindingSource.EndEdit();
            DataContextFactory.DataContext.SubmitChanges();
            MessageBox.Show("Alterado!");
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            this.remediooBindingSource.AddNew();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (MeusFormularios.FormPrincipal == null)
                MeusFormularios.FormPrincipal = new FormPrincipal();

            MeusFormularios.FormPrincipal.Show();
            MeusFormularios.FormPrincipal.Focus();
            this.Hide();
        }
    }
}
