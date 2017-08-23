namespace GuvenBilgin_Odev2_2
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSayi1 = new System.Windows.Forms.TextBox();
            this.txtSayi2 = new System.Windows.Forms.TextBox();
            this.txtSayi3 = new System.Windows.Forms.TextBox();
            this.txtSayi4 = new System.Windows.Forms.TextBox();
            this.txtSayi5 = new System.Windows.Forms.TextBox();
            this.btnBul = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "2.SAYI :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "1.SAYI :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "3.SAYI :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "4.SAYI :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "5.SAYI :";
            // 
            // txtSayi1
            // 
            this.txtSayi1.Location = new System.Drawing.Point(54, 7);
            this.txtSayi1.Name = "txtSayi1";
            this.txtSayi1.Size = new System.Drawing.Size(45, 20);
            this.txtSayi1.TabIndex = 7;
            this.txtSayi1.Text = "0";
            // 
            // txtSayi2
            // 
            this.txtSayi2.Location = new System.Drawing.Point(54, 33);
            this.txtSayi2.Name = "txtSayi2";
            this.txtSayi2.Size = new System.Drawing.Size(45, 20);
            this.txtSayi2.TabIndex = 8;
            this.txtSayi2.Text = "0";
            // 
            // txtSayi3
            // 
            this.txtSayi3.Location = new System.Drawing.Point(54, 63);
            this.txtSayi3.Name = "txtSayi3";
            this.txtSayi3.Size = new System.Drawing.Size(45, 20);
            this.txtSayi3.TabIndex = 9;
            this.txtSayi3.Text = "0";
            // 
            // txtSayi4
            // 
            this.txtSayi4.Location = new System.Drawing.Point(54, 92);
            this.txtSayi4.Name = "txtSayi4";
            this.txtSayi4.Size = new System.Drawing.Size(45, 20);
            this.txtSayi4.TabIndex = 10;
            this.txtSayi4.Text = "0";
            // 
            // txtSayi5
            // 
            this.txtSayi5.Location = new System.Drawing.Point(54, 123);
            this.txtSayi5.Name = "txtSayi5";
            this.txtSayi5.Size = new System.Drawing.Size(45, 20);
            this.txtSayi5.TabIndex = 11;
            this.txtSayi5.Text = "0";
            // 
            // btnBul
            // 
            this.btnBul.BackColor = System.Drawing.Color.Gold;
            this.btnBul.Location = new System.Drawing.Point(5, 156);
            this.btnBul.Name = "btnBul";
            this.btnBul.Size = new System.Drawing.Size(94, 23);
            this.btnBul.TabIndex = 12;
            this.btnBul.Text = "En Büyüğü Bul";
            this.btnBul.UseVisualStyleBackColor = false;
            this.btnBul.Click += new System.EventHandler(this.btnBul_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(116, 187);
            this.Controls.Add(this.btnBul);
            this.Controls.Add(this.txtSayi5);
            this.Controls.Add(this.txtSayi4);
            this.Controls.Add(this.txtSayi3);
            this.Controls.Add(this.txtSayi2);
            this.Controls.Add(this.txtSayi1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSayi1;
        private System.Windows.Forms.TextBox txtSayi2;
        private System.Windows.Forms.TextBox txtSayi3;
        private System.Windows.Forms.TextBox txtSayi4;
        private System.Windows.Forms.TextBox txtSayi5;
        private System.Windows.Forms.Button btnBul;
    }
}