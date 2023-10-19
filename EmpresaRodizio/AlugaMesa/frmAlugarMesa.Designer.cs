
namespace AlugaMesa
{
    partial class frmAlugarMesa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAlugarMesa));
            this.ltbPesquisarMesas = new System.Windows.Forms.ListBox();
            this.rdbDisponivel = new System.Windows.Forms.RadioButton();
            this.rdbIndisponivel = new System.Windows.Forms.RadioButton();
            this.txtStatusMesa = new System.Windows.Forms.TextBox();
            this.txtCodigoMesa = new System.Windows.Forms.TextBox();
            this.lblStatusMesa = new System.Windows.Forms.Label();
            this.lblCodigoMesa = new System.Windows.Forms.Label();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.txtCodigoAluguel = new System.Windows.Forms.TextBox();
            this.lblNomeCliente = new System.Windows.Forms.Label();
            this.lblCodigoAluguel = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnLiberar = new System.Windows.Forms.Button();
            this.btnAlugar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.gpbPesquisarMesas = new System.Windows.Forms.GroupBox();
            this.gpbPesquisarMesas.SuspendLayout();
            this.SuspendLayout();
            // 
            // ltbPesquisarMesas
            // 
            this.ltbPesquisarMesas.FormattingEnabled = true;
            this.ltbPesquisarMesas.Location = new System.Drawing.Point(6, 112);
            this.ltbPesquisarMesas.Name = "ltbPesquisarMesas";
            this.ltbPesquisarMesas.Size = new System.Drawing.Size(368, 225);
            this.ltbPesquisarMesas.TabIndex = 43;
            // 
            // rdbDisponivel
            // 
            this.rdbDisponivel.AutoSize = true;
            this.rdbDisponivel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rdbDisponivel.Location = new System.Drawing.Point(32, 30);
            this.rdbDisponivel.Name = "rdbDisponivel";
            this.rdbDisponivel.Size = new System.Drawing.Size(76, 17);
            this.rdbDisponivel.TabIndex = 42;
            this.rdbDisponivel.TabStop = true;
            this.rdbDisponivel.Text = "Disponível";
            this.rdbDisponivel.UseVisualStyleBackColor = true;
            // 
            // rdbIndisponivel
            // 
            this.rdbIndisponivel.AutoSize = true;
            this.rdbIndisponivel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rdbIndisponivel.Location = new System.Drawing.Point(263, 30);
            this.rdbIndisponivel.Name = "rdbIndisponivel";
            this.rdbIndisponivel.Size = new System.Drawing.Size(83, 17);
            this.rdbIndisponivel.TabIndex = 41;
            this.rdbIndisponivel.TabStop = true;
            this.rdbIndisponivel.Text = "Indisponível";
            this.rdbIndisponivel.UseVisualStyleBackColor = true;
            // 
            // txtStatusMesa
            // 
            this.txtStatusMesa.Location = new System.Drawing.Point(166, 118);
            this.txtStatusMesa.Name = "txtStatusMesa";
            this.txtStatusMesa.Size = new System.Drawing.Size(129, 20);
            this.txtStatusMesa.TabIndex = 38;
            // 
            // txtCodigoMesa
            // 
            this.txtCodigoMesa.Location = new System.Drawing.Point(166, 86);
            this.txtCodigoMesa.Name = "txtCodigoMesa";
            this.txtCodigoMesa.Size = new System.Drawing.Size(129, 20);
            this.txtCodigoMesa.TabIndex = 37;
            // 
            // lblStatusMesa
            // 
            this.lblStatusMesa.AutoSize = true;
            this.lblStatusMesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblStatusMesa.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblStatusMesa.Location = new System.Drawing.Point(37, 114);
            this.lblStatusMesa.Name = "lblStatusMesa";
            this.lblStatusMesa.Size = new System.Drawing.Size(121, 20);
            this.lblStatusMesa.TabIndex = 40;
            this.lblStatusMesa.Text = "Status da Mesa";
            // 
            // lblCodigoMesa
            // 
            this.lblCodigoMesa.AutoSize = true;
            this.lblCodigoMesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblCodigoMesa.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblCodigoMesa.Location = new System.Drawing.Point(34, 84);
            this.lblCodigoMesa.Name = "lblCodigoMesa";
            this.lblCodigoMesa.Size = new System.Drawing.Size(124, 20);
            this.lblCodigoMesa.TabIndex = 39;
            this.lblCodigoMesa.Text = "Código da Mesa";
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Location = new System.Drawing.Point(166, 56);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(129, 20);
            this.txtNomeCliente.TabIndex = 34;
            // 
            // txtCodigoAluguel
            // 
            this.txtCodigoAluguel.Location = new System.Drawing.Point(166, 24);
            this.txtCodigoAluguel.Name = "txtCodigoAluguel";
            this.txtCodigoAluguel.Size = new System.Drawing.Size(129, 20);
            this.txtCodigoAluguel.TabIndex = 33;
            // 
            // lblNomeCliente
            // 
            this.lblNomeCliente.AutoSize = true;
            this.lblNomeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblNomeCliente.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblNomeCliente.Location = new System.Drawing.Point(34, 54);
            this.lblNomeCliente.Name = "lblNomeCliente";
            this.lblNomeCliente.Size = new System.Drawing.Size(126, 20);
            this.lblNomeCliente.TabIndex = 36;
            this.lblNomeCliente.Text = "Nome do Cliente";
            // 
            // lblCodigoAluguel
            // 
            this.lblCodigoAluguel.AutoSize = true;
            this.lblCodigoAluguel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblCodigoAluguel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblCodigoAluguel.Location = new System.Drawing.Point(22, 24);
            this.lblCodigoAluguel.Name = "lblCodigoAluguel";
            this.lblCodigoAluguel.Size = new System.Drawing.Size(138, 20);
            this.lblCodigoAluguel.TabIndex = 35;
            this.lblCodigoAluguel.Text = "Código do Aluguel";
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnVoltar.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltar.Image")));
            this.btnVoltar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnVoltar.Location = new System.Drawing.Point(571, 388);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(103, 50);
            this.btnVoltar.TabIndex = 32;
            this.btnVoltar.Text = "&Voltar";
            this.btnVoltar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVoltar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpar.Image")));
            this.btnLimpar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnLimpar.Location = new System.Drawing.Point(462, 388);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(103, 50);
            this.btnLimpar.TabIndex = 31;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpar.UseVisualStyleBackColor = false;
            // 
            // btnLiberar
            // 
            this.btnLiberar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLiberar.Image = ((System.Drawing.Image)(resources.GetObject("btnLiberar.Image")));
            this.btnLiberar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnLiberar.Location = new System.Drawing.Point(353, 388);
            this.btnLiberar.Name = "btnLiberar";
            this.btnLiberar.Size = new System.Drawing.Size(103, 50);
            this.btnLiberar.TabIndex = 30;
            this.btnLiberar.Text = "&Liberar";
            this.btnLiberar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLiberar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLiberar.UseVisualStyleBackColor = false;
            // 
            // btnAlugar
            // 
            this.btnAlugar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAlugar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlugar.Image")));
            this.btnAlugar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAlugar.Location = new System.Drawing.Point(244, 388);
            this.btnAlugar.Name = "btnAlugar";
            this.btnAlugar.Size = new System.Drawing.Size(103, 50);
            this.btnAlugar.TabIndex = 29;
            this.btnAlugar.Text = "&Alugar";
            this.btnAlugar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAlugar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAlugar.UseVisualStyleBackColor = false;
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo.Image")));
            this.btnNovo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnNovo.Location = new System.Drawing.Point(135, 388);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(103, 50);
            this.btnNovo.TabIndex = 28;
            this.btnNovo.Text = "&Novo";
            this.btnNovo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNovo.UseVisualStyleBackColor = false;
            // 
            // gpbPesquisarMesas
            // 
            this.gpbPesquisarMesas.Controls.Add(this.rdbIndisponivel);
            this.gpbPesquisarMesas.Controls.Add(this.rdbDisponivel);
            this.gpbPesquisarMesas.Controls.Add(this.ltbPesquisarMesas);
            this.gpbPesquisarMesas.Location = new System.Drawing.Point(392, 24);
            this.gpbPesquisarMesas.Name = "gpbPesquisarMesas";
            this.gpbPesquisarMesas.Size = new System.Drawing.Size(380, 347);
            this.gpbPesquisarMesas.TabIndex = 44;
            this.gpbPesquisarMesas.TabStop = false;
            this.gpbPesquisarMesas.Text = "Pesquisar Mesas";
            // 
            // frmAlugarMesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gpbPesquisarMesas);
            this.Controls.Add(this.txtStatusMesa);
            this.Controls.Add(this.txtCodigoMesa);
            this.Controls.Add(this.lblStatusMesa);
            this.Controls.Add(this.lblCodigoMesa);
            this.Controls.Add(this.txtNomeCliente);
            this.Controls.Add(this.txtCodigoAluguel);
            this.Controls.Add(this.lblNomeCliente);
            this.Controls.Add(this.lblCodigoAluguel);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnLiberar);
            this.Controls.Add(this.btnAlugar);
            this.Controls.Add(this.btnNovo);
            this.Name = "frmAlugarMesa";
            this.Text = "frmAlugarMesa";
            this.gpbPesquisarMesas.ResumeLayout(false);
            this.gpbPesquisarMesas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ltbPesquisarMesas;
        private System.Windows.Forms.RadioButton rdbDisponivel;
        private System.Windows.Forms.RadioButton rdbIndisponivel;
        private System.Windows.Forms.TextBox txtStatusMesa;
        private System.Windows.Forms.TextBox txtCodigoMesa;
        private System.Windows.Forms.Label lblStatusMesa;
        private System.Windows.Forms.Label lblCodigoMesa;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.TextBox txtCodigoAluguel;
        private System.Windows.Forms.Label lblNomeCliente;
        private System.Windows.Forms.Label lblCodigoAluguel;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnLiberar;
        private System.Windows.Forms.Button btnAlugar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.GroupBox gpbPesquisarMesas;
    }
}