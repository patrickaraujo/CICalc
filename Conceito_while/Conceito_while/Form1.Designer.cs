namespace Conceito_while
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
            this.lblNumero = new System.Windows.Forms.Label();
            this.btnTeste = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnProximo = new System.Windows.Forms.Button();
            this.btnZerar = new System.Windows.Forms.Button();
            this.btnTabuada = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(97, 40);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(29, 13);
            this.lblNumero.TabIndex = 0;
            this.lblNumero.Text = "Zero";
            // 
            // btnTeste
            // 
            this.btnTeste.Location = new System.Drawing.Point(12, 56);
            this.btnTeste.Name = "btnTeste";
            this.btnTeste.Size = new System.Drawing.Size(134, 23);
            this.btnTeste.TabIndex = 1;
            this.btnTeste.Text = "Iniciar: Teste While";
            this.btnTeste.UseVisualStyleBackColor = true;
            this.btnTeste.Click += new System.EventHandler(this.btnTeste_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(12, 85);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(34, 23);
            this.btnSair.TabIndex = 2;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnProximo
            // 
            this.btnProximo.Location = new System.Drawing.Point(152, 85);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(56, 23);
            this.btnProximo.TabIndex = 3;
            this.btnProximo.Text = "Próximo";
            this.btnProximo.UseVisualStyleBackColor = true;
            this.btnProximo.Click += new System.EventHandler(this.btnProximo_Click);
            // 
            // btnZerar
            // 
            this.btnZerar.Location = new System.Drawing.Point(159, 56);
            this.btnZerar.Name = "btnZerar";
            this.btnZerar.Size = new System.Drawing.Size(49, 23);
            this.btnZerar.TabIndex = 4;
            this.btnZerar.Text = "Zerar";
            this.btnZerar.UseVisualStyleBackColor = true;
            this.btnZerar.Click += new System.EventHandler(this.btnZerar_Click);
            // 
            // btnTabuada
            // 
            this.btnTabuada.Location = new System.Drawing.Point(52, 85);
            this.btnTabuada.Name = "btnTabuada";
            this.btnTabuada.Size = new System.Drawing.Size(94, 23);
            this.btnTabuada.TabIndex = 5;
            this.btnTabuada.Text = "Último: Tabuada";
            this.btnTabuada.UseVisualStyleBackColor = true;
            this.btnTabuada.Click += new System.EventHandler(this.btnTabuada_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Contador";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 120);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTabuada);
            this.Controls.Add(this.btnZerar);
            this.Controls.Add(this.btnProximo);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnTeste);
            this.Controls.Add(this.lblNumero);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Button btnTeste;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnProximo;
        private System.Windows.Forms.Button btnZerar;
        private System.Windows.Forms.Button btnTabuada;
        private System.Windows.Forms.Label label1;
    }
}

