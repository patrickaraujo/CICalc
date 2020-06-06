namespace Condicao_if
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtBIdade = new System.Windows.Forms.TextBox();
            this.bntVerId = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite a sua idade: ";
            // 
            // txtBIdade
            // 
            this.txtBIdade.Location = new System.Drawing.Point(16, 41);
            this.txtBIdade.Name = "txtBIdade";
            this.txtBIdade.Size = new System.Drawing.Size(100, 20);
            this.txtBIdade.TabIndex = 1;
            // 
            // bntVerId
            // 
            this.bntVerId.Location = new System.Drawing.Point(122, 41);
            this.bntVerId.Name = "bntVerId";
            this.bntVerId.Size = new System.Drawing.Size(85, 23);
            this.bntVerId.TabIndex = 2;
            this.bntVerId.Text = "Verificar Idade";
            this.bntVerId.UseVisualStyleBackColor = true;
            this.bntVerId.Click += new System.EventHandler(this.bntVerId_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 92);
            this.Controls.Add(this.bntVerId);
            this.Controls.Add(this.txtBIdade);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBIdade;
        private System.Windows.Forms.Button bntVerId;
    }
}

