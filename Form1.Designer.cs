namespace Trabalho_Veiculo_Luis
{
    partial class Form1
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
            this.BtnVeiculo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnVeiculo
            // 
            this.BtnVeiculo.Location = new System.Drawing.Point(81, 87);
            this.BtnVeiculo.Name = "BtnVeiculo";
            this.BtnVeiculo.Size = new System.Drawing.Size(105, 49);
            this.BtnVeiculo.TabIndex = 0;
            this.BtnVeiculo.Text = "Veiculo";
            this.BtnVeiculo.UseVisualStyleBackColor = true;
            this.BtnVeiculo.Click += new System.EventHandler(this.BtnVeiculo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 342);
            this.Controls.Add(this.BtnVeiculo);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trabalho Veiculo Luis Haraldo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnVeiculo;
    }
}

