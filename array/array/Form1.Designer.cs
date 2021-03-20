
namespace array
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
            this.btn_num = new System.Windows.Forms.Button();
            this.btn_texto = new System.Windows.Forms.Button();
            this.btn_prox = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_num
            // 
            this.btn_num.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_num.Location = new System.Drawing.Point(69, 60);
            this.btn_num.Name = "btn_num";
            this.btn_num.Size = new System.Drawing.Size(110, 63);
            this.btn_num.TabIndex = 0;
            this.btn_num.Text = "Números";
            this.btn_num.UseVisualStyleBackColor = true;
            this.btn_num.Click += new System.EventHandler(this.btn_num_Click);
            // 
            // btn_texto
            // 
            this.btn_texto.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_texto.Location = new System.Drawing.Point(69, 143);
            this.btn_texto.Name = "btn_texto";
            this.btn_texto.Size = new System.Drawing.Size(110, 63);
            this.btn_texto.TabIndex = 1;
            this.btn_texto.Text = "Texto";
            this.btn_texto.UseVisualStyleBackColor = true;
            this.btn_texto.Click += new System.EventHandler(this.btn_texto_Click);
            // 
            // btn_prox
            // 
            this.btn_prox.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_prox.Location = new System.Drawing.Point(181, 212);
            this.btn_prox.Name = "btn_prox";
            this.btn_prox.Size = new System.Drawing.Size(37, 37);
            this.btn_prox.TabIndex = 2;
            this.btn_prox.Text = ">";
            this.btn_prox.UseVisualStyleBackColor = true;
            this.btn_prox.Click += new System.EventHandler(this.btn_prox_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 261);
            this.Controls.Add(this.btn_prox);
            this.Controls.Add(this.btn_texto);
            this.Controls.Add(this.btn_num);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_num;
        private System.Windows.Forms.Button btn_texto;
        private System.Windows.Forms.Button btn_prox;
    }
}

