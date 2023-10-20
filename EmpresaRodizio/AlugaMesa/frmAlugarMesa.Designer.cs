
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
            this.lblNomeCliente = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnLiberar = new System.Windows.Forms.Button();
            this.btnAlugar = new System.Windows.Forms.Button();
            this.gpbPesquisarMesas = new System.Windows.Forms.GroupBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.gpbPesquisarMesas.SuspendLayout();
            this.SuspendLayout();
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
            // rdbDisponivel
            // 
            this.rdbDisponivel.AutoSize = true;
            this.rdbDisponivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbDisponivel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rdbDisponivel.Location = new System.Drawing.Point(18, 30);
            this.rdbDisponivel.Name = "rdbDisponivel";
            this.rdbDisponivel.Size = new System.Drawing.Size(99, 24);
            this.rdbDisponivel.TabIndex = 42;
            this.rdbDisponivel.TabStop = true;
            this.rdbDisponivel.Text = "Disponível";
            this.rdbDisponivel.UseVisualStyleBackColor = true;
            // 
            // rdbIndisponivel
            // 
            this.rdbIndisponivel.AutoSize = true;
            this.rdbIndisponivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbIndisponivel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rdbIndisponivel.Location = new System.Drawing.Point(255, 30);
            this.rdbIndisponivel.Name = "rdbIndisponivel";
            this.rdbIndisponivel.Size = new System.Drawing.Size(110, 24);
            this.rdbIndisponivel.TabIndex = 41;
            this.rdbIndisponivel.TabStop = true;
            this.rdbIndisponivel.Text = "Indisponível";
            this.rdbIndisponivel.UseVisualStyleBackColor = true;
            // 
            // txtStatusMesa
            // 
            this.txtStatusMesa.Location = new System.Drawing.Point(168, 88);
            this.txtStatusMesa.Name = "txtStatusMesa";
            this.txtStatusMesa.Size = new System.Drawing.Size(129, 20);
            this.txtStatusMesa.TabIndex = 38;
            // 
            // txtCodigoMesa
            // 
            this.txtCodigoMesa.Location = new System.Drawing.Point(168, 56);
            this.txtCodigoMesa.Name = "txtCodigoMesa";
            this.txtCodigoMesa.Size = new System.Drawing.Size(129, 20);
            this.txtCodigoMesa.TabIndex = 37;
            // 
            // lblStatusMesa
            // 
            this.lblStatusMesa.AutoSize = true;
            this.lblStatusMesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblStatusMesa.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblStatusMesa.Location = new System.Drawing.Point(39, 84);
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
            this.lblCodigoMesa.Location = new System.Drawing.Point(36, 54);
            this.lblCodigoMesa.Name = "lblCodigoMesa";
            this.lblCodigoMesa.Size = new System.Drawing.Size(124, 20);
            this.lblCodigoMesa.TabIndex = 39;
            this.lblCodigoMesa.Text = "Código da Mesa";
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Location = new System.Drawing.Point(168, 26);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(129, 20);
            this.txtNomeCliente.TabIndex = 34;
            // 
            // lblNomeCliente
            // 
            this.lblNomeCliente.AutoSize = true;
            this.lblNomeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeCliente.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblNomeCliente.Location = new System.Drawing.Point(36, 24);
            this.lblNomeCliente.Name = "lblNomeCliente";
            this.lblNomeCliente.Size = new System.Drawing.Size(126, 20);
            this.lblNomeCliente.TabIndex = 36;
            this.lblNomeCliente.Text = "Nome do Cliente";
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnVoltar.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltar.Image")));
            this.btnVoltar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnVoltar.Location = new System.Drawing.Point(519, 388);
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
            this.btnLimpar.Location = new System.Drawing.Point(410, 388);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(103, 50);
            this.btnLimpar.TabIndex = 31;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnLiberar
            // 
            this.btnLiberar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLiberar.Image = ((System.Drawing.Image)(resources.GetObject("btnLiberar.Image")));
            this.btnLiberar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnLiberar.Location = new System.Drawing.Point(301, 388);
            this.btnLiberar.Name = "btnLiberar";
            this.btnLiberar.Size = new System.Drawing.Size(103, 50);
            this.btnLiberar.TabIndex = 30;
            this.btnLiberar.Text = "&Liberar";
            this.btnLiberar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLiberar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLiberar.UseVisualStyleBackColor = false;
            this.btnLiberar.Click += new System.EventHandler(this.btnLiberar_Click);
            // 
            // btnAlugar
            // 
            this.btnAlugar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAlugar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlugar.Image")));
            this.btnAlugar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAlugar.Location = new System.Drawing.Point(192, 388);
            this.btnAlugar.Name = "btnAlugar";
            this.btnAlugar.Size = new System.Drawing.Size(103, 50);
            this.btnAlugar.TabIndex = 29;
            this.btnAlugar.Text = "&Alugar";
            this.btnAlugar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAlugar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAlugar.UseVisualStyleBackColor = false;
            this.btnAlugar.Click += new System.EventHandler(this.btnAlugar_Click);
            // 
            // gpbPesquisarMesas
            // 
            this.gpbPesquisarMesas.Controls.Add(this.btnPesquisar);
            this.gpbPesquisarMesas.Controls.Add(this.rdbIndisponivel);
            this.gpbPesquisarMesas.Controls.Add(this.rdbDisponivel);
            this.gpbPesquisarMesas.Controls.Add(this.ltbPesquisarMesas);
            this.gpbPesquisarMesas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbPesquisarMesas.Location = new System.Drawing.Point(392, 24);
            this.gpbPesquisarMesas.Name = "gpbPesquisarMesas";
            this.gpbPesquisarMesas.Size = new System.Drawing.Size(380, 347);
            this.gpbPesquisarMesas.TabIndex = 44;
            this.gpbPesquisarMesas.TabStop = false;
            this.gpbPesquisarMesas.Text = "Pesquisar Mesas";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.Image")));
            this.btnPesquisar.Location = new System.Drawing.Point(127, 56);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(113, 50);
            this.btnPesquisar.TabIndex = 45;
            this.btnPesquisar.Text = "&Pesquisar";
            this.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
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
            this.Controls.Add(this.lblNomeCliente);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnLiberar);
            this.Controls.Add(this.btnAlugar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Name = "frmAlugarMesa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Label lblNomeCliente;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnLiberar;
        private System.Windows.Forms.Button btnAlugar;
        private System.Windows.Forms.GroupBox gpbPesquisarMesas;
        private System.Windows.Forms.Button btnPesquisar;
    }
}