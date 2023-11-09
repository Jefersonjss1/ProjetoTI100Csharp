
namespace CalcularGorjeta
{
    partial class frmMenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuPrincipal));
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnCalcularGorjeta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrar.Image")));
            this.btnCadastrar.Location = new System.Drawing.Point(149, 116);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(221, 203);
            this.btnCadastrar.TabIndex = 0;
            this.btnCadastrar.Text = "Cadastrar Funcionários";
            this.btnCadastrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCadastrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnCalcularGorjeta
            // 
            this.btnCalcularGorjeta.Image = ((System.Drawing.Image)(resources.GetObject("btnCalcularGorjeta.Image")));
            this.btnCalcularGorjeta.Location = new System.Drawing.Point(407, 116);
            this.btnCalcularGorjeta.Name = "btnCalcularGorjeta";
            this.btnCalcularGorjeta.Size = new System.Drawing.Size(221, 203);
            this.btnCalcularGorjeta.TabIndex = 1;
            this.btnCalcularGorjeta.Text = "Calcular Gorjeta";
            this.btnCalcularGorjeta.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCalcularGorjeta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCalcularGorjeta.UseVisualStyleBackColor = true;
            this.btnCalcularGorjeta.Click += new System.EventHandler(this.btnCalcularGorjeta_Click);
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalcularGorjeta);
            this.Controls.Add(this.btnCadastrar);
            this.Name = "frmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMenuPrincipal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnCalcularGorjeta;
    }
}