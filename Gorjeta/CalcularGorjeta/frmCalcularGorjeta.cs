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
    public partial class frmCalcularGorjeta : Form
    {
        public frmCalcularGorjeta()
        {
            InitializeComponent();
            pesquisarFuncionarios();
            pesquisarFuncionariosID();
        }
        public void CalcularGorjeta(int porc)
        {
            double valorConta = Convert.ToDouble(txtValorConta.Text);
            double valorGorjeta = valorConta * (Convert.ToDouble(porc) / 100);
            double valorTotal = valorConta + valorGorjeta;

            txtValorGorjeta.Text = valorGorjeta.ToString();
            txtValorTotal.Text = valorTotal.ToString();
        }

        private void btnCalcularGorjeta_Click(object sender, EventArgs e)
        {
            try
            {
                switch (cbbQualidade.Text)
                {
                    case "Excelente - 10%": CalcularGorjeta(10);
                        break;
                    case "Ótimo - 8%": CalcularGorjeta(8);
                        break;
                    case "Bom - 5%": CalcularGorjeta(5);
                        break;
                    case "Ruim - 2%": CalcularGorjeta(2);
                        break;

                    default:
                        MessageBox.Show("Avalie o serviço antes de calcular a gorjeta!",
                            "Mensagem do Sistema",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error,
                            MessageBoxDefaultButton.Button1);
                        break;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Preencha todos os campos antes de calcular a gorjeta!",
                    "Mensagem do Sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
            }
        }


        public void LimparCampos()
        {
            cbbQualidade.Items.Clear();

            txtValorConta.Clear();
            txtValorGorjeta.Clear();
            txtValorTotal.Clear();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();   
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        public void pesquisarFuncionarios()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select nomeFunc from tbFuncionarios;";
            comm.CommandType = CommandType.Text;

            comm.Connection = Conexao.obterConexao();

            MySqlDataReader DR;
            DR = comm.ExecuteReader();
            cbbNomeFuncionario.Items.Clear();
            while (DR.Read())
            {
                cbbNomeFuncionario.Items.Add(DR.GetValue(0));
            }
                
            Conexao.fecharConexao();

        }
        public void pesquisarFuncionariosID()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select idFunc from tbFuncionarios;";
            comm.CommandType = CommandType.Text;

            comm.Connection = Conexao.obterConexao();

            MySqlDataReader DR;
            DR = comm.ExecuteReader();
            cbbIdFunc.Items.Clear();
            while (DR.Read())
            {
                cbbIdFunc.Items.Add(DR.GetValue(0));
            }
            Conexao.fecharConexao();
        }

        public void pesquisarCodigo(string nome)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select idFunc from tbFuncionarios where nomeFunc like @nomeFunc;";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Add("@nomeFunc", MySqlDbType.VarChar, 100).Value = nome;
            comm.Connection = Conexao.obterConexao();

            MySqlDataReader DR;
            DR = comm.ExecuteReader();
            DR.Read();
            cbbIdFunc.Text = DR.GetValue(0).ToString();

            Conexao.fecharConexao();
        }
        public int salvarNoBanco()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "insert into tbCalculadoraDeGorjeta(ValorConta,Qualidade,ValorGorjeta,valorTotal,idFunc)values(@ValorConta,@Qualidade,@ValorGorjeta,@valorTotal,@idFunc);";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Add("@ValorConta", MySqlDbType.VarChar,20).Value = txtValorConta.Text;
            comm.Parameters.Add("@Qualidade", MySqlDbType.VarChar, 20).Value = cbbQualidade.Text;
            comm.Parameters.Add("@ValorGorjeta", MySqlDbType.VarChar, 20).Value = txtValorGorjeta.Text;
            comm.Parameters.Add("@ValorTotal", MySqlDbType.VarChar, 20).Value = txtValorTotal.Text;
            comm.Parameters.Add("idFunc", MySqlDbType.Int32).Value = cbbIdFunc.Text;
            comm.Connection = Conexao.obterConexao();

            int res = comm.ExecuteNonQuery();

            Conexao.fecharConexao();

            return res;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal abrir = new frmMenuPrincipal();
            abrir.Show();
            this.Hide();
        }

        private void cbbNomeFuncionario_SelectedIndexChanged(object sender, EventArgs e)
        {
            pesquisarCodigo(cbbNomeFuncionario.SelectedItem.ToString());
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!(cbbIdFunc.Text.Equals("") || cbbNomeFuncionario.Text.Equals("") || txtValorConta.Text.Equals("") || txtValorGorjeta.Text.Equals("") || txtValorTotal.Text.Equals("")))
            {
                if (salvarNoBanco() == 1)
                {
                    MessageBox.Show("Salvo com Sucesso!!!",
                    "Mensagem do Sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1);
                }
                else
                {
                    MessageBox.Show("Erro ao Salvar!!!",
                    "Mensagem do Sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
                }
            }
            else
            {
                MessageBox.Show("Preencha todos os campos!!!",
                    "Mensagem do Sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
            }
        }
    }
}
