
namespace IncluindoAnoscomFor
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
            this.cbo_anos = new System.Windows.Forms.ComboBox();
            this.lbl_anos = new System.Windows.Forms.Label();
            this.btn_prox = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbo_anos
            // 
            this.cbo_anos.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbo_anos.FormattingEnabled = true;
            this.cbo_anos.Location = new System.Drawing.Point(229, 50);
            this.cbo_anos.Name = "cbo_anos";
            this.cbo_anos.Size = new System.Drawing.Size(149, 36);
            this.cbo_anos.TabIndex = 0;
            this.cbo_anos.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lbl_anos
            // 
            this.lbl_anos.AutoSize = true;
            this.lbl_anos.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_anos.Location = new System.Drawing.Point(12, 50);
            this.lbl_anos.Name = "lbl_anos";
            this.lbl_anos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_anos.Size = new System.Drawing.Size(211, 34);
            this.lbl_anos.TabIndex = 1;
            this.lbl_anos.Text = "Selecione um ano:";
            // 
            // btn_prox
            // 
            this.btn_prox.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_prox.Location = new System.Drawing.Point(378, 146);
            this.btn_prox.Name = "btn_prox";
            this.btn_prox.Size = new System.Drawing.Size(43, 44);
            this.btn_prox.TabIndex = 2;
            this.btn_prox.Text = ">";
            this.btn_prox.UseVisualStyleBackColor = true;
            this.btn_prox.Click += new System.EventHandler(this.btn_prox_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 202);
            this.Controls.Add(this.btn_prox);
            this.Controls.Add(this.lbl_anos);
            this.Controls.Add(this.cbo_anos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbo_anos;
        private System.Windows.Forms.Label lbl_anos;
        private System.Windows.Forms.Button btn_prox;
    }
}

