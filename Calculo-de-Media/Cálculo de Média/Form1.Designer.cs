
namespace Cálculo_de_Média
{
    partial class frm_media
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_calcular = new System.Windows.Forms.Button();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.lbl_num2 = new System.Windows.Forms.Label();
            this.lbl_num1 = new System.Windows.Forms.Label();
            this.lbl_num3 = new System.Windows.Forms.Label();
            this.lbl_media = new System.Windows.Forms.Label();
            this.txt_num1 = new System.Windows.Forms.TextBox();
            this.txt_num3 = new System.Windows.Forms.TextBox();
            this.txt_num2 = new System.Windows.Forms.TextBox();
            this.txt_res = new System.Windows.Forms.TextBox();
            this.btn_sair = new System.Windows.Forms.Button();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_calcular
            // 
            this.btn_calcular.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_calcular.Location = new System.Drawing.Point(311, 102);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(139, 40);
            this.btn_calcular.TabIndex = 0;
            this.btn_calcular.Text = "Calcular";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_titulo.Location = new System.Drawing.Point(91, 32);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(359, 55);
            this.lbl_titulo.TabIndex = 1;
            this.lbl_titulo.Text = "Cálculo de Média";
            // 
            // lbl_num2
            // 
            this.lbl_num2.AutoSize = true;
            this.lbl_num2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_num2.Location = new System.Drawing.Point(53, 161);
            this.lbl_num2.Name = "lbl_num2";
            this.lbl_num2.Size = new System.Drawing.Size(50, 19);
            this.lbl_num2.TabIndex = 2;
            this.lbl_num2.Text = "Num2:";
            this.lbl_num2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbl_num1
            // 
            this.lbl_num1.AutoSize = true;
            this.lbl_num1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_num1.Location = new System.Drawing.Point(53, 114);
            this.lbl_num1.Name = "lbl_num1";
            this.lbl_num1.Size = new System.Drawing.Size(50, 19);
            this.lbl_num1.TabIndex = 3;
            this.lbl_num1.Text = "Num1:";
            // 
            // lbl_num3
            // 
            this.lbl_num3.AutoSize = true;
            this.lbl_num3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_num3.Location = new System.Drawing.Point(53, 211);
            this.lbl_num3.Name = "lbl_num3";
            this.lbl_num3.Size = new System.Drawing.Size(50, 19);
            this.lbl_num3.TabIndex = 4;
            this.lbl_num3.Text = "Num3:";
            // 
            // lbl_media
            // 
            this.lbl_media.AutoSize = true;
            this.lbl_media.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_media.Location = new System.Drawing.Point(47, 272);
            this.lbl_media.Name = "lbl_media";
            this.lbl_media.Size = new System.Drawing.Size(89, 31);
            this.lbl_media.TabIndex = 5;
            this.lbl_media.Text = "Média:";
            // 
            // txt_num1
            // 
            this.txt_num1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_num1.Location = new System.Drawing.Point(112, 114);
            this.txt_num1.Name = "txt_num1";
            this.txt_num1.Size = new System.Drawing.Size(186, 22);
            this.txt_num1.TabIndex = 6;
            this.txt_num1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_num3
            // 
            this.txt_num3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_num3.Location = new System.Drawing.Point(112, 211);
            this.txt_num3.Name = "txt_num3";
            this.txt_num3.Size = new System.Drawing.Size(186, 22);
            this.txt_num3.TabIndex = 7;
            this.txt_num3.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txt_num2
            // 
            this.txt_num2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_num2.Location = new System.Drawing.Point(112, 161);
            this.txt_num2.Name = "txt_num2";
            this.txt_num2.Size = new System.Drawing.Size(186, 22);
            this.txt_num2.TabIndex = 8;
            this.txt_num2.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txt_res
            // 
            this.txt_res.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_res.ForeColor = System.Drawing.Color.DarkRed;
            this.txt_res.Location = new System.Drawing.Point(142, 272);
            this.txt_res.Name = "txt_res";
            this.txt_res.Size = new System.Drawing.Size(156, 29);
            this.txt_res.TabIndex = 9;
            this.txt_res.TextChanged += new System.EventHandler(this.txt_res_TextChanged);
            // 
            // btn_sair
            // 
            this.btn_sair.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_sair.Location = new System.Drawing.Point(311, 199);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(139, 40);
            this.btn_sair.TabIndex = 10;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // btn_limpar
            // 
            this.btn_limpar.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_limpar.Location = new System.Drawing.Point(311, 149);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(139, 40);
            this.btn_limpar.TabIndex = 11;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = true;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // frm_media
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 348);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.txt_res);
            this.Controls.Add(this.txt_num2);
            this.Controls.Add(this.txt_num3);
            this.Controls.Add(this.txt_num1);
            this.Controls.Add(this.lbl_media);
            this.Controls.Add(this.lbl_num3);
            this.Controls.Add(this.lbl_num1);
            this.Controls.Add(this.lbl_num2);
            this.Controls.Add(this.lbl_titulo);
            this.Controls.Add(this.btn_calcular);
            this.Name = "frm_media";
            this.Text = "Média";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Label lbl_num2;
        private System.Windows.Forms.Label lbl_num1;
        private System.Windows.Forms.Label lbl_num3;
        private System.Windows.Forms.Label lbl_media;
        private System.Windows.Forms.TextBox txt_num1;
        private System.Windows.Forms.TextBox txt_num3;
        private System.Windows.Forms.TextBox txt_num2;
        private System.Windows.Forms.TextBox txt_res;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Button btn_limpar;
    }
}

