﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tabuada01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            int num, res, i;

            i = 1;
            num = int.Parse(txtbox_num.Text);

            while (i <= 10)
            {
                res = i * num;
                lst_tabuada.Items.Add(String.Concat(num, " * ", i, " = ", res));
                i += 1;
            }

        }
    }
}
