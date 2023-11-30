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
    public partial class frmPesquisar : Form
    {
        public frmPesquisar()
        {
            InitializeComponent();
            pesquisarCodigo();
        }
        public void pesquisarCodigo()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select idFunc from tbFuncionarios;";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Connection = Conexao.obterConexao();

            MySqlDataReader DR;
            DR = comm.ExecuteReader();

            lstPesquisar.Items.Clear();
            while (DR.Read())
            {
                cbbCodigo.Items.Add(DR.GetString(0));
            }
            

            Conexao.fecharConexao();

        }
        public void carregarFuncionarios()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select Gor.ValorConta,Gor.Qualidade,Gor.ValorGorjeta,Gor.valorTotal,Func.nomeFunc from tbCalculadoraDeGorjeta as Gor inner join tbFuncionarios as Func on Gor.idFunc = Func.idFunc where Func.idFunc = @idFunc;";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@idFunc", MySqlDbType.Int32).Value = cbbCodigo.SelectedItem;
            comm.Connection = Conexao.obterConexao();

            MySqlDataReader DR;
            DR = comm.ExecuteReader();

            lstPesquisar.Items.Clear();
            while (DR.Read())
            {
                lstPesquisar.Items.Add(DR.GetString(0) + " " + DR.GetString(1) + " " + DR.GetString(2) + " " + DR.GetString(3) + " " + DR.GetString(4));
            }
            Conexao.fecharConexao();

        }
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmCadastrarFuncionarios abrir = new frmCadastrarFuncionarios();
            abrir.Show();
            this.Hide();
        }

        private void cbbCodigo_SelectedIndexChanged(object sender, EventArgs e)
        {
            carregarFuncionarios();
        }

    }
}
