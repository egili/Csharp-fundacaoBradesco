using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tratamento_de_erros01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lbl_igual_Click(object sender, EventArgs e)
        {

        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            int num1, num2, res;
            try
            {
                num1 = int.Parse(txt_num1.Text);
                num2 = int.Parse(txt_num2.Text);
                res = num1 + num2;
                txt_res.Text = res.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("apenas números", "catch");
            }
        }
    }
}
