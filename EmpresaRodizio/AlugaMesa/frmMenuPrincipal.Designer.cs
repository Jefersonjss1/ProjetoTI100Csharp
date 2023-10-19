
namespace AlugaMesa
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
            this.btnCadastrarMesas = new System.Windows.Forms.Button();
            this.btnAlugarMesa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCadastrarMesas
            // 
            this.btnCadastrarMesas.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCadastrarMesas.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarMesas.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrarMesas.Image")));
            this.btnCadastrarMesas.Location = new System.Drawing.Point(120, 95);
            this.btnCadastrarMesas.Name = "btnCadastrarMesas";
            this.btnCadastrarMesas.Size = new System.Drawing.Size(243, 271);
            this.btnCadastrarMesas.TabIndex = 0;
            this.btnCadastrarMesas.Text = "&Cadastrar Mesas";
            this.btnCadastrarMesas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCadastrarMesas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCadastrarMesas.UseVisualStyleBackColor = false;
            this.btnCadastrarMesas.Click += new System.EventHandler(this.btnCadastrarMesas_Click);
            // 
            // btnAlugarMesa
            // 
            this.btnAlugarMesa.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAlugarMesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlugarMesa.Image = ((System.Drawing.Image)(resources.GetObject("btnAlugarMesa.Image")));
            this.btnAlugarMesa.Location = new System.Drawing.Point(432, 95);
            this.btnAlugarMesa.Name = "btnAlugarMesa";
            this.btnAlugarMesa.Size = new System.Drawing.Size(243, 271);
            this.btnAlugarMesa.TabIndex = 1;
            this.btnAlugarMesa.Text = "&Alugar Mesa";
            this.btnAlugarMesa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAlugarMesa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAlugarMesa.UseVisualStyleBackColor = false;
            this.btnAlugarMesa.Click += new System.EventHandler(this.btnAlugarMesa_Click);
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 457);
            this.Controls.Add(this.btnAlugarMesa);
            this.Controls.Add(this.btnCadastrarMesas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Rodízio - Menu Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrarMesas;
        private System.Windows.Forms.Button btnAlugarMesa;
    }
}

