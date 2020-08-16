namespace EstudoIfElse
{
    partial class frmIfElse
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txbIdade = new System.Windows.Forms.TextBox();
            this.btnVerifIdade = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite a idade desejada";
            // 
            // txbIdade
            // 
            this.txbIdade.Location = new System.Drawing.Point(136, 11);
            this.txbIdade.Name = "txbIdade";
            this.txbIdade.Size = new System.Drawing.Size(100, 20);
            this.txbIdade.TabIndex = 1;
            // 
            // btnVerifIdade
            // 
            this.btnVerifIdade.Location = new System.Drawing.Point(252, 10);
            this.btnVerifIdade.Name = "btnVerifIdade";
            this.btnVerifIdade.Size = new System.Drawing.Size(75, 23);
            this.btnVerifIdade.TabIndex = 2;
            this.btnVerifIdade.Text = "Verificar";
            this.btnVerifIdade.UseVisualStyleBackColor = true;
            this.btnVerifIdade.Click += new System.EventHandler(this.btnVerifIdade_Click);
            // 
            // frmIfElse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 41);
            this.Controls.Add(this.btnVerifIdade);
            this.Controls.Add(this.txbIdade);
            this.Controls.Add(this.label1);
            this.Name = "frmIfElse";
            this.Text = "TreinaWeb - Estudo de IF/Else";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbIdade;
        private System.Windows.Forms.Button btnVerifIdade;
    }
}

