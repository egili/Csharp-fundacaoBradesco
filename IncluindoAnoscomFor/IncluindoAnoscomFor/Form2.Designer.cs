
namespace IncluindoAnoscomFor
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_anos2 = new System.Windows.Forms.Label();
            this.cbo_anos2 = new System.Windows.Forms.ComboBox();
            this.btn_ant = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_anos2
            // 
            this.lbl_anos2.AutoSize = true;
            this.lbl_anos2.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_anos2.Location = new System.Drawing.Point(12, 69);
            this.lbl_anos2.Name = "lbl_anos2";
            this.lbl_anos2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_anos2.Size = new System.Drawing.Size(211, 34);
            this.lbl_anos2.TabIndex = 3;
            this.lbl_anos2.Text = "Selecione um ano:";
            // 
            // cbo_anos2
            // 
            this.cbo_anos2.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbo_anos2.FormattingEnabled = true;
            this.cbo_anos2.Location = new System.Drawing.Point(229, 69);
            this.cbo_anos2.Name = "cbo_anos2";
            this.cbo_anos2.Size = new System.Drawing.Size(149, 36);
            this.cbo_anos2.TabIndex = 4;
            // 
            // btn_ant
            // 
            this.btn_ant.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_ant.Location = new System.Drawing.Point(12, 149);
            this.btn_ant.Name = "btn_ant";
            this.btn_ant.Size = new System.Drawing.Size(43, 44);
            this.btn_ant.TabIndex = 5;
            this.btn_ant.Text = "<";
            this.btn_ant.UseVisualStyleBackColor = true;
            this.btn_ant.Click += new System.EventHandler(this.btn_ant_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 221);
            this.Controls.Add(this.btn_ant);
            this.Controls.Add(this.cbo_anos2);
            this.Controls.Add(this.lbl_anos2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_anos2;
        private System.Windows.Forms.ComboBox cbo_anos2;
        private System.Windows.Forms.Button btn_ant;
    }
}