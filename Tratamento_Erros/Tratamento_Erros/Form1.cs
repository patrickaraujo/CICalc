﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tratamento_Erros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            try
            {
                int num1, num2, resultado;
                num1 = int.Parse(txtNum1.Text);
                num2 = int.Parse(txtNum2.Text);
                resultado = num1 + num2;
                lblResult.Text = resultado.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Digite apenas valores numéricos", "Catch");
            }
            finally
            {
                MessageBox.Show("Aperte OK para sair", "Finally");
                Close();
            }

        }
    }
}
