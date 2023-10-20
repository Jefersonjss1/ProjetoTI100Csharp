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
    public partial class frmAlugarMesa : Form
    {
        public frmAlugarMesa()
        {
            InitializeComponent();
            desabilitarCampos();
        }
        //Desabilitar Campos
        public void desabilitarCampos()
        {
            txtCodigoMesa.Enabled = false;
            txtNomeCliente.Enabled = false;
            txtStatusMesa.Enabled = false;

            btnAlugar.Enabled = false;
            btnLiberar.Enabled = false;
            btnLimpar.Enabled = false;

            txtNomeCliente.Focus();
        }

        public void habilitarCamposDisponivel()
        {
            txtCodigoMesa.Enabled = true;
            txtNomeCliente.Enabled = true;
            txtStatusMesa.Enabled = false;

            btnAlugar.Enabled = true;
            btnLimpar.Enabled = true;

            txtNomeCliente.Focus();
        }
        public void habilitarCamposIndisponivel()
        {
            txtCodigoMesa.Enabled = true;
            txtNomeCliente.Enabled = true;
            txtStatusMesa.Enabled = false;

            btnLiberar.Enabled = true;
            btnLimpar.Enabled = true;

            txtNomeCliente.Focus();
        }
        public void limparCampos()
        {
            txtCodigoMesa.Clear();
            txtNomeCliente.Clear();
            txtStatusMesa.Clear();

            rdbDisponivel.Checked = false;
            rdbIndisponivel.Checked = false;

            txtNomeCliente.Focus();
        }


        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal Abrir = new frmMenuPrincipal();
            Abrir.Show();
            this.Hide();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (rdbDisponivel.Checked == true)
            {
                limparCampos();
                desabilitarCampos();
                habilitarCamposDisponivel();
            }
            else if (rdbIndisponivel.Checked == true)
            {
                limparCampos();
                desabilitarCampos();
                habilitarCamposIndisponivel();

                txtStatusMesa.Text = "INDISPONÍVEL";
            }
            else
            {
                MessageBox.Show("Escolha uma opção",
                    "Mensagem do sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
            }
        }

        private void btnAlugar_Click(object sender, EventArgs e)
        {
            limparCampos();
            desabilitarCampos();
        }

        private void btnLiberar_Click(object sender, EventArgs e)
        {
            limparCampos();
            desabilitarCampos();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
            desabilitarCampos();
        }
    }
}
