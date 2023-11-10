using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CalcularGorjeta
{
    public partial class frmCadastrarFuncionarios : Form
    {
        public frmCadastrarFuncionarios()
        {
            InitializeComponent();
            desabilitarCampos();
        }

        public int cadastrarUsuarios()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "insert into tbFuncionarios(nomeFunc)values(@nomeFunc);";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@nomeFunc",MySqlDbType.VarChar,50).Value = txtNomeFunc.Text;
            comm.Connection = Conexao.obterConexao();

            int res = comm.ExecuteNonQuery();

            Conexao.fecharConexao();

            return res;
        }
        public void carregaCodigo()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select idFunc+1 from tbFuncionarios order by idFunc desc;";
            comm.CommandType = CommandType.Text;

            comm.Connection = Conexao.obterConexao();
            MySqlDataReader DR;
            DR = comm.ExecuteReader();
            DR.Read();

            txtIdFunc.Text = Convert.ToString(DR.GetInt32(0));

            Conexao.fecharConexao();
        }
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal abrir = new frmMenuPrincipal();
            abrir.Show();
            this.Hide();
        }
        public void desabilitarCampos()
        {
            txtNomeFunc.Enabled = false;

            btnCadastrar.Enabled = false;
            btnCriar.Enabled = true;
        }
        public void habilitarCamposNovo()
        {
            txtNomeFunc.Enabled = true;

            btnCadastrar.Enabled = true;
        }
        public void limparCampos()
        {
            txtIdFunc.Clear();
            txtNomeFunc.Clear();
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            limparCampos();
            habilitarCamposNovo();
            carregaCodigo();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (!(txtNomeFunc.Text.Equals("")))
            {
                if (cadastrarUsuarios() == 1)
                {
                    MessageBox.Show("Cadastrado com Sucesso!!!",
                    "Mensagem do Sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1);
                    desabilitarCampos();
                    limparCampos();
                }
                else
                {
                    MessageBox.Show("Erro ao Cadastrar!!!",
                    "Mensagem do Sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
                }
                
            }
            else
            {
                MessageBox.Show("Preencha todos os Campos!!!",
                    "Mensagem do Sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1);
            }
        }
        public int alterarUsuario()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "update tbFuncionarios set nomeFunc = @nomeFunc;";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Add("@nomeFunc", MySqlDbType.VarChar, 50).Value = txtNomeFunc.Text;
            comm.Connection = Conexao.obterConexao();

            int res = comm.ExecuteNonQuery();

            Conexao.fecharConexao();

            return res;
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            desabilitarCampos();
            limparCampos();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            frmPesquisar abrir = new frmPesquisar();
            abrir.Show();
            this.Hide();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (true)
            {

            }
            desabilitarCampos();
            limparCampos();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            desabilitarCampos();
            limparCampos();
        }
    }
}
