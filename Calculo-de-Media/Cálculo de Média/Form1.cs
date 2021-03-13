using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cálculo_de_Média
{
    public partial class frm_media : Form
    {
        public frm_media()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txt_res_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            double n1, n2, n3, media;

            n1 = Convert.ToDouble(txt_num1.Text);
            n2 = Convert.ToDouble(txt_num2.Text);
            n3 = Convert.ToDouble(txt_num3.Text);

            media = (n1 + n2 + n3) / 3;
            txt_res.Text = media.ToString();
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            txt_num1.Text = "";
            txt_num2.Text = "";
            txt_num3.Text = "";
            txt_res.Text = "";
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
