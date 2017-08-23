namespace GuvenBilgin_Odev2_1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbZorluk = new System.Windows.Forms.ComboBox();
            this.btnBasla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(113, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tahmin Oyununa Hosgeldiniz";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lütfen Oyunun Zorluk Seviyesini Seçiniz :";
            // 
            // cbZorluk
            // 
            this.cbZorluk.BackColor = System.Drawing.Color.DarkOrange;
            this.cbZorluk.FormattingEnabled = true;
            this.cbZorluk.Items.AddRange(new object[] {
            "Kolay",
            "Orta",
            "Zor",
            "Çok Zor"});
            this.cbZorluk.Location = new System.Drawing.Point(222, 79);
            this.cbZorluk.Name = "cbZorluk";
            this.cbZorluk.Size = new System.Drawing.Size(121, 21);
            this.cbZorluk.TabIndex = 2;
            // 
            // btnBasla
            // 
            this.btnBasla.BackColor = System.Drawing.Color.Gold;
            this.btnBasla.Location = new System.Drawing.Point(222, 107);
            this.btnBasla.Name = "btnBasla";
            this.btnBasla.Size = new System.Drawing.Size(121, 23);
            this.btnBasla.TabIndex = 3;
            this.btnBasla.Text = "Oyuna Başla";
            this.btnBasla.UseVisualStyleBackColor = false;
            this.btnBasla.Click += new System.EventHandler(this.btnBasla_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(383, 164);
            this.Controls.Add(this.btnBasla);
            this.Controls.Add(this.cbZorluk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbZorluk;
        private System.Windows.Forms.Button btnBasla;
    }
}

