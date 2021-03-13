using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SwitchCase01
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (cbo_opcao.Text)
            {
                case "1 ou 2": lbl_res.Text = "Rodizío as Segundas"; 
                    break;
                case "3 ou 4":
                    lbl_res.Text = "Rodizío as Terças";
                    break;
                case "5 ou 6":
                    lbl_res.Text = "Rodizío as Quartas";
                    break;
                case "7 ou 8":
                    lbl_res.Text = "Rodizío as Quintas";
                    break;
                case "9 ou 0":
                    lbl_res.Text = "Rodizío as extas";
                    break;
            }
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            Form1 novo = new Form1();
            novo.Show();

            this.Visible = false;
        }
    }
}
