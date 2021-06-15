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
    public partial class FormDica : Form
    {
        public FormDica()
        {
            InitializeComponent();
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
