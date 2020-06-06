namespace Switch_case
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
            this.cboSemana = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnProxExem = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cboSemana
            // 
            this.cboSemana.FormattingEnabled = true;
            this.cboSemana.Items.AddRange(new object[] {
            "Domingo",
            "Segunda",
            "Terça",
            "Quarta",
            "Quinta",
            "Sexta",
            "Sábado"});
            this.cboSemana.Location = new System.Drawing.Point(40, 63);
            this.cboSemana.Name = "cboSemana";
            this.cboSemana.Size = new System.Drawing.Size(121, 21);
            this.cboSemana.TabIndex = 0;
            this.cboSemana.SelectedIndexChanged += new System.EventHandler(this.cboSemana_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Escolha um dia da semana: ";
            // 
            // btnProxExem
            // 
            this.btnProxExem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProxExem.Location = new System.Drawing.Point(168, 121);
            this.btnProxExem.Name = "btnProxExem";
            this.btnProxExem.Size = new System.Drawing.Size(110, 23);
            this.btnProxExem.TabIndex = 2;
            this.btnProxExem.Text = "Próximo Exemplo";
            this.btnProxExem.UseVisualStyleBackColor = true;
            this.btnProxExem.Click += new System.EventHandler(this.btnProxExem_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(40, 121);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 156);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnProxExem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboSemana);
            this.Name = "Form1";
            this.Text = "Switch_Case";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboSemana;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnProxExem;
        private System.Windows.Forms.Button btnSair;
    }
}

