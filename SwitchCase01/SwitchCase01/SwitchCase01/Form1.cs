using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwitchCase01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lbl_titulo_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbo_semana.Text)
            {
                case "Domingo":
                    MessageBox.Show("aff, amanhã é segunda de novo", "DOM", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                    break;

                case "Segunda":
                    MessageBox.Show("enfim, segunda, desejo forças para você", "SEG", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    break;

                case "Terça-Feira":
                    MessageBox.Show("parece que falta tanto, vai ver é porque segunda foi ontem", "TER", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case "Quarta-Feira":
                    MessageBox.Show("até que enfim a metade", "QUA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case "Quinta-Feira":
                    MessageBox.Show("aguenta só mais um dia", "QUI", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                    break;

                case "Sexta-Feira":
                    MessageBox.Show("até que enfim é sexta né", "SEX", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    break;

                case "Sábado":
                    MessageBox.Show("o merecido descanso", "SAB", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
            }
        }

        private void btn_prox_Click(object sender, EventArgs e)
        {
            Form2 novoForm = new Form2(); // instanciar form2 como obj da classe
            novoForm.Show(); // abrir o form1

            this.Visible = false; // fecha o form1
        }
    }
}
