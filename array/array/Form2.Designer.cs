
namespace array
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
            this.btn_ant = new System.Windows.Forms.Button();
            this.btn_matriz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_ant
            // 
            this.btn_ant.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_ant.Location = new System.Drawing.Point(218, 153);
            this.btn_ant.Name = "btn_ant";
            this.btn_ant.Size = new System.Drawing.Size(37, 37);
            this.btn_ant.TabIndex = 3;
            this.btn_ant.Text = "<";
            this.btn_ant.UseVisualStyleBackColor = true;
            this.btn_ant.Click += new System.EventHandler(this.btn_ant_Click);
            // 
            // btn_matriz
            // 
            this.btn_matriz.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_matriz.Location = new System.Drawing.Point(70, 90);
            this.btn_matriz.Name = "btn_matriz";
            this.btn_matriz.Size = new System.Drawing.Size(151, 57);
            this.btn_matriz.TabIndex = 4;
            this.btn_matriz.Text = "Matriz Notas";
            this.btn_matriz.UseVisualStyleBackColor = true;
            this.btn_matriz.Click += new System.EventHandler(this.btn_matriz_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 233);
            this.Controls.Add(this.btn_matriz);
            this.Controls.Add(this.btn_ant);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_ant;
        private System.Windows.Forms.Button btn_matriz;
    }
}