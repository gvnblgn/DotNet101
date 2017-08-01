namespace randomArray
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
            this.lbRandom = new System.Windows.Forms.ListBox();
            this.btnGet = new System.Windows.Forms.Button();
            this.btnClean = new System.Windows.Forms.Button();
            this.btnCift = new System.Windows.Forms.Button();
            this.btnTek = new System.Windows.Forms.Button();
            this.btnRenkDegistir = new System.Windows.Forms.Button();
            this.txtSon = new System.Windows.Forms.TextBox();
            this.btnSon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbRandom
            // 
            this.lbRandom.FormattingEnabled = true;
            this.lbRandom.Location = new System.Drawing.Point(1, 0);
            this.lbRandom.Name = "lbRandom";
            this.lbRandom.Size = new System.Drawing.Size(238, 420);
            this.lbRandom.TabIndex = 0;
            // 
            // btnGet
            // 
            this.btnGet.Location = new System.Drawing.Point(237, 26);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(205, 57);
            this.btnGet.TabIndex = 1;
            this.btnGet.Text = "Sayı Oluştur";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // btnClean
            // 
            this.btnClean.Location = new System.Drawing.Point(237, 89);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(205, 57);
            this.btnClean.TabIndex = 2;
            this.btnClean.Text = "Temizle";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // btnCift
            // 
            this.btnCift.Location = new System.Drawing.Point(237, 152);
            this.btnCift.Name = "btnCift";
            this.btnCift.Size = new System.Drawing.Size(205, 57);
            this.btnCift.TabIndex = 3;
            this.btnCift.Text = "Çiftleri Getir";
            this.btnCift.UseVisualStyleBackColor = true;
            this.btnCift.Click += new System.EventHandler(this.btnCift_Click);
            // 
            // btnTek
            // 
            this.btnTek.Location = new System.Drawing.Point(237, 215);
            this.btnTek.Name = "btnTek";
            this.btnTek.Size = new System.Drawing.Size(205, 57);
            this.btnTek.TabIndex = 4;
            this.btnTek.Text = "Tekleri Getir";
            this.btnTek.UseVisualStyleBackColor = true;
            // 
            // btnRenkDegistir
            // 
            this.btnRenkDegistir.Location = new System.Drawing.Point(237, 278);
            this.btnRenkDegistir.Name = "btnRenkDegistir";
            this.btnRenkDegistir.Size = new System.Drawing.Size(205, 57);
            this.btnRenkDegistir.TabIndex = 5;
            this.btnRenkDegistir.Text = "Renk Değiştir";
            this.btnRenkDegistir.UseVisualStyleBackColor = true;
            this.btnRenkDegistir.Click += new System.EventHandler(this.btnRenkDegistir_Click);
            // 
            // txtSon
            // 
            this.txtSon.Location = new System.Drawing.Point(237, 0);
            this.txtSon.Name = "txtSon";
            this.txtSon.Size = new System.Drawing.Size(205, 20);
            this.txtSon.TabIndex = 6;
            // 
            // btnSon
            // 
            this.btnSon.Location = new System.Drawing.Point(237, 341);
            this.btnSon.Name = "btnSon";
            this.btnSon.Size = new System.Drawing.Size(205, 57);
            this.btnSon.TabIndex = 7;
            this.btnSon.Text = "Son İşlem";
            this.btnSon.UseVisualStyleBackColor = true;
            this.btnSon.Click += new System.EventHandler(this.btnSon_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 416);
            this.Controls.Add(this.btnSon);
            this.Controls.Add(this.txtSon);
            this.Controls.Add(this.btnRenkDegistir);
            this.Controls.Add(this.btnTek);
            this.Controls.Add(this.btnCift);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.btnGet);
            this.Controls.Add(this.lbRandom);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbRandom;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Button btnCift;
        private System.Windows.Forms.Button btnTek;
        private System.Windows.Forms.Button btnRenkDegistir;
        private System.Windows.Forms.TextBox txtSon;
        private System.Windows.Forms.Button btnSon;
    }
}

