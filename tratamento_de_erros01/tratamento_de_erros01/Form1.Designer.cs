
namespace tratamento_de_erros01
{
    partial class Form1
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
            this.lbl_igual = new System.Windows.Forms.Label();
            this.lbl_add = new System.Windows.Forms.Label();
            this.lbl_soma = new System.Windows.Forms.Label();
            this.txt_num2 = new System.Windows.Forms.TextBox();
            this.txt_num1 = new System.Windows.Forms.TextBox();
            this.txt_res = new System.Windows.Forms.TextBox();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_igual
            // 
            this.lbl_igual.AutoSize = true;
            this.lbl_igual.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_igual.Location = new System.Drawing.Point(221, 111);
            this.lbl_igual.Name = "lbl_igual";
            this.lbl_igual.Size = new System.Drawing.Size(24, 24);
            this.lbl_igual.TabIndex = 0;
            this.lbl_igual.Text = "=";
            this.lbl_igual.Click += new System.EventHandler(this.lbl_igual_Click);
            // 
            // lbl_add
            // 
            this.lbl_add.AutoSize = true;
            this.lbl_add.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_add.Location = new System.Drawing.Point(110, 111);
            this.lbl_add.Name = "lbl_add";
            this.lbl_add.Size = new System.Drawing.Size(24, 24);
            this.lbl_add.TabIndex = 1;
            this.lbl_add.Text = "+";
            // 
            // lbl_soma
            // 
            this.lbl_soma.AutoSize = true;
            this.lbl_soma.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_soma.Location = new System.Drawing.Point(83, 22);
            this.lbl_soma.Name = "lbl_soma";
            this.lbl_soma.Size = new System.Drawing.Size(125, 57);
            this.lbl_soma.TabIndex = 2;
            this.lbl_soma.Text = "Soma";
            this.lbl_soma.Click += new System.EventHandler(this.label3_Click);
            // 
            // txt_num2
            // 
            this.txt_num2.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_num2.ForeColor = System.Drawing.Color.Maroon;
            this.txt_num2.Location = new System.Drawing.Point(149, 108);
            this.txt_num2.Name = "txt_num2";
            this.txt_num2.Size = new System.Drawing.Size(51, 30);
            this.txt_num2.TabIndex = 3;
            // 
            // txt_num1
            // 
            this.txt_num1.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_num1.ForeColor = System.Drawing.Color.Maroon;
            this.txt_num1.Location = new System.Drawing.Point(42, 108);
            this.txt_num1.Name = "txt_num1";
            this.txt_num1.Size = new System.Drawing.Size(51, 30);
            this.txt_num1.TabIndex = 4;
            // 
            // txt_res
            // 
            this.txt_res.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_res.ForeColor = System.Drawing.Color.Maroon;
            this.txt_res.Location = new System.Drawing.Point(251, 108);
            this.txt_res.Name = "txt_res";
            this.txt_res.Size = new System.Drawing.Size(51, 30);
            this.txt_res.TabIndex = 5;
            // 
            // btn_calcular
            // 
            this.btn_calcular.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_calcular.Location = new System.Drawing.Point(110, 175);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(107, 34);
            this.btn_calcular.TabIndex = 6;
            this.btn_calcular.Text = "Calcular";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 237);
            this.Controls.Add(this.btn_calcular);
            this.Controls.Add(this.txt_res);
            this.Controls.Add(this.txt_num1);
            this.Controls.Add(this.txt_num2);
            this.Controls.Add(this.lbl_soma);
            this.Controls.Add(this.lbl_add);
            this.Controls.Add(this.lbl_igual);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_igual;
        private System.Windows.Forms.Label lbl_add;
        private System.Windows.Forms.Label lbl_soma;
        private System.Windows.Forms.TextBox txt_num2;
        private System.Windows.Forms.TextBox txt_num1;
        private System.Windows.Forms.TextBox txt_res;
        private System.Windows.Forms.Button btn_calcular;
    }
}

