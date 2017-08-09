namespace array2
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
            this.btnSonEleman = new System.Windows.Forms.Button();
            this.cbArabalar = new System.Windows.Forms.ComboBox();
            this.btnRandom = new System.Windows.Forms.Button();
            this.btnEkleTopla = new System.Windows.Forms.Button();
            this.lbEkran = new System.Windows.Forms.ListBox();
            this.btnAzalt = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSonEleman
            // 
            this.btnSonEleman.Location = new System.Drawing.Point(12, 12);
            this.btnSonEleman.Name = "btnSonEleman";
            this.btnSonEleman.Size = new System.Drawing.Size(298, 50);
            this.btnSonEleman.TabIndex = 0;
            this.btnSonEleman.Text = "Son Elemanı Getir";
            this.btnSonEleman.UseVisualStyleBackColor = true;
            this.btnSonEleman.Click += new System.EventHandler(this.btnSonEleman_Click);
            // 
            // cbArabalar
            // 
            this.cbArabalar.FormattingEnabled = true;
            this.cbArabalar.Location = new System.Drawing.Point(12, 68);
            this.cbArabalar.Name = "cbArabalar";
            this.cbArabalar.Size = new System.Drawing.Size(121, 21);
            this.cbArabalar.TabIndex = 1;
            this.cbArabalar.SelectedIndexChanged += new System.EventHandler(this.cbArabalar_SelectedIndexChanged);
            // 
            // btnRandom
            // 
            this.btnRandom.Location = new System.Drawing.Point(12, 114);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(121, 23);
            this.btnRandom.TabIndex = 2;
            this.btnRandom.Text = "Rastgele";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // btnEkleTopla
            // 
            this.btnEkleTopla.Location = new System.Drawing.Point(12, 143);
            this.btnEkleTopla.Name = "btnEkleTopla";
            this.btnEkleTopla.Size = new System.Drawing.Size(121, 23);
            this.btnEkleTopla.TabIndex = 3;
            this.btnEkleTopla.Text = "Ekrana Ekle";
            this.btnEkleTopla.UseVisualStyleBackColor = true;
            this.btnEkleTopla.Click += new System.EventHandler(this.btnEkleTopla_Click);
            // 
            // lbEkran
            // 
            this.lbEkran.FormattingEnabled = true;
            this.lbEkran.Location = new System.Drawing.Point(139, 68);
            this.lbEkran.Name = "lbEkran";
            this.lbEkran.Size = new System.Drawing.Size(171, 329);
            this.lbEkran.TabIndex = 4;
            // 
            // btnAzalt
            // 
            this.btnAzalt.Location = new System.Drawing.Point(12, 172);
            this.btnAzalt.Name = "btnAzalt";
            this.btnAzalt.Size = new System.Drawing.Size(121, 23);
            this.btnAzalt.TabIndex = 5;
            this.btnAzalt.Text = "Azaltarak Ekle";
            this.btnAzalt.UseVisualStyleBackColor = true;
            this.btnAzalt.Click += new System.EventHandler(this.btnAzalt_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(12, 201);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(121, 23);
            this.btnTemizle.TabIndex = 6;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 422);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnAzalt);
            this.Controls.Add(this.lbEkran);
            this.Controls.Add(this.btnEkleTopla);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.cbArabalar);
            this.Controls.Add(this.btnSonEleman);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSonEleman;
        private System.Windows.Forms.ComboBox cbArabalar;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.Button btnEkleTopla;
        private System.Windows.Forms.ListBox lbEkran;
        private System.Windows.Forms.Button btnAzalt;
        private System.Windows.Forms.Button btnTemizle;
    }
}

