namespace faktoriyel
{
    partial class Form1
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
            this.btnFaktoriyel = new System.Windows.Forms.Button();
            this.txtFaktoriyel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSonuc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnKapat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFaktoriyel
            // 
            this.btnFaktoriyel.Location = new System.Drawing.Point(227, 77);
            this.btnFaktoriyel.Name = "btnFaktoriyel";
            this.btnFaktoriyel.Size = new System.Drawing.Size(100, 38);
            this.btnFaktoriyel.TabIndex = 0;
            this.btnFaktoriyel.Text = "Faktoriyel Hesapla";
            this.btnFaktoriyel.UseVisualStyleBackColor = true;
            this.btnFaktoriyel.Click += new System.EventHandler(this.btnFaktoriyel_Click);
            // 
            // txtFaktoriyel
            // 
            this.txtFaktoriyel.Location = new System.Drawing.Point(227, 9);
            this.txtFaktoriyel.Name = "txtFaktoriyel";
            this.txtFaktoriyel.Size = new System.Drawing.Size(100, 20);
            this.txtFaktoriyel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Faktoriyel Hesaplanacak Sayiyi Giriniz :";
            // 
            // txtSonuc
            // 
            this.txtSonuc.Location = new System.Drawing.Point(227, 38);
            this.txtSonuc.Name = "txtSonuc";
            this.txtSonuc.Size = new System.Drawing.Size(100, 20);
            this.txtSonuc.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Girmis Oldugunuz Sayinin Faktoriyel Sonucu :";
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(333, 77);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(100, 38);
            this.btnTemizle.TabIndex = 5;
            this.btnTemizle.Text = "Alanlari Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.Location = new System.Drawing.Point(424, 9);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(42, 20);
            this.btnKapat.TabIndex = 6;
            this.btnKapat.Text = "kapat";
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(478, 334);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSonuc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFaktoriyel);
            this.Controls.Add(this.btnFaktoriyel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFaktoriyel;
        private System.Windows.Forms.TextBox txtFaktoriyel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSonuc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnKapat;
    }
}

