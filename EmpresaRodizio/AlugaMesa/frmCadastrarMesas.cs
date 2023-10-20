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
        //Desabilitar Campos Novo
        public void desativarCamposNovo() {
            btnNovo.Enabled = false;
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
            btnNovo.Enabled = true;

            txtIdMesa.Focus();
        }
        // Desabilitar campo de pesquisar
        public void desabilitarCamposPesquisar()
        {
            rdbPesquisarDisponivel.Enabled = false;
            rdbPesquisarIndisponivel.Enabled = false;
            ltbPesquisarMesas.Enabled = false;
            btnPesquisar.Enabled = false;
        }
        // Habilitar campo de pesquisar
        public void habilitarCamposPesquisar()
        {
            rdbPesquisarDisponivel.Enabled = true;
            rdbPesquisarIndisponivel.Enabled = true;
            ltbPesquisarMesas.Enabled = true;
            btnPesquisar.Enabled = true;

            txtIdMesa.Focus();
        }
        public void habilitarCampoLimpar()
        {
            btnLimpar.Enabled = true;
        }
        //Habilitar Botão excluir e alterar
        public void habilitarCamposExcAlt()
        {
            btnExcluir.Enabled = true;
            btnAlterar.Enabled = true;

            txtIdMesa.Focus();
        }
        //Desabilitar Botão excluir e alterar
        public void desabilitarCamposExcAlt()
        {
            btnExcluir.Enabled = false;
            btnAlterar.Enabled = false;

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
            desabilitarCamposPesquisar();
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
            desabilitarCampos();
            habilitarCamposPesquisar();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            desabilitarCampos();
            limparCampos();
            habilitarCamposPesquisar();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            limparCampos();
            desabilitarCampos();
            habilitarCamposPesquisar();
            
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            habilitarCamposExcAlt();
            desativarCamposNovo();
            habilitarCampoLimpar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            limparCampos();
            desabilitarCampos();
            habilitarCamposPesquisar();
        }
    }
}
