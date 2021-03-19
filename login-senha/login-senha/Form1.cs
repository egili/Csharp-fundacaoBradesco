using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login_senha
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            string user, senha;

            user = txt_user.Text;
            senha = txt_senha.Text;

            while (!(user == "admin" && senha == "admin"))
            {
                MessageBox.Show("Senha Incorreta","atenção", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                
            }

                Form2 novo = new Form2();
                novo.Show();
                this.Visible = false;
           
        }
    }
}
