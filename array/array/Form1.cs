using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace array
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_num_Click(object sender, EventArgs e)
        {
            int[] num = {0,1,2,3,4,5};

            int valor = num[1];
            System.Array.Sort(num);

            for (int index = 0; index <  6; index++) 
            MessageBox.Show(num[index].ToString(), "Array");
        }

        private void btn_texto_Click(object sender, EventArgs e)
        {
            string[] semana = {"Domingo","Segunda","Terça","Quarta",
                                            "Quinta","Sexta","Sábado"};
            string valor = semana[1];
            for (int index = 0; index < 7; index++)
                MessageBox.Show(semana[index], "Array");
        }

        private void btn_prox_Click(object sender, EventArgs e)
        {
            Form2 novo = new Form2();
            novo.Show();

            this.Visible = false;
        }
    }
}
