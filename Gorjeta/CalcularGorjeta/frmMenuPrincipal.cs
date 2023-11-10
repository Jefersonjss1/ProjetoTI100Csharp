using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcularGorjeta
{
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            frmCadastrarFuncionarios abrir = new frmCadastrarFuncionarios();
            abrir.Show();
            this.Hide();
        }

        private void btnCalcularGorjeta_Click(object sender, EventArgs e)
        {
            frmCalcularGorjeta abrir = new frmCalcularGorjeta();
            abrir.Show();
            this.Hide();
        }
    }
}
