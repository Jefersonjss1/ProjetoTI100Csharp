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
    public partial class frmCalcularGorjeta : Form
    {
        public frmCalcularGorjeta()
        {
            InitializeComponent();
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
    }
}
