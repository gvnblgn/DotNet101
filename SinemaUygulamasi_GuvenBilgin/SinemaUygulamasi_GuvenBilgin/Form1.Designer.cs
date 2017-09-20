namespace SinemaUygulamasi_GuvenBilgin
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
            this.gboxSalon = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbSeans = new System.Windows.Forms.ComboBox();
            this.cbFilm = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.gboxFilm = new System.Windows.Forms.GroupBox();
            this.btnFilmEkle = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbSeanslar = new System.Windows.Forms.ListBox();
            this.lbFilm = new System.Windows.Forms.ListBox();
            this.txtFilm = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.gboxSalon.SuspendLayout();
            this.gboxFilm.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboxSalon
            // 
            this.gboxSalon.Controls.Add(this.label7);
            this.gboxSalon.Controls.Add(this.label6);
            this.gboxSalon.Controls.Add(this.cbSeans);
            this.gboxSalon.Controls.Add(this.cbFilm);
            this.gboxSalon.Controls.Add(this.button1);
            this.gboxSalon.Location = new System.Drawing.Point(14, 72);
            this.gboxSalon.Name = "gboxSalon";
            this.gboxSalon.Size = new System.Drawing.Size(249, 153);
            this.gboxSalon.TabIndex = 0;
            this.gboxSalon.TabStop = false;
            this.gboxSalon.Text = "Sinema Salonu";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(237, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Lütfen İzlemek İstediğiniz Filmin Seansını Seçiniz:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(188, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Lütfen İzlemek İstediğiniz Filmi Seçiniz:";
            // 
            // cbSeans
            // 
            this.cbSeans.FormattingEnabled = true;
            this.cbSeans.Location = new System.Drawing.Point(12, 91);
            this.cbSeans.Name = "cbSeans";
            this.cbSeans.Size = new System.Drawing.Size(208, 21);
            this.cbSeans.TabIndex = 12;
            // 
            // cbFilm
            // 
            this.cbFilm.FormattingEnabled = true;
            this.cbFilm.Location = new System.Drawing.Point(15, 48);
            this.cbFilm.Name = "cbFilm";
            this.cbFilm.Size = new System.Drawing.Size(208, 21);
            this.cbFilm.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 114);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Bilet Sat";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // gboxFilm
            // 
            this.gboxFilm.Controls.Add(this.btnFilmEkle);
            this.gboxFilm.Controls.Add(this.label3);
            this.gboxFilm.Controls.Add(this.label2);
            this.gboxFilm.Controls.Add(this.lbSeanslar);
            this.gboxFilm.Controls.Add(this.lbFilm);
            this.gboxFilm.Controls.Add(this.txtFilm);
            this.gboxFilm.Controls.Add(this.label1);
            this.gboxFilm.Location = new System.Drawing.Point(662, 12);
            this.gboxFilm.Name = "gboxFilm";
            this.gboxFilm.Size = new System.Drawing.Size(267, 436);
            this.gboxFilm.TabIndex = 1;
            this.gboxFilm.TabStop = false;
            this.gboxFilm.Text = "Film Ekle :";
            // 
            // btnFilmEkle
            // 
            this.btnFilmEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilmEkle.Location = new System.Drawing.Point(6, 408);
            this.btnFilmEkle.Name = "btnFilmEkle";
            this.btnFilmEkle.Size = new System.Drawing.Size(255, 23);
            this.btnFilmEkle.TabIndex = 6;
            this.btnFilmEkle.Text = "FİLM EKLE";
            this.btnFilmEkle.UseVisualStyleBackColor = true;
            this.btnFilmEkle.Click += new System.EventHandler(this.btnFilmEkle_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Seanslar :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Film Listesi :";
            // 
            // lbSeanslar
            // 
            this.lbSeanslar.FormattingEnabled = true;
            this.lbSeanslar.Location = new System.Drawing.Point(6, 242);
            this.lbSeanslar.Name = "lbSeanslar";
            this.lbSeanslar.Size = new System.Drawing.Size(255, 160);
            this.lbSeanslar.TabIndex = 3;
            // 
            // lbFilm
            // 
            this.lbFilm.FormattingEnabled = true;
            this.lbFilm.Location = new System.Drawing.Point(6, 63);
            this.lbFilm.Name = "lbFilm";
            this.lbFilm.Size = new System.Drawing.Size(255, 160);
            this.lbFilm.TabIndex = 2;
            // 
            // txtFilm
            // 
            this.txtFilm.Location = new System.Drawing.Point(114, 13);
            this.txtFilm.Name = "txtFilm";
            this.txtFilm.Size = new System.Drawing.Size(147, 20);
            this.txtFilm.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Film Adını Giriniz :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(1, -4);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(310, 73);
            this.label8.TabIndex = 18;
            this.label8.Text = "SALON 1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 460);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.gboxFilm);
            this.Controls.Add(this.gboxSalon);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gboxSalon.ResumeLayout(false);
            this.gboxSalon.PerformLayout();
            this.gboxFilm.ResumeLayout(false);
            this.gboxFilm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gboxSalon;
        private System.Windows.Forms.GroupBox gboxFilm;
        private System.Windows.Forms.TextBox txtFilm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbFilm;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnFilmEkle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbSeanslar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbSeans;
        private System.Windows.Forms.ComboBox cbFilm;
        private System.Windows.Forms.Label label8;
    }
}

