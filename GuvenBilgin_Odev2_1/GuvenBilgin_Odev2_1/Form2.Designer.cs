namespace GuvenBilgin_Odev2_1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtTahmin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDene = new System.Windows.Forms.Button();
            this.txtHak = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tahminini Gir :";
            // 
            // txtTahmin
            // 
            this.txtTahmin.Location = new System.Drawing.Point(94, 13);
            this.txtTahmin.Name = "txtTahmin";
            this.txtTahmin.Size = new System.Drawing.Size(56, 20);
            this.txtTahmin.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(246, -2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kalan Hakkınız :";
            // 
            // btnDene
            // 
            this.btnDene.Location = new System.Drawing.Point(94, 39);
            this.btnDene.Name = "btnDene";
            this.btnDene.Size = new System.Drawing.Size(56, 23);
            this.btnDene.TabIndex = 4;
            this.btnDene.Text = "DENE";
            this.btnDene.UseVisualStyleBackColor = true;
            this.btnDene.Click += new System.EventHandler(this.btnDene_Click);
            // 
            // txtHak
            // 
            this.txtHak.Location = new System.Drawing.Point(336, -5);
            this.txtHak.Name = "txtHak";
            this.txtHak.Size = new System.Drawing.Size(34, 20);
            this.txtHak.TabIndex = 5;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(371, 63);
            this.Controls.Add(this.txtHak);
            this.Controls.Add(this.btnDene);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTahmin);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTahmin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDene;
        private System.Windows.Forms.TextBox txtHak;
    }
}