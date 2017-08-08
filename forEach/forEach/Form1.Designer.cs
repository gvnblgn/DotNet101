namespace forEach
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
            this.btnEkle = new System.Windows.Forms.Button();
            this.lbEkle = new System.Windows.Forms.ListBox();
            this.btnIki = new System.Windows.Forms.Button();
            this.lbIki = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(12, 12);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 0;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // lbEkle
            // 
            this.lbEkle.FormattingEnabled = true;
            this.lbEkle.Location = new System.Drawing.Point(93, 2);
            this.lbEkle.Name = "lbEkle";
            this.lbEkle.Size = new System.Drawing.Size(228, 316);
            this.lbEkle.TabIndex = 1;
            
            // 
            // btnIki
            // 
            this.btnIki.Location = new System.Drawing.Point(12, 58);
            this.btnIki.Name = "btnIki";
            this.btnIki.Size = new System.Drawing.Size(75, 23);
            this.btnIki.TabIndex = 2;
            this.btnIki.Text = "İki";
            this.btnIki.UseVisualStyleBackColor = true;
            this.btnIki.Click += new System.EventHandler(this.btnIki_Click);
            // 
            // lbIki
            // 
            this.lbIki.FormattingEnabled = true;
            this.lbIki.Location = new System.Drawing.Point(332, 2);
            this.lbIki.Name = "lbIki";
            this.lbIki.Size = new System.Drawing.Size(228, 316);
            this.lbIki.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 434);
            this.Controls.Add(this.lbIki);
            this.Controls.Add(this.btnIki);
            this.Controls.Add(this.lbEkle);
            this.Controls.Add(this.btnEkle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.ListBox lbEkle;
        private System.Windows.Forms.Button btnIki;
        private System.Windows.Forms.ListBox lbIki;
    }
}

