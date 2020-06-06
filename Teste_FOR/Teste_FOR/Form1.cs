using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teste_FOR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTeste_Click(object sender, EventArgs e)
        {
            DialogResult dialogo;
            for (int i = 0; i < 50; i++)
            {
                dialogo = MessageBox.Show("O valor do contador é:\t" + i, "Aviso", MessageBoxButtons.OKCancel) ;
                if (dialogo == DialogResult.Cancel)
                    break;
                //Console.WriteLine("O valor do contador é:\t" + i);
            }
        }
    }
}
