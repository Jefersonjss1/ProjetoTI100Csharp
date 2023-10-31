
namespace CalcularGorjeta
{
    partial class frmCalcularGorjeta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalcularGorjeta));
            this.gpbGorjeta = new System.Windows.Forms.GroupBox();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.txtValorGorjeta = new System.Windows.Forms.TextBox();
            this.lblValorGorjeta = new System.Windows.Forms.Label();
            this.btnCalcularGorjeta = new System.Windows.Forms.Button();
            this.lblQualidade = new System.Windows.Forms.Label();
            this.txtValorConta = new System.Windows.Forms.TextBox();
            this.lblValorConta = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.cbbQualidade = new System.Windows.Forms.ComboBox();
            this.cbbNomeFuncionario = new System.Windows.Forms.ComboBox();
            this.lblNomeFuncionario = new System.Windows.Forms.Label();
            this.lblCodFunc = new System.Windows.Forms.Label();
            this.txtCodFunc = new System.Windows.Forms.TextBox();
            this.gpbGorjeta.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbGorjeta
            // 
            this.gpbGorjeta.Controls.Add(this.txtCodFunc);
            this.gpbGorjeta.Controls.Add(this.lblCodFunc);
            this.gpbGorjeta.Controls.Add(this.lblNomeFuncionario);
            this.gpbGorjeta.Controls.Add(this.cbbNomeFuncionario);
            this.gpbGorjeta.Controls.Add(this.cbbQualidade);
            this.gpbGorjeta.Controls.Add(this.btnCancelar);
            this.gpbGorjeta.Controls.Add(this.btnLimpar);
            this.gpbGorjeta.Controls.Add(this.txtValorTotal);
            this.gpbGorjeta.Controls.Add(this.lblValorTotal);
            this.gpbGorjeta.Controls.Add(this.txtValorGorjeta);
            this.gpbGorjeta.Controls.Add(this.lblValorGorjeta);
            this.gpbGorjeta.Controls.Add(this.btnCalcularGorjeta);
            this.gpbGorjeta.Controls.Add(this.lblQualidade);
            this.gpbGorjeta.Controls.Add(this.txtValorConta);
            this.gpbGorjeta.Controls.Add(this.lblValorConta);
            this.gpbGorjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbGorjeta.Location = new System.Drawing.Point(88, 44);
            this.gpbGorjeta.Name = "gpbGorjeta";
            this.gpbGorjeta.Size = new System.Drawing.Size(608, 467);
            this.gpbGorjeta.TabIndex = 0;
            this.gpbGorjeta.TabStop = false;
            this.gpbGorjeta.Text = "Calculadora de Gorjeta";
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Enabled = false;
            this.txtValorTotal.Location = new System.Drawing.Point(25, 386);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.Size = new System.Drawing.Size(555, 26);
            this.txtValorTotal.TabIndex = 12;
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Location = new System.Drawing.Point(21, 363);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(85, 20);
            this.lblValorTotal.TabIndex = 11;
            this.lblValorTotal.Text = "Valor total:";
            // 
            // txtValorGorjeta
            // 
            this.txtValorGorjeta.Enabled = false;
            this.txtValorGorjeta.Location = new System.Drawing.Point(25, 310);
            this.txtValorGorjeta.Name = "txtValorGorjeta";
            this.txtValorGorjeta.Size = new System.Drawing.Size(555, 26);
            this.txtValorGorjeta.TabIndex = 10;
            // 
            // lblValorGorjeta
            // 
            this.lblValorGorjeta.AutoSize = true;
            this.lblValorGorjeta.Location = new System.Drawing.Point(21, 287);
            this.lblValorGorjeta.Name = "lblValorGorjeta";
            this.lblValorGorjeta.Size = new System.Drawing.Size(125, 20);
            this.lblValorGorjeta.TabIndex = 9;
            this.lblValorGorjeta.Text = "Valor da gorjeta:";
            // 
            // btnCalcularGorjeta
            // 
            this.btnCalcularGorjeta.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCalcularGorjeta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalcularGorjeta.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCalcularGorjeta.Location = new System.Drawing.Point(188, 245);
            this.btnCalcularGorjeta.Name = "btnCalcularGorjeta";
            this.btnCalcularGorjeta.Size = new System.Drawing.Size(223, 35);
            this.btnCalcularGorjeta.TabIndex = 8;
            this.btnCalcularGorjeta.Text = "Calcular Gorjeta";
            this.btnCalcularGorjeta.UseVisualStyleBackColor = false;
            this.btnCalcularGorjeta.Click += new System.EventHandler(this.btnCalcularGorjeta_Click);
            // 
            // lblQualidade
            // 
            this.lblQualidade.AutoSize = true;
            this.lblQualidade.Location = new System.Drawing.Point(21, 172);
            this.lblQualidade.Name = "lblQualidade";
            this.lblQualidade.Size = new System.Drawing.Size(160, 20);
            this.lblQualidade.TabIndex = 6;
            this.lblQualidade.Text = "Qualidade do serviço:";
            // 
            // txtValorConta
            // 
            this.txtValorConta.Location = new System.Drawing.Point(25, 103);
            this.txtValorConta.Name = "txtValorConta";
            this.txtValorConta.Size = new System.Drawing.Size(555, 26);
            this.txtValorConta.TabIndex = 5;
            // 
            // lblValorConta
            // 
            this.lblValorConta.AutoSize = true;
            this.lblValorConta.Location = new System.Drawing.Point(21, 80);
            this.lblValorConta.Name = "lblValorConta";
            this.lblValorConta.Size = new System.Drawing.Size(116, 20);
            this.lblValorConta.TabIndex = 0;
            this.lblValorConta.Text = "Valor da conta:";
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLimpar.Location = new System.Drawing.Point(25, 418);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(223, 35);
            this.btnLimpar.TabIndex = 13;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancelar.Location = new System.Drawing.Point(357, 418);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(223, 35);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // cbbQualidade
            // 
            this.cbbQualidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbQualidade.FormattingEnabled = true;
            this.cbbQualidade.Items.AddRange(new object[] {
            "Excelente - 10%",
            "Ótimo - 8%",
            "Bom - 5%",
            "Ruim - 2%"});
            this.cbbQualidade.Location = new System.Drawing.Point(25, 195);
            this.cbbQualidade.Name = "cbbQualidade";
            this.cbbQualidade.Size = new System.Drawing.Size(555, 28);
            this.cbbQualidade.TabIndex = 15;
            // 
            // cbbNomeFuncionario
            // 
            this.cbbNomeFuncionario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbNomeFuncionario.FormattingEnabled = true;
            this.cbbNomeFuncionario.Items.AddRange(new object[] {
            "Jeferson",
            "Jhonatan",
            "Ryan",
            "Allan",
            "Marcos",
            "Jefferson"});
            this.cbbNomeFuncionario.Location = new System.Drawing.Point(191, 33);
            this.cbbNomeFuncionario.Name = "cbbNomeFuncionario";
            this.cbbNomeFuncionario.Size = new System.Drawing.Size(134, 28);
            this.cbbNomeFuncionario.TabIndex = 16;
            // 
            // lblNomeFuncionario
            // 
            this.lblNomeFuncionario.AutoSize = true;
            this.lblNomeFuncionario.Location = new System.Drawing.Point(21, 36);
            this.lblNomeFuncionario.Name = "lblNomeFuncionario";
            this.lblNomeFuncionario.Size = new System.Drawing.Size(164, 20);
            this.lblNomeFuncionario.TabIndex = 17;
            this.lblNomeFuncionario.Text = "Nome do Funcionário:";
            // 
            // lblCodFunc
            // 
            this.lblCodFunc.AutoSize = true;
            this.lblCodFunc.Location = new System.Drawing.Point(340, 36);
            this.lblCodFunc.Name = "lblCodFunc";
            this.lblCodFunc.Size = new System.Drawing.Size(172, 20);
            this.lblCodFunc.TabIndex = 18;
            this.lblCodFunc.Text = "Código do Funcionário:";
            // 
            // txtCodFunc
            // 
            this.txtCodFunc.Location = new System.Drawing.Point(511, 33);
            this.txtCodFunc.Name = "txtCodFunc";
            this.txtCodFunc.Size = new System.Drawing.Size(69, 26);
            this.txtCodFunc.TabIndex = 19;
            // 
            // frmCalcularGorjeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 557);
            this.Controls.Add(this.gpbGorjeta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmCalcularGorjeta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.gpbGorjeta.ResumeLayout(false);
            this.gpbGorjeta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbGorjeta;
        private System.Windows.Forms.TextBox txtValorTotal;
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.TextBox txtValorGorjeta;
        private System.Windows.Forms.Label lblValorGorjeta;
        private System.Windows.Forms.Button btnCalcularGorjeta;
        private System.Windows.Forms.Label lblQualidade;
        private System.Windows.Forms.TextBox txtValorConta;
        private System.Windows.Forms.Label lblValorConta;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cbbQualidade;
        private System.Windows.Forms.ComboBox cbbNomeFuncionario;
        private System.Windows.Forms.TextBox txtCodFunc;
        private System.Windows.Forms.Label lblCodFunc;
        private System.Windows.Forms.Label lblNomeFuncionario;
    }
}

