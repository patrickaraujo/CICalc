using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Splash_Screen
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnTeste_Click(object sender, EventArgs e)
        {
            int[] vetor = new int[4];
            vetor[0] = 7;
            vetor[1] = 3;
            vetor[2] = 5;
            vetor[3] = 1;
            //  int valor = vetor[1];
            System.Array.Sort(vetor);
            for (int index = 0; index < vetor.Length; index++)
            {
                DialogResult dialogo = MessageBox.Show(vetor[index].ToString(), "Array", MessageBoxButtons.OKCancel);
                if (dialogo == DialogResult.Cancel)
                    break;

            }
            /*Declarar e instanciar vetor Atribuição de valores de acordo com cada índice Declara variável "valor" para acessar o vetor System.Array.Sort - Esta classe ordena o vetor Comando for- Percorre o vetor em cada índice. Condição - Para index menor que 4 (de 0 a 3), ele exibe uma msg com o vetor na MessageBox. */
        }

        private void btnVTextos_Click(object sender, EventArgs e)
        {
            string[] semana = new string[7];
            semana[0] = "Domingo";
            semana[1] = "Segunda-Feira";
            semana[2] = "Terça-Feira";
            semana[3] = "Quarta-Feira";
            semana[4] = "Quinta-Feira";
            semana[5] = "Sexta-Feira";
            semana[6] = "Sábado";
            //  string valor = semana[1];
            for (int index = 0; index < semana.Length; index++) {
                DialogResult dialogo = MessageBox.Show(semana[index].ToString(), "Array", MessageBoxButtons.OKCancel);
                if (dialogo == DialogResult.Cancel)
                    break;
            }
            /*Declarar e instanciar vetor Atribuição de valores de acordo com cada índice, Aqui no caso são os dias da semana (string) Declara variável "valor" para acessar o vetor Por se tratar de string não será necessário ordenar Comando for- Percorre o vetor em cada índice. Condição Para index menor que 7 (de 0 a 6), ele exibe uma msg com o vetor na MessageBox, ou seja cada dia da semana. */
        }

        private void btnA2D_Click(object sender, EventArgs e)
        {
            double[,] notas = new double[2, 4];
            notas[0, 0] = 8.0;
            notas[0, 1] = 7.5;
            notas[0, 2] = 9.0;
            notas[0, 3] = 8.5;
            notas[1, 0] = 9.5;
            notas[1, 1] = 8.5;
            notas[1, 2] = 8.0;
            notas[1, 3] = 9.0;

            for (int i = 0; i < notas.Length; i++)
            {
                Boolean saida = false;
                for (int j = 0; j < notas.GetLength(i); j++)
                {
                    DialogResult dialogo = MessageBox.Show(notas[i, j].ToString(), "Array", MessageBoxButtons.OKCancel);
                    if (dialogo == DialogResult.Cancel)
                    {
                        saida = true;
                        break;
                    }
                }
                if (saida)
                    break;
            }
            
            
            /*Declarar e instanciar array, indicando qtde linhas e colunas Atribuição de valores de acordo com cada índice, Exibe na Messagebox a devida nota de acordo com os índices escolhidos. */
        }
    }
}
