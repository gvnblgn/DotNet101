namespace OOP_FaturaKontrolOwn
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
            this.gboxAcilis = new System.Windows.Forms.GroupBox();
            this.btnOlustur = new System.Windows.Forms.Button();
            this.cboxVezneSayisi = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gboxVeznedar = new System.Windows.Forms.GroupBox();
            this.btnVeznedarKaydet = new System.Windows.Forms.Button();
            this.txtVeznedarSoyad = new System.Windows.Forms.TextBox();
            this.txtVeznedarAd = new System.Windows.Forms.TextBox();
            this.txtVeznedarNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblBaslikMesaj = new System.Windows.Forms.Label();
            this.gboxFatura = new System.Windows.Forms.GroupBox();
            this.btnFaturaEkle = new System.Windows.Forms.Button();
            this.cbOdemeTip = new System.Windows.Forms.ComboBox();
            this.dtpIslemTarihi = new System.Windows.Forms.DateTimePicker();
            this.dtpSonOdemeTarihi = new System.Windows.Forms.DateTimePicker();
            this.txtMusteriSoyad = new System.Windows.Forms.TextBox();
            this.txtMüsteriAd = new System.Windows.Forms.TextBox();
            this.txtFaturaTutari = new System.Windows.Forms.TextBox();
            this.txtFaturaNo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gboxAcilis.SuspendLayout();
            this.gboxVeznedar.SuspendLayout();
            this.gboxFatura.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboxAcilis
            // 
            this.gboxAcilis.Controls.Add(this.btnOlustur);
            this.gboxAcilis.Controls.Add(this.cboxVezneSayisi);
            this.gboxAcilis.Controls.Add(this.label1);
            this.gboxAcilis.Location = new System.Drawing.Point(1, 12);
            this.gboxAcilis.Name = "gboxAcilis";
            this.gboxAcilis.Size = new System.Drawing.Size(322, 77);
            this.gboxAcilis.TabIndex = 0;
            this.gboxAcilis.TabStop = false;
            this.gboxAcilis.Text = "Açılış";
            // 
            // btnOlustur
            // 
            this.btnOlustur.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnOlustur.ForeColor = System.Drawing.SystemColors.Info;
            this.btnOlustur.Location = new System.Drawing.Point(193, 16);
            this.btnOlustur.Name = "btnOlustur";
            this.btnOlustur.Size = new System.Drawing.Size(104, 37);
            this.btnOlustur.TabIndex = 2;
            this.btnOlustur.Text = "Oluştur";
            this.btnOlustur.UseVisualStyleBackColor = false;
            this.btnOlustur.Click += new System.EventHandler(this.btnOlustur_Click);
            // 
            // cboxVezneSayisi
            // 
            this.cboxVezneSayisi.FormattingEnabled = true;
            this.cboxVezneSayisi.Location = new System.Drawing.Point(6, 32);
            this.cboxVezneSayisi.Name = "cboxVezneSayisi";
            this.cboxVezneSayisi.Size = new System.Drawing.Size(151, 21);
            this.cboxVezneSayisi.TabIndex = 1;
            this.cboxVezneSayisi.SelectedIndexChanged += new System.EventHandler(this.cboxVezneSayisi_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kaç Adet Vezne Oluşturulsun ?";
            // 
            // gboxVeznedar
            // 
            this.gboxVeznedar.Controls.Add(this.btnVeznedarKaydet);
            this.gboxVeznedar.Controls.Add(this.txtVeznedarSoyad);
            this.gboxVeznedar.Controls.Add(this.txtVeznedarAd);
            this.gboxVeznedar.Controls.Add(this.txtVeznedarNo);
            this.gboxVeznedar.Controls.Add(this.label4);
            this.gboxVeznedar.Controls.Add(this.label3);
            this.gboxVeznedar.Controls.Add(this.label2);
            this.gboxVeznedar.Enabled = false;
            this.gboxVeznedar.Location = new System.Drawing.Point(340, 12);
            this.gboxVeznedar.Name = "gboxVeznedar";
            this.gboxVeznedar.Size = new System.Drawing.Size(201, 127);
            this.gboxVeznedar.TabIndex = 1;
            this.gboxVeznedar.TabStop = false;
            this.gboxVeznedar.Text = "Veznedar Bilgi";
            // 
            // btnVeznedarKaydet
            // 
            this.btnVeznedarKaydet.Location = new System.Drawing.Point(87, 96);
            this.btnVeznedarKaydet.Name = "btnVeznedarKaydet";
            this.btnVeznedarKaydet.Size = new System.Drawing.Size(100, 23);
            this.btnVeznedarKaydet.TabIndex = 6;
            this.btnVeznedarKaydet.Text = "Kaydet";
            this.btnVeznedarKaydet.UseVisualStyleBackColor = true;
            this.btnVeznedarKaydet.Click += new System.EventHandler(this.btnVeznedarKaydet_Click);
            // 
            // txtVeznedarSoyad
            // 
            this.txtVeznedarSoyad.Location = new System.Drawing.Point(87, 68);
            this.txtVeznedarSoyad.Name = "txtVeznedarSoyad";
            this.txtVeznedarSoyad.Size = new System.Drawing.Size(100, 20);
            this.txtVeznedarSoyad.TabIndex = 5;
            // 
            // txtVeznedarAd
            // 
            this.txtVeznedarAd.Location = new System.Drawing.Point(87, 42);
            this.txtVeznedarAd.Name = "txtVeznedarAd";
            this.txtVeznedarAd.Size = new System.Drawing.Size(100, 20);
            this.txtVeznedarAd.TabIndex = 4;
            // 
            // txtVeznedarNo
            // 
            this.txtVeznedarNo.Location = new System.Drawing.Point(87, 16);
            this.txtVeznedarNo.Name = "txtVeznedarNo";
            this.txtVeznedarNo.Size = new System.Drawing.Size(100, 20);
            this.txtVeznedarNo.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Soyad :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ad :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "No :";
            // 
            // lblBaslikMesaj
            // 
            this.lblBaslikMesaj.AutoSize = true;
            this.lblBaslikMesaj.Location = new System.Drawing.Point(4, 108);
            this.lblBaslikMesaj.Name = "lblBaslikMesaj";
            this.lblBaslikMesaj.Size = new System.Drawing.Size(139, 13);
            this.lblBaslikMesaj.TabIndex = 7;
            this.lblBaslikMesaj.Text = "0 Adet Vezne Hizmete Hazır";
            // 
            // gboxFatura
            // 
            this.gboxFatura.Controls.Add(this.btnFaturaEkle);
            this.gboxFatura.Controls.Add(this.cbOdemeTip);
            this.gboxFatura.Controls.Add(this.dtpIslemTarihi);
            this.gboxFatura.Controls.Add(this.dtpSonOdemeTarihi);
            this.gboxFatura.Controls.Add(this.txtMusteriSoyad);
            this.gboxFatura.Controls.Add(this.txtMüsteriAd);
            this.gboxFatura.Controls.Add(this.txtFaturaTutari);
            this.gboxFatura.Controls.Add(this.txtFaturaNo);
            this.gboxFatura.Controls.Add(this.label11);
            this.gboxFatura.Controls.Add(this.label10);
            this.gboxFatura.Controls.Add(this.label9);
            this.gboxFatura.Controls.Add(this.label8);
            this.gboxFatura.Controls.Add(this.label7);
            this.gboxFatura.Controls.Add(this.label6);
            this.gboxFatura.Controls.Add(this.label5);
            this.gboxFatura.Enabled = false;
            this.gboxFatura.Location = new System.Drawing.Point(340, 145);
            this.gboxFatura.Name = "gboxFatura";
            this.gboxFatura.Size = new System.Drawing.Size(201, 256);
            this.gboxFatura.TabIndex = 8;
            this.gboxFatura.TabStop = false;
            this.gboxFatura.Text = "Fatura Bilgileri :";
            // 
            // btnFaturaEkle
            // 
            this.btnFaturaEkle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnFaturaEkle.ForeColor = System.Drawing.SystemColors.Info;
            this.btnFaturaEkle.Location = new System.Drawing.Point(88, 208);
            this.btnFaturaEkle.Name = "btnFaturaEkle";
            this.btnFaturaEkle.Size = new System.Drawing.Size(100, 23);
            this.btnFaturaEkle.TabIndex = 18;
            this.btnFaturaEkle.Text = "Ekle";
            this.btnFaturaEkle.UseVisualStyleBackColor = false;
            // 
            // cbOdemeTip
            // 
            this.cbOdemeTip.FormattingEnabled = true;
            this.cbOdemeTip.Location = new System.Drawing.Point(85, 130);
            this.cbOdemeTip.Name = "cbOdemeTip";
            this.cbOdemeTip.Size = new System.Drawing.Size(103, 21);
            this.cbOdemeTip.TabIndex = 17;
            // 
            // dtpIslemTarihi
            // 
            this.dtpIslemTarihi.Location = new System.Drawing.Point(85, 103);
            this.dtpIslemTarihi.Name = "dtpIslemTarihi";
            this.dtpIslemTarihi.Size = new System.Drawing.Size(103, 20);
            this.dtpIslemTarihi.TabIndex = 16;
            // 
            // dtpSonOdemeTarihi
            // 
            this.dtpSonOdemeTarihi.Location = new System.Drawing.Point(85, 77);
            this.dtpSonOdemeTarihi.Name = "dtpSonOdemeTarihi";
            this.dtpSonOdemeTarihi.Size = new System.Drawing.Size(103, 20);
            this.dtpSonOdemeTarihi.TabIndex = 15;
            // 
            // txtMusteriSoyad
            // 
            this.txtMusteriSoyad.Location = new System.Drawing.Point(85, 182);
            this.txtMusteriSoyad.Name = "txtMusteriSoyad";
            this.txtMusteriSoyad.Size = new System.Drawing.Size(103, 20);
            this.txtMusteriSoyad.TabIndex = 11;
            // 
            // txtMüsteriAd
            // 
            this.txtMüsteriAd.Location = new System.Drawing.Point(85, 156);
            this.txtMüsteriAd.Name = "txtMüsteriAd";
            this.txtMüsteriAd.Size = new System.Drawing.Size(103, 20);
            this.txtMüsteriAd.TabIndex = 10;
            // 
            // txtFaturaTutari
            // 
            this.txtFaturaTutari.Location = new System.Drawing.Point(88, 44);
            this.txtFaturaTutari.Name = "txtFaturaTutari";
            this.txtFaturaTutari.Size = new System.Drawing.Size(100, 20);
            this.txtFaturaTutari.TabIndex = 9;
            // 
            // txtFaturaNo
            // 
            this.txtFaturaNo.Location = new System.Drawing.Point(88, 18);
            this.txtFaturaNo.Name = "txtFaturaNo";
            this.txtFaturaNo.Size = new System.Drawing.Size(100, 20);
            this.txtFaturaNo.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 189);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "Müş. Soyad:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 165);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Müş. Ad:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 138);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Öd. tip";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "İşlem T.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "label7";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Fatura Tutar:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Fatura No:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 442);
            this.Controls.Add(this.gboxFatura);
            this.Controls.Add(this.lblBaslikMesaj);
            this.Controls.Add(this.gboxVeznedar);
            this.Controls.Add(this.gboxAcilis);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gboxAcilis.ResumeLayout(false);
            this.gboxAcilis.PerformLayout();
            this.gboxVeznedar.ResumeLayout(false);
            this.gboxVeznedar.PerformLayout();
            this.gboxFatura.ResumeLayout(false);
            this.gboxFatura.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gboxAcilis;
        private System.Windows.Forms.Button btnOlustur;
        private System.Windows.Forms.ComboBox cboxVezneSayisi;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox gboxVeznedar;
        private System.Windows.Forms.Button btnVeznedarKaydet;
        private System.Windows.Forms.TextBox txtVeznedarSoyad;
        private System.Windows.Forms.TextBox txtVeznedarAd;
        private System.Windows.Forms.TextBox txtVeznedarNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblBaslikMesaj;
        private System.Windows.Forms.GroupBox gboxFatura;
        private System.Windows.Forms.TextBox txtMusteriSoyad;
        private System.Windows.Forms.TextBox txtMüsteriAd;
        private System.Windows.Forms.TextBox txtFaturaTutari;
        private System.Windows.Forms.TextBox txtFaturaNo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpIslemTarihi;
        private System.Windows.Forms.DateTimePicker dtpSonOdemeTarihi;
        private System.Windows.Forms.ComboBox cbOdemeTip;
        private System.Windows.Forms.Button btnFaturaEkle;
    }
}

