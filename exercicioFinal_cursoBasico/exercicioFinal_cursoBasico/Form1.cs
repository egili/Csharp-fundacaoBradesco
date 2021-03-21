using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicioFinal_cursoBasico
{
    public partial class Form1 : Form

    {
        string[] produtos = new string[6];
        string[] codigo = new string[6];
        double[] valor = new double[6];
        double soma;

        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txt_codigo_TextChanged(object sender, EventArgs e)
        {
            if (txt_codigo.Text.Length == 3)
            {
                int indice = 0;
                for (int prod = 1; prod < codigo.Length; prod++) 
                {
                    if (txt_codigo.Text == codigo[prod])
                    {
                        indice = prod;
                    }
                }
                if (indice == 0)
                {
                    MessageBox.Show("Produto não encontrado");
                }
                else
                {
                    lst_caixa.Items.Add(txt_codigo.Text + " - - " + produtos[indice] + " -- R$ " + valor[indice]);
                    //adiciona no listbox, concatenando cod/num/valor

                    soma = soma + valor[indice];
                    lbl_total.Text = ("Valor Total R$ " + soma);

                    pic_imagem.ImageLocation = "c:/imagens/" + codigo[indice] +".jpg";
                    txt_codigo.Text = "";
                    txt_codigo.Focus();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            carregarArray();
            soma = 0;
        }

        private void carregarArray()
        {
            codigo[1] = "001";
            codigo[2] = "002";
            codigo[3] = "003";
            codigo[4] = "004";
            codigo[5] = "005";

            produtos[1] = "Assado";
            produtos[2] = "Frito";
            produtos[3] = "Refrigerante";
            produtos[4] = "Suco";
            produtos[5] = "Água de Coco";

            valor[1] = 6.00;
            valor[2] = 5.50;
            valor[3] = 4.50;
            valor[4] = 9.50;
            valor[5] = 5.50;
        }
    }
}
