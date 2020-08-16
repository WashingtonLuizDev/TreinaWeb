namespace EstudoSwitch
{
    partial class frmSwitch
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
            this.btnVerificarNumero = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txbNumero = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnVerificarNumero
            // 
            this.btnVerificarNumero.Location = new System.Drawing.Point(243, 12);
            this.btnVerificarNumero.Name = "btnVerificarNumero";
            this.btnVerificarNumero.Size = new System.Drawing.Size(75, 23);
            this.btnVerificarNumero.TabIndex = 0;
            this.btnVerificarNumero.Text = "Verificar";
            this.btnVerificarNumero.UseVisualStyleBackColor = true;
            this.btnVerificarNumero.Click += new System.EventHandler(this.btnVerificarNumero_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Número a ser verificado";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txbNumero
            // 
            this.txbNumero.Location = new System.Drawing.Point(137, 13);
            this.txbNumero.Name = "txbNumero";
            this.txbNumero.Size = new System.Drawing.Size(100, 20);
            this.txbNumero.TabIndex = 2;
            // 
            // frmSwitch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 44);
            this.Controls.Add(this.txbNumero);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVerificarNumero);
            this.Name = "frmSwitch";
            this.Text = "TreinaWeb Estudo do Switch";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVerificarNumero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbNumero;
    }
}

