using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Cantina
{
    public partial class Form1 : Form
    {
        string[] produtos = new string[10];
        string[] codigo = new string[10];
        double[] valor = new double[10];
        double soma;

        /*
         *  Declaração de 3 arrays para armazenar 10 produtos.
         *  eseus respectivos códigos e valores.
        */
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            /*
                if (txtCodigo.Text.Length == 5)
                {
                    lstBCaixa.Items.Add(txtCodigo.Text);
                    txtCodigo.Text = "";
                    txtCodigo.Focus();
                }
                inicia com uma condição, se o usuário digitar um código com 5 caracteres (length), esse código é adicionado ao listBox. A propriedade length retorna a quantidade de caracteres. Após o conteúdo ser enviado para o ListBox, o textbox será limpo e o Focus posiciona o cursor para o TextBox para uma nova digitação 
            */
            if (txtCodigo.Text.Length == 3)
            {
                /*
                 * Inicia com uma condição, se o usuário digitar um código
                 * com 3 caracteres (length), esse código é adicionado ao listBox.
                 * A propriedade length retorna a quantidade de caracteres
                */
                int indice = 0;
                for (int prod = 1; prod < codigo.Length; prod++)
                {
                    /*
                     * Faça enquanto o prod for menor ou igual a
                     * qtde de itens do array
                    */
                    if (txtCodigo.Text == codigo[prod])
                        indice = prod;
                }

                    /*  
                     *  Condição, se foi encontrado o produto ele retorna as informações de acordo com o índice
                     *  Caso não encontre aparecerá a mensagem, Produto não encontrado
                    */
                    if (indice == 0)
                        MessageBox.Show("Produto não encontrado", "Aviso");
                    else
                    {
                        lstBCaixa.Items.Add(txtCodigo.Text + " -- " + produtos[indice] + " -- R$ " + valor[indice]);
                        /*
                         * Conteúdo adicionado no ListBox,
                         * concatena (+) as indormações (código/nome/valor)
                        */
                        soma = soma + valor[indice];
                        lblValor.Text = ("R$\t" + soma);
                        string lcl = @"C:\Users\Usuário\Desktop\prjcantina\";
                        string local = lcl + codigo[indice] + ".png";
                        picBImagem.ImageLocation =  local;
                        //  MessageBox.Show(local, "Aviso");
                        txtCodigo.Text = "";
                        txtCodigo.Focus();
                        /*
                         * Localização da imagem que deve ser colocada em uma pasta em C: em uma pasta imagens
                         * O textbox será limpo e o Focus posiciona o cursos para o TextBox para uma nova digitação
                        */
                    }
                }
            
        }
        private void carregarArray()
        /*Criação do Método para ser chamado quando necessário, isso evita repetir várias vezes o mesmo código*/
        {
            codigo[1] = "001";
            codigo[2] = "002";
            codigo[3] = "003";
            codigo[4] = "004";
            codigo[5] = "005";

            produtos[1] = "Pastel";
            produtos[2] = "Coxinha";
            produtos[3] = "Hot_Dog";
            produtos[4] = "Chocolate";
            produtos[5] = "Suco";

            valor[1] = 6.00;
            valor[2] = 5.00;
            valor[3] = 12.00;
            valor[4] = 3.50;
            valor[5] = 8.00;
            /*Códigos, Produtos e Valores ref. os arrays que foram declarados*/
        }

        /*Ao entrar no Form Load será chamado o método*/
        private void Form1_Load(object sender, EventArgs e)
        {
            carregarArray();
            soma = 0;
        }
    }
}
