using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculo_imc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            double peso, altura, imc;
            peso = Convert.ToDouble(txtBPeso.Text);
            altura = Convert.ToDouble(txtBAltura.Text);
            imc = peso / (Math.Pow(altura, 2));
            lblIMC.Text = imc.ToString();
            if (imc < 18.49)
                MessageBox.Show("Você está abaixo do Peso\n\nIMC:\t"+imc+ "\nPeso:\t" + peso + "\tkg\nAltura:\t" + altura + "\tm.", "Cálculo de IMC:\t SITUAÇÃO",
               MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (imc < 24.99)
                MessageBox.Show("Você está com Peso dentro da Normalidade\n\nIMC:\t" + imc + "\nPeso:\t" + peso + "\tkg\nAltura:\t" + altura+"\tm.", "Cálculo de IMC:\t SITUAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (imc < 29.99)
                MessageBox.Show("Você está acima do Peso\n\nIMC:\t" + imc + "\nPeso:\t" + peso + "\tkg\nAltura:\t" + altura + "\tm.", "Cálculo de IMC:\t SITUAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (imc < 34.99)
                MessageBox.Show("Você está com Obesidade Grau I\n\nIMC:\t" + imc + "\nPeso:\t" + peso + "\tkg\nAltura:\t" + altura + "\tm.", "Cálculo de IMC:\t Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            else if (imc < 39.99)
                MessageBox.Show("Você está com Obesidade Grau II (severa)\n\nIMC:\t" + imc + "\nPeso:\t" + peso + "\tkg\nAltura:\t" + altura + "\tm.", "Cálculo de IMC:\t Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            else
                MessageBox.Show("Você está com grau de obesidade Grau III (mórbida)\n\nIMC:\t" + imc + "\nPeso:\t" + peso + "\tkg\nAltura:\t" + altura + "\tm.", "Cálculo de IMC:\t Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Stop);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtBPeso.Text = "";
            txtBAltura.Text = "";
            lblIMC.Text = "Vazio";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
