
namespace AlugaMesa
{
    partial class frmCadastrarMesas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastrarMesas));
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.lblIdMesa = new System.Windows.Forms.Label();
            this.lblQtd = new System.Windows.Forms.Label();
            this.txtIdMesa = new System.Windows.Forms.TextBox();
            this.txtQtd = new System.Windows.Forms.TextBox();
            this.gpbStatus = new System.Windows.Forms.GroupBox();
            this.rdbIndisponivel = new System.Windows.Forms.RadioButton();
            this.rdbDisponivel = new System.Windows.Forms.RadioButton();
            this.gpbPesquisarMesas = new System.Windows.Forms.GroupBox();
            this.rdbPesquisarIndisponivel = new System.Windows.Forms.RadioButton();
            this.rdbPesquisarDisponivel = new System.Windows.Forms.RadioButton();
            this.ltbPesquisarMesas = new System.Windows.Forms.ListBox();
            this.gpbStatus.SuspendLayout();
            this.gpbPesquisarMesas.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo.Image")));
            this.btnNovo.Location = new System.Drawing.Point(61, 405);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(105, 50);
            this.btnNovo.TabIndex = 5;
            this.btnNovo.Text = "&Novo";
            this.btnNovo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCadastrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrar.Image")));
            this.btnCadastrar.Location = new System.Drawing.Point(172, 405);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(105, 50);
            this.btnCadastrar.TabIndex = 6;
            this.btnCadastrar.Text = "&Cadastrar";
            this.btnCadastrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCadastrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.Location = new System.Drawing.Point(283, 405);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(105, 50);
            this.btnAlterar.TabIndex = 7;
            this.btnAlterar.Text = "&Alterar";
            this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAlterar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.Location = new System.Drawing.Point(394, 405);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(105, 50);
            this.btnExcluir.TabIndex = 8;
            this.btnExcluir.Text = "&Excluir";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.Image")));
            this.btnPesquisar.Location = new System.Drawing.Point(132, 56);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(113, 50);
            this.btnPesquisar.TabIndex = 9;
            this.btnPesquisar.Text = "&Pesquisar";
            this.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpar.Image")));
            this.btnLimpar.Location = new System.Drawing.Point(505, 405);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(105, 50);
            this.btnLimpar.TabIndex = 10;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnVoltar.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltar.Image")));
            this.btnVoltar.Location = new System.Drawing.Point(616, 405);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(105, 50);
            this.btnVoltar.TabIndex = 11;
            this.btnVoltar.Text = "&Voltar";
            this.btnVoltar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVoltar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // lblIdMesa
            // 
            this.lblIdMesa.AutoSize = true;
            this.lblIdMesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdMesa.Location = new System.Drawing.Point(60, 43);
            this.lblIdMesa.Name = "lblIdMesa";
            this.lblIdMesa.Size = new System.Drawing.Size(165, 20);
            this.lblIdMesa.TabIndex = 7;
            this.lblIdMesa.Text = "Identificação da Mesa";
            // 
            // lblQtd
            // 
            this.lblQtd.AutoSize = true;
            this.lblQtd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtd.Location = new System.Drawing.Point(60, 115);
            this.lblQtd.Name = "lblQtd";
            this.lblQtd.Size = new System.Drawing.Size(181, 20);
            this.lblQtd.TabIndex = 8;
            this.lblQtd.Text = "Quantidade de Cadeiras";
            // 
            // txtIdMesa
            // 
            this.txtIdMesa.Location = new System.Drawing.Point(233, 43);
            this.txtIdMesa.Name = "txtIdMesa";
            this.txtIdMesa.Size = new System.Drawing.Size(100, 20);
            this.txtIdMesa.TabIndex = 0;
            // 
            // txtQtd
            // 
            this.txtQtd.Location = new System.Drawing.Point(247, 117);
            this.txtQtd.Name = "txtQtd";
            this.txtQtd.Size = new System.Drawing.Size(86, 20);
            this.txtQtd.TabIndex = 1;
            // 
            // gpbStatus
            // 
            this.gpbStatus.Controls.Add(this.rdbIndisponivel);
            this.gpbStatus.Controls.Add(this.rdbDisponivel);
            this.gpbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbStatus.Location = new System.Drawing.Point(64, 180);
            this.gpbStatus.Name = "gpbStatus";
            this.gpbStatus.Size = new System.Drawing.Size(200, 100);
            this.gpbStatus.TabIndex = 2;
            this.gpbStatus.TabStop = false;
            this.gpbStatus.Text = "Status da Mesa";
            // 
            // rdbIndisponivel
            // 
            this.rdbIndisponivel.AutoSize = true;
            this.rdbIndisponivel.Location = new System.Drawing.Point(24, 60);
            this.rdbIndisponivel.Name = "rdbIndisponivel";
            this.rdbIndisponivel.Size = new System.Drawing.Size(110, 24);
            this.rdbIndisponivel.TabIndex = 4;
            this.rdbIndisponivel.TabStop = true;
            this.rdbIndisponivel.Text = "Indisponível";
            this.rdbIndisponivel.UseVisualStyleBackColor = true;
            // 
            // rdbDisponivel
            // 
            this.rdbDisponivel.AutoSize = true;
            this.rdbDisponivel.Location = new System.Drawing.Point(24, 37);
            this.rdbDisponivel.Name = "rdbDisponivel";
            this.rdbDisponivel.Size = new System.Drawing.Size(99, 24);
            this.rdbDisponivel.TabIndex = 3;
            this.rdbDisponivel.TabStop = true;
            this.rdbDisponivel.Text = "Disponível";
            this.rdbDisponivel.UseVisualStyleBackColor = true;
            // 
            // gpbPesquisarMesas
            // 
            this.gpbPesquisarMesas.Controls.Add(this.rdbPesquisarIndisponivel);
            this.gpbPesquisarMesas.Controls.Add(this.rdbPesquisarDisponivel);
            this.gpbPesquisarMesas.Controls.Add(this.ltbPesquisarMesas);
            this.gpbPesquisarMesas.Controls.Add(this.btnPesquisar);
            this.gpbPesquisarMesas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbPesquisarMesas.Location = new System.Drawing.Point(388, 24);
            this.gpbPesquisarMesas.Name = "gpbPesquisarMesas";
            this.gpbPesquisarMesas.Size = new System.Drawing.Size(380, 347);
            this.gpbPesquisarMesas.TabIndex = 45;
            this.gpbPesquisarMesas.TabStop = false;
            this.gpbPesquisarMesas.Text = "Pesquisar Mesas";
            // 
            // rdbPesquisarIndisponivel
            // 
            this.rdbPesquisarIndisponivel.AutoSize = true;
            this.rdbPesquisarIndisponivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbPesquisarIndisponivel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rdbPesquisarIndisponivel.Location = new System.Drawing.Point(255, 30);
            this.rdbPesquisarIndisponivel.Name = "rdbPesquisarIndisponivel";
            this.rdbPesquisarIndisponivel.Size = new System.Drawing.Size(110, 24);
            this.rdbPesquisarIndisponivel.TabIndex = 41;
            this.rdbPesquisarIndisponivel.TabStop = true;
            this.rdbPesquisarIndisponivel.Text = "Indisponível";
            this.rdbPesquisarIndisponivel.UseVisualStyleBackColor = true;
            // 
            // rdbPesquisarDisponivel
            // 
            this.rdbPesquisarDisponivel.AutoSize = true;
            this.rdbPesquisarDisponivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbPesquisarDisponivel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rdbPesquisarDisponivel.Location = new System.Drawing.Point(22, 30);
            this.rdbPesquisarDisponivel.Name = "rdbPesquisarDisponivel";
            this.rdbPesquisarDisponivel.Size = new System.Drawing.Size(99, 24);
            this.rdbPesquisarDisponivel.TabIndex = 42;
            this.rdbPesquisarDisponivel.TabStop = true;
            this.rdbPesquisarDisponivel.Text = "Disponível";
            this.rdbPesquisarDisponivel.UseVisualStyleBackColor = true;
            // 
            // ltbPesquisarMesas
            // 
            this.ltbPesquisarMesas.FormattingEnabled = true;
            this.ltbPesquisarMesas.ItemHeight = 20;
            this.ltbPesquisarMesas.Location = new System.Drawing.Point(6, 112);
            this.ltbPesquisarMesas.Name = "ltbPesquisarMesas";
            this.ltbPesquisarMesas.Size = new System.Drawing.Size(368, 224);
            this.ltbPesquisarMesas.TabIndex = 43;
            // 
            // frmCadastrarMesas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 457);
            this.Controls.Add(this.gpbPesquisarMesas);
            this.Controls.Add(this.gpbStatus);
            this.Controls.Add(this.txtQtd);
            this.Controls.Add(this.txtIdMesa);
            this.Controls.Add(this.lblQtd);
            this.Controls.Add(this.lblIdMesa);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.btnNovo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmCadastrarMesas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rodízio - Cadastrar Mesas";
            this.TopMost = true;
            this.gpbStatus.ResumeLayout(false);
            this.gpbStatus.PerformLayout();
            this.gpbPesquisarMesas.ResumeLayout(false);
            this.gpbPesquisarMesas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label lblIdMesa;
        private System.Windows.Forms.Label lblQtd;
        private System.Windows.Forms.TextBox txtIdMesa;
        private System.Windows.Forms.TextBox txtQtd;
        private System.Windows.Forms.GroupBox gpbStatus;
        private System.Windows.Forms.RadioButton rdbIndisponivel;
        private System.Windows.Forms.RadioButton rdbDisponivel;
        private System.Windows.Forms.GroupBox gpbPesquisarMesas;
        private System.Windows.Forms.RadioButton rdbPesquisarIndisponivel;
        private System.Windows.Forms.RadioButton rdbPesquisarDisponivel;
        private System.Windows.Forms.ListBox ltbPesquisarMesas;
    }
}