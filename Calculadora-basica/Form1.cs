using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora___Fundação_bradesco
{
    public partial class frm_operacoes : Form
    {
        public frm_operacoes()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double n1, n2, res;

            n1 = Convert.ToDouble(txt_num1.Text);
            n2 = Convert.ToDouble(txt_num2.Text);

            res = n1 / n2;

            txt_resultado.Text = res.ToString();
        }

        private void btn_somar_Click(object sender, EventArgs e)
        {
            double n1, n2, res;

            n1 = Convert.ToDouble(txt_num1.Text);
            n2 = Convert.ToDouble(txt_num2.Text);

            res = n1 + n2;

            txt_resultado.Text = res.ToString();
        }

        private void btn_multiplicar_Click(object sender, EventArgs e)
        {
            double n1, n2, res;

            n1 = Convert.ToDouble(txt_num1.Text);
            n2 = Convert.ToDouble(txt_num2.Text);

            res = n1 * n2;

            txt_resultado.Text = res.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_titulo_Click(object sender, EventArgs e)
        {

        }

        private void btn_subtrair_Click(object sender, EventArgs e)
        {
            double n1, n2, res;

            n1 = Convert.ToDouble(txt_num1.Text);
            n2 = Convert.ToDouble(txt_num2.Text);

            res = n1 - n2;

            txt_resultado.Text = res.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt_num1.Text = "";
            txt_num2.Text = "";
            txt_resultado.Text = "";
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
