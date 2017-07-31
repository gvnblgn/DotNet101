namespace _04Degiskenler
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
            this.lbTakımlar = new System.Windows.Forms.ListBox();
            this.btnTakımlar = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnGez = new System.Windows.Forms.Button();
            this.btnSayilar = new System.Windows.Forms.Button();
            this.btnRandom = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbTakımlar
            // 
            this.lbTakımlar.FormattingEnabled = true;
            this.lbTakımlar.Location = new System.Drawing.Point(0, 0);
            this.lbTakımlar.Name = "lbTakımlar";
            this.lbTakımlar.Size = new System.Drawing.Size(207, 355);
            this.lbTakımlar.TabIndex = 0;
            this.lbTakımlar.Click += new System.EventHandler(this.lbTakımlar_Click);
            // 
            // btnTakımlar
            // 
            this.btnTakımlar.Location = new System.Drawing.Point(213, 12);
            this.btnTakımlar.Name = "btnTakımlar";
            this.btnTakımlar.Size = new System.Drawing.Size(196, 23);
            this.btnTakımlar.TabIndex = 1;
            this.btnTakımlar.Text = "Takımları Ekle";
            this.btnTakımlar.UseVisualStyleBackColor = true;
            this.btnTakımlar.Click += new System.EventHandler(this.btnTakımlar_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(213, 41);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(196, 23);
            this.btnTemizle.TabIndex = 2;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnGez
            // 
            this.btnGez.Location = new System.Drawing.Point(213, 70);
            this.btnGez.Name = "btnGez";
            this.btnGez.Size = new System.Drawing.Size(196, 23);
            this.btnGez.TabIndex = 3;
            this.btnGez.Text = "Gez";
            this.btnGez.UseVisualStyleBackColor = true;
            this.btnGez.Click += new System.EventHandler(this.btnGez_Click);
            // 
            // btnSayilar
            // 
            this.btnSayilar.Location = new System.Drawing.Point(213, 99);
            this.btnSayilar.Name = "btnSayilar";
            this.btnSayilar.Size = new System.Drawing.Size(196, 23);
            this.btnSayilar.TabIndex = 4;
            this.btnSayilar.Text = "Sayılar";
            this.btnSayilar.UseVisualStyleBackColor = true;
            this.btnSayilar.Click += new System.EventHandler(this.btnSayilar_Click);
            // 
            // btnRandom
            // 
            this.btnRandom.Location = new System.Drawing.Point(213, 128);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(196, 23);
            this.btnRandom.TabIndex = 5;
            this.btnRandom.Text = "Rastgele";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 420);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.btnSayilar);
            this.Controls.Add(this.btnGez);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnTakımlar);
            this.Controls.Add(this.lbTakımlar);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbTakımlar;
        private System.Windows.Forms.Button btnTakımlar;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnGez;
        private System.Windows.Forms.Button btnSayilar;
        private System.Windows.Forms.Button btnRandom;
    }
}