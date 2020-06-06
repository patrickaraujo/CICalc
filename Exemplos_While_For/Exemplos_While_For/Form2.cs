using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exemplos_While_For
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string currentYear = DateTime.Now.Year.ToString();
            int anoAtual = Convert.ToInt32(currentYear);
            while(anoAtual >= 1950)
            {
                cboAno.Items.Add(anoAtual);
                anoAtual--;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 novo = new Form1();
            novo.Show();
            this.Visible = false;
        }

    }
}
