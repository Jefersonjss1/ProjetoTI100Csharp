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
    public partial class frmCadastrarMesas : Form
    {
        public frmCadastrarMesas()
        {
            InitializeComponent();
            desabilitarCampos();
        }
        // Habilitar Campos Novo
        public void habilitarCamposNovo()
        {
            btnCadastrar.Enabled = true;
            btnLimpar.Enabled = true;

            txtIdMesa.Enabled = true;
            txtQtd.Enabled = true;
            rdbDisponivel.Enabled = true;
            rdbIndisponivel.Enabled = true;

            txtIdMesa.Focus();
        }
        // Desabilitar Campos
        public void desabilitarCampos()
        {
            btnCadastrar.Enabled = false;
            btnAlterar.Enabled = false;
            btnLimpar.Enabled = false;
            btnExcluir.Enabled = false;

            txtIdMesa.Enabled = false;
            txtQtd.Enabled = false;
            rdbDisponivel.Enabled = false;
            rdbIndisponivel.Enabled = false;

            txtIdMesa.Focus();
        }

        public void limparCampos()
        {
            txtIdMesa.Clear();
            txtQtd.Clear();
            rdbDisponivel.Checked = false;
            rdbIndisponivel.Checked = false;
        }
       

        private void btnNovo_Click(object sender, EventArgs e)
        {
            habilitarCamposNovo();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal Abrir = new frmMenuPrincipal();
            Abrir.Show();
            this.Hide();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            desabilitarCampos();
            limparCampos();
        }
    }
}
