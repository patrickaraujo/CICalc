using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculo_media
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double n1, n2, n3, media;
            n1 = Convert.ToDouble(txtNota2.Text);
            n2 = Convert.ToDouble(txtNota1.Text);
            n3 = Convert.ToDouble(txtNota3.Text);
            media = (n1 + n2 + n3) / 3;
            lblMedia.Text = media.ToString();
            if (media > 7)
                MessageBox.Show("Aluno aprovado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (media >= 4)
                MessageBox.Show("Aluno de exame!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Question);
            else
                MessageBox.Show("Aluno reprovado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNota2.Text = "";
            txtNota1.Text = "";
            txtNota3.Text = "";
            lblMedia.Text = "Vazio";
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
