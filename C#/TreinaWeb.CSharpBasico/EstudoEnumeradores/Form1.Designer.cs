namespace EstudoEnumeradores
{
    partial class frmEstudoEnumeradores
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
            this.cmbDias = new System.Windows.Forms.ComboBox();
            this.btnExibirDia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbDias
            // 
            this.cmbDias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDias.FormattingEnabled = true;
            this.cmbDias.Location = new System.Drawing.Point(12, 11);
            this.cmbDias.Name = "cmbDias";
            this.cmbDias.Size = new System.Drawing.Size(184, 21);
            this.cmbDias.TabIndex = 0;
            // 
            // btnExibirDia
            // 
            this.btnExibirDia.Location = new System.Drawing.Point(202, 10);
            this.btnExibirDia.Name = "btnExibirDia";
            this.btnExibirDia.Size = new System.Drawing.Size(75, 23);
            this.btnExibirDia.TabIndex = 1;
            this.btnExibirDia.Text = "Ok";
            this.btnExibirDia.UseVisualStyleBackColor = true;
            this.btnExibirDia.Click += new System.EventHandler(this.btnExibirDia_Click);
            // 
            // frmEstudoEnumeradores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 39);
            this.Controls.Add(this.btnExibirDia);
            this.Controls.Add(this.cmbDias);
            this.Name = "frmEstudoEnumeradores";
            this.Text = "TreinaWeb - Estudo Enumeradores";
            this.Shown += new System.EventHandler(this.frmEstudoEnumeradores_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbDias;
        private System.Windows.Forms.Button btnExibirDia;
    }
}

