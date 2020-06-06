using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Condicao_if
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bntVerId_Click(object sender, EventArgs e)
        {
            int idade = Convert.ToInt32(txtBIdade.Text);
            if(idade < 18)
                MessageBox.Show("Menor de idade", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            else
                MessageBox.Show("Maior de idade", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
