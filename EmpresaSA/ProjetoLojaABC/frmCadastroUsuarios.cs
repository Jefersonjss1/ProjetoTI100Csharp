﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using MySql.Data.MySqlClient;

namespace ProjetoLojaABC
{
    public partial class frmCadastroUsuarios : Form
    {
        //Criando variáveis para controle do menu
        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);
        public frmCadastroUsuarios()
        {
            InitializeComponent();
        }

        private void frmCadastroUsuarios_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
        }
        // Cadastro de usuários
        public int cadastraUsuarios(int cod_func)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "insert into tbUsuarios(usuario,senha,cod_func)values(@usuario,@senha,@cod_func);";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@usuario",MySqlDbType.VarChar,30).Value = txtNome.Text;
            comm.Parameters.Add("@senha",MySqlDbType.VarChar,10).Value = txtSenha.Text;
            comm.Parameters.Add("@cod_func",MySqlDbType.Int32).Value = cod_func;

            comm.Connection = Conexao.obterConexao();
            int res = comm.ExecuteNonQuery();

            Conexao.fecharConexao();

            return res;
        }
        public void carregaFuncionarios()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select nome from tbFuncionarios order by nome asc;";
            comm.CommandType = CommandType.Text;

            comm.Connection = Conexao.obterConexao();
            MySqlDataReader DR;
            DR = comm.ExecuteReader();

            lstFuncsSemUsu.Items.Clear();

            while (DR.Read())
            {
                lstFuncsSemUsu.Items.Add(DR.GetString(0));
            }
            Conexao.fecharConexao();
        }

        //Carregar usuários

        public void carregaUsuarios(string nome)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select usu.usuario, usu.senha, func.cod_func from tbFuncionarios as func inner join tbUsuarios as usu on func.cod_func = usu.cod_func where func.nome = @nome;";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@nome", MySqlDbType.VarChar, 100).Value = nome;
            comm.Connection = Conexao.obterConexao();

            MySqlDataReader DR;
            DR = comm.ExecuteReader();
            DR.Read();
            try
            {
                txtNome.Text = DR.GetString(0);
                txtSenha.Text = DR.GetString(1);

                txtCodFunc.Text = DR.GetInt32(2).ToString();

                Conexao.fecharConexao();
            }
            catch (MySqlException)
            {

                MessageBox.Show("Funcionário não possui usuário.",
                    "Mensagem do sistema.",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1);
                // Carregar o código do funcionário

                txtNome.Clear();
                txtSenha.Clear();
                txtCodigo.Clear();
                txtNome.Focus();
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtSenha.Text.Equals(txtRepetirSenha.Text))
            {
                if (cadastraUsuarios(Convert.ToInt32(txtCodigo.Text)) == 1)
                {
                    MessageBox.Show("Cadastrado com sucesso!!!",
                        "Mensagem do sistema.",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information,
                        MessageBoxDefaultButton.Button1);
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar!!!",
                        "Mensagem do sistema.",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error,
                        MessageBoxDefaultButton.Button1);
                }
            }
            else
            {
                MessageBox.Show("Senha não confere!!!",
                        "Mensagem do sistema.",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error,
                        MessageBoxDefaultButton.Button1);
                txtSenha.Clear();
                txtRepetirSenha.Clear();
                txtSenha.Focus();
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal abrir = new frmMenuPrincipal();
            abrir.Show();
            this.Hide();
        }

        private void lstFuncsSemUsu_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nome = lstFuncsSemUsu.SelectedItem.ToString();

            carregaUsuarios(nome);
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            carregaFuncionarios();
        }
    }
}