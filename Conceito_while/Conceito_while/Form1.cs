using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conceito_while
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTeste_Click(object sender, EventArgs e)
        {
            int c = 0;
            while (c < 10000){
                c = c + 1;
                lblNumero.Text = Convert.ToString(c);
                lblNumero.Refresh();
                /* Declaração de variável c, inicializada com zero. Condição: enquanto o c for menor que 10000 será executado o laço Incremento Refresh é utilizado para que haja a variação dos números. */
            }
        }

        private void btnZerar_Click(object sender, EventArgs e)
        {
            lblNumero.Text = "0";
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            Form2 novo = new Form2();
            novo.Show();
            this.Visible = false;
        }

        private void btnTabuada_Click(object sender, EventArgs e)
        {
            Form3 novo = new Form3();
            novo.Show();
            this.Visible = false;
        }
    }
}
