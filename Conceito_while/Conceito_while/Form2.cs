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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            int numero = 1; while (numero <= 10)
            {
                listBox1.Items.Add(numero);
                numero = numero + 1;
                /*Declaração da variável numero do tipo inteiro, a variável foi inicializada com o numero 1. "Enquanto" o numero for menor ou igual 5 o listBox será preenchido expressão= numero+ numero1 é o incremento. */
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            Form1 novo = new Form1();
            novo.Show();
            this.Visible = false;
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            Form3 novo = new Form3();
            novo.Show();
            this.Visible = false;
        }
    }
}
