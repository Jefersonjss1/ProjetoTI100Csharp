using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlugaMesa
{
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnCadastrarMesas_Click(object sender, EventArgs e)
        {
            frmCadastrarMesas Abrir = new frmCadastrarMesas();
            Abrir.Show();
            this.Hide();
        }

        private void btnAlugarMesa_Click(object sender, EventArgs e)
        {
            frmAlugarMesa Abrir = new frmAlugarMesa();
            Abrir.Show();
            this.Hide();
        }
    }
}
