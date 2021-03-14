
namespace Tabuada01
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
            this.txt_tabuada = new System.Windows.Forms.Label();
            this.txt_num = new System.Windows.Forms.Label();
            this.txtbox_num = new System.Windows.Forms.TextBox();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.lst_tabuada = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txt_tabuada
            // 
            this.txt_tabuada.AutoSize = true;
            this.txt_tabuada.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_tabuada.Location = new System.Drawing.Point(79, 30);
            this.txt_tabuada.Name = "txt_tabuada";
            this.txt_tabuada.Size = new System.Drawing.Size(195, 57);
            this.txt_tabuada.TabIndex = 0;
            this.txt_tabuada.Text = "TABUADA";
            // 
            // txt_num
            // 
            this.txt_num.AutoSize = true;
            this.txt_num.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_num.Location = new System.Drawing.Point(12, 100);
            this.txt_num.Name = "txt_num";
            this.txt_num.Size = new System.Drawing.Size(202, 32);
            this.txt_num.TabIndex = 1;
            this.txt_num.Text = "Digite um número:";
            this.txt_num.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtbox_num
            // 
            this.txtbox_num.Location = new System.Drawing.Point(220, 100);
            this.txtbox_num.Name = "txtbox_num";
            this.txtbox_num.Size = new System.Drawing.Size(113, 37);
            this.txtbox_num.TabIndex = 2;
            // 
            // btn_limpar
            // 
            this.btn_limpar.Location = new System.Drawing.Point(220, 208);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(113, 44);
            this.btn_limpar.TabIndex = 3;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = true;
            this.btn_limpar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_calcular
            // 
            this.btn_calcular.Location = new System.Drawing.Point(220, 158);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(113, 44);
            this.btn_calcular.TabIndex = 4;
            this.btn_calcular.Text = "Calcular";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // btn_sair
            // 
            this.btn_sair.Location = new System.Drawing.Point(220, 258);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(113, 44);
            this.btn_sair.TabIndex = 5;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = true;
            // 
            // lst_tabuada
            // 
            this.lst_tabuada.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lst_tabuada.FormattingEnabled = true;
            this.lst_tabuada.ItemHeight = 23;
            this.lst_tabuada.Location = new System.Drawing.Point(12, 135);
            this.lst_tabuada.Name = "lst_tabuada";
            this.lst_tabuada.Size = new System.Drawing.Size(202, 188);
            this.lst_tabuada.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 358);
            this.Controls.Add(this.lst_tabuada);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.btn_calcular);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.txtbox_num);
            this.Controls.Add(this.txt_num);
            this.Controls.Add(this.txt_tabuada);
            this.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txt_tabuada;
        private System.Windows.Forms.Label txt_num;
        private System.Windows.Forms.TextBox txtbox_num;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.ListBox lst_tabuada;
    }
}

