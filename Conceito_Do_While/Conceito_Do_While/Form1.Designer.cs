namespace Conceito_Do_While
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
            this.lblNum = new System.Windows.Forms.Label();
            this.btnDW = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Location = new System.Drawing.Point(142, 47);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(29, 13);
            this.lblNum.TabIndex = 0;
            this.lblNum.Text = "Zero";
            // 
            // btnDW
            // 
            this.btnDW.Location = new System.Drawing.Point(16, 42);
            this.btnDW.Name = "btnDW";
            this.btnDW.Size = new System.Drawing.Size(96, 23);
            this.btnDW.TabIndex = 1;
            this.btnDW.Text = "Teste: Do/While";
            this.btnDW.UseVisualStyleBackColor = true;
            this.btnDW.Click += new System.EventHandler(this.btnDW_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Teste: Do/While";
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(16, 71);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(155, 23);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(186, 102);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDW);
            this.Controls.Add(this.lblNum);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.Button btnDW;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSair;
    }
}

