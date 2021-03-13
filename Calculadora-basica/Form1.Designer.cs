namespace Calculadora___Fundação_bradesco
{
    partial class frm_operacoes
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.lbl_segundo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_primeiro = new System.Windows.Forms.Label();
            this.btn_somar = new System.Windows.Forms.Button();
            this.txt_num1 = new System.Windows.Forms.TextBox();
            this.txt_resultado = new System.Windows.Forms.TextBox();
            this.txt_num2 = new System.Windows.Forms.TextBox();
            this.btn_dividir = new System.Windows.Forms.Button();
            this.btn_multiplicar = new System.Windows.Forms.Button();
            this.btn_subtrair = new System.Windows.Forms.Button();
            this.txt_limpar = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.BackColor = System.Drawing.Color.Black;
            this.lbl_titulo.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_titulo.Location = new System.Drawing.Point(167, 48);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(216, 31);
            this.lbl_titulo.TabIndex = 0;
            this.lbl_titulo.Text = "Operações Básicas";
            this.lbl_titulo.Click += new System.EventHandler(this.lbl_titulo_Click);
            // 
            // lbl_segundo
            // 
            this.lbl_segundo.AutoSize = true;
            this.lbl_segundo.BackColor = System.Drawing.Color.Black;
            this.lbl_segundo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_segundo.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_segundo.Location = new System.Drawing.Point(114, 165);
            this.lbl_segundo.Name = "lbl_segundo";
            this.lbl_segundo.Size = new System.Drawing.Size(145, 21);
            this.lbl_segundo.TabIndex = 1;
            this.lbl_segundo.Text = "Segundo Número:";
            this.lbl_segundo.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(114, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Resultado:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbl_primeiro
            // 
            this.lbl_primeiro.AutoSize = true;
            this.lbl_primeiro.BackColor = System.Drawing.Color.Black;
            this.lbl_primeiro.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_primeiro.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_primeiro.Location = new System.Drawing.Point(114, 133);
            this.lbl_primeiro.Name = "lbl_primeiro";
            this.lbl_primeiro.Size = new System.Drawing.Size(142, 21);
            this.lbl_primeiro.TabIndex = 3;
            this.lbl_primeiro.Text = "Primeiro Número:";
            this.lbl_primeiro.Click += new System.EventHandler(this.label4_Click);
            // 
            // btn_somar
            // 
            this.btn_somar.BackColor = System.Drawing.Color.Black;
            this.btn_somar.FlatAppearance.BorderSize = 0;
            this.btn_somar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.btn_somar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed;
            this.btn_somar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_somar.ForeColor = System.Drawing.Color.Crimson;
            this.btn_somar.Location = new System.Drawing.Point(116, 214);
            this.btn_somar.Name = "btn_somar";
            this.btn_somar.Size = new System.Drawing.Size(51, 41);
            this.btn_somar.TabIndex = 4;
            this.btn_somar.Text = "+";
            this.btn_somar.UseVisualStyleBackColor = false;
            this.btn_somar.Click += new System.EventHandler(this.btn_somar_Click);
            // 
            // txt_num1
            // 
            this.txt_num1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_num1.ForeColor = System.Drawing.Color.Red;
            this.txt_num1.Location = new System.Drawing.Point(265, 128);
            this.txt_num1.Name = "txt_num1";
            this.txt_num1.Size = new System.Drawing.Size(168, 26);
            this.txt_num1.TabIndex = 5;
            this.txt_num1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_resultado
            // 
            this.txt_resultado.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_resultado.ForeColor = System.Drawing.Color.Red;
            this.txt_resultado.Location = new System.Drawing.Point(220, 266);
            this.txt_resultado.Name = "txt_resultado";
            this.txt_resultado.Size = new System.Drawing.Size(118, 26);
            this.txt_resultado.TabIndex = 6;
            this.txt_resultado.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txt_num2
            // 
            this.txt_num2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_num2.ForeColor = System.Drawing.Color.Red;
            this.txt_num2.Location = new System.Drawing.Point(265, 160);
            this.txt_num2.Name = "txt_num2";
            this.txt_num2.Size = new System.Drawing.Size(168, 26);
            this.txt_num2.TabIndex = 7;
            this.txt_num2.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // btn_dividir
            // 
            this.btn_dividir.BackColor = System.Drawing.Color.Black;
            this.btn_dividir.FlatAppearance.BorderSize = 0;
            this.btn_dividir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.btn_dividir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed;
            this.btn_dividir.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dividir.ForeColor = System.Drawing.Color.Crimson;
            this.btn_dividir.Location = new System.Drawing.Point(230, 214);
            this.btn_dividir.Name = "btn_dividir";
            this.btn_dividir.Size = new System.Drawing.Size(51, 41);
            this.btn_dividir.TabIndex = 8;
            this.btn_dividir.Text = "/";
            this.btn_dividir.UseVisualStyleBackColor = false;
            this.btn_dividir.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_multiplicar
            // 
            this.btn_multiplicar.BackColor = System.Drawing.Color.Black;
            this.btn_multiplicar.FlatAppearance.BorderSize = 0;
            this.btn_multiplicar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.btn_multiplicar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed;
            this.btn_multiplicar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_multiplicar.ForeColor = System.Drawing.Color.Crimson;
            this.btn_multiplicar.Location = new System.Drawing.Point(287, 214);
            this.btn_multiplicar.Name = "btn_multiplicar";
            this.btn_multiplicar.Size = new System.Drawing.Size(51, 41);
            this.btn_multiplicar.TabIndex = 9;
            this.btn_multiplicar.Text = "*";
            this.btn_multiplicar.UseVisualStyleBackColor = false;
            this.btn_multiplicar.Click += new System.EventHandler(this.btn_multiplicar_Click);
            // 
            // btn_subtrair
            // 
            this.btn_subtrair.BackColor = System.Drawing.Color.Black;
            this.btn_subtrair.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_subtrair.FlatAppearance.BorderSize = 0;
            this.btn_subtrair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.btn_subtrair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed;
            this.btn_subtrair.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_subtrair.ForeColor = System.Drawing.Color.Crimson;
            this.btn_subtrair.Location = new System.Drawing.Point(173, 214);
            this.btn_subtrair.Name = "btn_subtrair";
            this.btn_subtrair.Size = new System.Drawing.Size(51, 41);
            this.btn_subtrair.TabIndex = 10;
            this.btn_subtrair.Text = "-";
            this.btn_subtrair.UseVisualStyleBackColor = false;
            this.btn_subtrair.Click += new System.EventHandler(this.btn_subtrair_Click);
            // 
            // txt_limpar
            // 
            this.txt_limpar.BackColor = System.Drawing.Color.Black;
            this.txt_limpar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txt_limpar.FlatAppearance.BorderSize = 0;
            this.txt_limpar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.txt_limpar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed;
            this.txt_limpar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_limpar.ForeColor = System.Drawing.Color.Crimson;
            this.txt_limpar.Location = new System.Drawing.Point(344, 214);
            this.txt_limpar.Name = "txt_limpar";
            this.txt_limpar.Size = new System.Drawing.Size(98, 41);
            this.txt_limpar.TabIndex = 11;
            this.txt_limpar.Text = "LIMPAR";
            this.txt_limpar.UseVisualStyleBackColor = false;
            this.txt_limpar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_sair
            // 
            this.btn_sair.BackColor = System.Drawing.Color.Black;
            this.btn_sair.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_sair.FlatAppearance.BorderSize = 0;
            this.btn_sair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.btn_sair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed;
            this.btn_sair.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sair.ForeColor = System.Drawing.Color.Crimson;
            this.btn_sair.Location = new System.Drawing.Point(344, 261);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(98, 41);
            this.btn_sair.TabIndex = 12;
            this.btn_sair.Text = "SAIR";
            this.btn_sair.UseVisualStyleBackColor = false;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // frm_operacoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = global::Calculadora___Fundação_bradesco.Properties.Resources.numbers;
            this.ClientSize = new System.Drawing.Size(522, 409);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.txt_limpar);
            this.Controls.Add(this.btn_subtrair);
            this.Controls.Add(this.btn_multiplicar);
            this.Controls.Add(this.btn_dividir);
            this.Controls.Add(this.txt_num2);
            this.Controls.Add(this.txt_resultado);
            this.Controls.Add(this.txt_num1);
            this.Controls.Add(this.btn_somar);
            this.Controls.Add(this.lbl_primeiro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_segundo);
            this.Controls.Add(this.lbl_titulo);
            this.Name = "frm_operacoes";
            this.Text = "Operações Básicas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Label lbl_segundo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_primeiro;
        private System.Windows.Forms.Button btn_somar;
        private System.Windows.Forms.TextBox txt_num1;
        private System.Windows.Forms.TextBox txt_resultado;
        private System.Windows.Forms.TextBox txt_num2;
        private System.Windows.Forms.Button btn_dividir;
        private System.Windows.Forms.Button btn_multiplicar;
        private System.Windows.Forms.Button btn_subtrair;
        private System.Windows.Forms.Button txt_limpar;
        private System.Windows.Forms.Button btn_sair;
    }
}

