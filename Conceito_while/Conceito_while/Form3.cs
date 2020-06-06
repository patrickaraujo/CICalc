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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            Form2 novo = new Form2();
            novo.Show();
            this.Visible = false;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int numero, resultado, i;
            i = 1;
            if (txtNumero.Text != ""){
                numero = int.Parse(txtNumero.Text);
                while (i <= 10)
                {
                    resultado = i * numero;
                    lstTabuada.Items.Add(String.Concat(numero, " * ", i, " = ", resultado));
                    i = i + 1;
                }
            }
            /*Declaração das variáveis do tipo inteiro Conversão para int Condição, enquanto o i for menor ou igual a 10 variável resultado realiza o cálculo de i multiplicado pelo número digitado. ListBox adiciona o item e concatena (número * i = resultado) incremento */
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 novo = new Form1();
            novo.Show();
            this.Visible = false;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNumero.Text = "";
            lstTabuada.Items.Clear();
        }
    }
}
