namespace GuvenBilgin_Odev2_3
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGun = new System.Windows.Forms.TextBox();
            this.txtSaat = new System.Windows.Forms.TextBox();
            this.txtDakika = new System.Windows.Forms.TextBox();
            this.txtSaniye = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnBasla = new System.Windows.Forms.Button();
            this.btnDurdur = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "SAAT UYGULAMASI";
            // 
            // txtGun
            // 
            this.txtGun.Location = new System.Drawing.Point(52, 64);
            this.txtGun.Name = "txtGun";
            this.txtGun.Size = new System.Drawing.Size(51, 20);
            this.txtGun.TabIndex = 1;
            this.txtGun.Text = "00";
            this.txtGun.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSaat
            // 
            this.txtSaat.Location = new System.Drawing.Point(124, 64);
            this.txtSaat.Name = "txtSaat";
            this.txtSaat.Size = new System.Drawing.Size(51, 20);
            this.txtSaat.TabIndex = 2;
            this.txtSaat.Text = "00";
            this.txtSaat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDakika
            // 
            this.txtDakika.Location = new System.Drawing.Point(192, 64);
            this.txtDakika.Name = "txtDakika";
            this.txtDakika.Size = new System.Drawing.Size(51, 20);
            this.txtDakika.TabIndex = 3;
            this.txtDakika.Text = "00";
            this.txtDakika.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSaniye
            // 
            this.txtSaniye.Location = new System.Drawing.Point(262, 64);
            this.txtSaniye.Name = "txtSaniye";
            this.txtSaniye.Size = new System.Drawing.Size(51, 20);
            this.txtSaniye.TabIndex = 4;
            this.txtSaniye.Text = "00";
            this.txtSaniye.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "GÜN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(130, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "SAAT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(199, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "DAKİKA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(268, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "SANİYE";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnBasla
            // 
            this.btnBasla.Location = new System.Drawing.Point(52, 107);
            this.btnBasla.Name = "btnBasla";
            this.btnBasla.Size = new System.Drawing.Size(123, 23);
            this.btnBasla.TabIndex = 10;
            this.btnBasla.Text = "BAŞLA";
            this.btnBasla.UseVisualStyleBackColor = true;
            this.btnBasla.Click += new System.EventHandler(this.btnBasla_Click);
            // 
            // btnDurdur
            // 
            this.btnDurdur.Location = new System.Drawing.Point(192, 107);
            this.btnDurdur.Name = "btnDurdur";
            this.btnDurdur.Size = new System.Drawing.Size(121, 23);
            this.btnDurdur.TabIndex = 11;
            this.btnDurdur.Text = "DURDUR";
            this.btnDurdur.UseVisualStyleBackColor = true;
            this.btnDurdur.Click += new System.EventHandler(this.btnDurdur_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 142);
            this.Controls.Add(this.btnDurdur);
            this.Controls.Add(this.btnBasla);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSaniye);
            this.Controls.Add(this.txtDakika);
            this.Controls.Add(this.txtSaat);
            this.Controls.Add(this.txtGun);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGun;
        private System.Windows.Forms.TextBox txtSaat;
        private System.Windows.Forms.TextBox txtDakika;
        private System.Windows.Forms.TextBox txtSaniye;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBasla;
        private System.Windows.Forms.Button btnDurdur;
        private System.Windows.Forms.Timer timer1;
    }
}

