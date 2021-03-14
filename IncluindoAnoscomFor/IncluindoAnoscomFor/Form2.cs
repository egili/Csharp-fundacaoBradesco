using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IncluindoAnoscomFor
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_ant_Click(object sender, EventArgs e)
        {
            Form1 novo = new Form1();
            novo.Show();
            this.Visible = false;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            int cont;
            cont = 2021;

            while (cont >= 1950)
            {
                cbo_anos2.Items.Add(cont);
                cont--;
            }
        }
    }
}
