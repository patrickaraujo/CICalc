namespace Splash_Screen
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTeste = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnVTextos = new System.Windows.Forms.Button();
            this.btnA2D = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bem Vindo!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Teste Vetor:";
            // 
            // btnTeste
            // 
            this.btnTeste.Location = new System.Drawing.Point(146, 50);
            this.btnTeste.Name = "btnTeste";
            this.btnTeste.Size = new System.Drawing.Size(123, 23);
            this.btnTeste.TabIndex = 2;
            this.btnTeste.Text = "Teste Vetor";
            this.btnTeste.UseVisualStyleBackColor = true;
            this.btnTeste.Click += new System.EventHandler(this.btnTeste_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Vetor Textos: ";
            // 
            // btnVTextos
            // 
            this.btnVTextos.Location = new System.Drawing.Point(146, 79);
            this.btnVTextos.Name = "btnVTextos";
            this.btnVTextos.Size = new System.Drawing.Size(123, 23);
            this.btnVTextos.TabIndex = 4;
            this.btnVTextos.Text = "Vetor Textos";
            this.btnVTextos.UseVisualStyleBackColor = true;
            this.btnVTextos.Click += new System.EventHandler(this.btnVTextos_Click);
            // 
            // btnA2D
            // 
            this.btnA2D.Location = new System.Drawing.Point(146, 108);
            this.btnA2D.Name = "btnA2D";
            this.btnA2D.Size = new System.Drawing.Size(123, 23);
            this.btnA2D.TabIndex = 5;
            this.btnA2D.Text = "Array Multidimensional";
            this.btnA2D.UseVisualStyleBackColor = true;
            this.btnA2D.Click += new System.EventHandler(this.btnA2D_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Array Multidimensional: ";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 141);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnA2D);
            this.Controls.Add(this.btnVTextos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnTeste);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTeste;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnVTextos;
        private System.Windows.Forms.Button btnA2D;
        private System.Windows.Forms.Label label4;
    }
}