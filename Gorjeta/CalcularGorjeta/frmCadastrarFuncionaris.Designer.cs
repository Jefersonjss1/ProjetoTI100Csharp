
namespace CalcularGorjeta
{
    partial class frmCadastrarFuncionaris
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastrarFuncionaris));
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNomeFunc = new System.Windows.Forms.TextBox();
            this.btnCriar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.lstFuncionarios = new System.Windows.Forms.ListBox();
            this.lblIdFunc = new System.Windows.Forms.Label();
            this.txtIdFunc = new System.Windows.Forms.TextBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(111, 116);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(179, 20);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome do Funcionário";
            // 
            // txtNomeFunc
            // 
            this.txtNomeFunc.Location = new System.Drawing.Point(296, 118);
            this.txtNomeFunc.Name = "txtNomeFunc";
            this.txtNomeFunc.Size = new System.Drawing.Size(132, 20);
            this.txtNomeFunc.TabIndex = 2;
            // 
            // btnCriar
            // 
            this.btnCriar.Location = new System.Drawing.Point(45, 485);
            this.btnCriar.Name = "btnCriar";
            this.btnCriar.Size = new System.Drawing.Size(111, 60);
            this.btnCriar.TabIndex = 4;
            this.btnCriar.Text = "Criar";
            this.btnCriar.UseVisualStyleBackColor = true;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(162, 485);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(111, 60);
            this.btnCadastrar.TabIndex = 5;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(279, 485);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(111, 60);
            this.btnAlterar.TabIndex = 6;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(396, 485);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(111, 60);
            this.btnLimpar.TabIndex = 7;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(513, 485);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(111, 60);
            this.btnExcluir.TabIndex = 8;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // lstFuncionarios
            // 
            this.lstFuncionarios.FormattingEnabled = true;
            this.lstFuncionarios.Location = new System.Drawing.Point(453, 116);
            this.lstFuncionarios.Name = "lstFuncionarios";
            this.lstFuncionarios.Size = new System.Drawing.Size(228, 147);
            this.lstFuncionarios.TabIndex = 9;
            // 
            // lblIdFunc
            // 
            this.lblIdFunc.AutoSize = true;
            this.lblIdFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdFunc.Location = new System.Drawing.Point(111, 189);
            this.lblIdFunc.Name = "lblIdFunc";
            this.lblIdFunc.Size = new System.Drawing.Size(124, 20);
            this.lblIdFunc.TabIndex = 0;
            this.lblIdFunc.Text = "Id Funcionário";
            // 
            // txtIdFunc
            // 
            this.txtIdFunc.Enabled = false;
            this.txtIdFunc.Location = new System.Drawing.Point(241, 189);
            this.txtIdFunc.Name = "txtIdFunc";
            this.txtIdFunc.Size = new System.Drawing.Size(80, 20);
            this.txtIdFunc.TabIndex = 3;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(630, 485);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(111, 60);
            this.btnVoltar.TabIndex = 10;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // frmCadastrarFuncionaris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 557);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.lstFuncionarios);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.btnCriar);
            this.Controls.Add(this.txtIdFunc);
            this.Controls.Add(this.txtNomeFunc);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblIdFunc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmCadastrarFuncionaris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadastrarFuncionarios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNomeFunc;
        private System.Windows.Forms.Button btnCriar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.ListBox lstFuncionarios;
        private System.Windows.Forms.Label lblIdFunc;
        private System.Windows.Forms.TextBox txtIdFunc;
        private System.Windows.Forms.Button btnVoltar;
    }
}