using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace array
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btn_ant_Click(object sender, EventArgs e)
        {
            Form1 novo = new Form1();
            novo.Show();

            this.Visible = false;
        }

        private void btn_matriz_Click(object sender, EventArgs e)
        {
            double[,] notas = new double[2, 4];

            notas[0, 1] = 7.0;
            notas[0, 2] = 8.0;
            notas[0, 3] = 10.0;
            notas[1, 1] = 5.0;
            notas[1, 2] = 6.0;
            notas[1, 3] = 9.0;

            MessageBox.Show(notas[0,1].ToString(), "Array");
        }
    }
}
