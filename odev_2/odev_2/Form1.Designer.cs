namespace odev_2
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
            this.cbZorluk = new System.Windows.Forms.ComboBox();
            this.btnGir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "OYUNUN ZORLUĞUNU SEÇİNİZ !";
            // 
            // cbZorluk
            // 
            this.cbZorluk.FormattingEnabled = true;
            this.cbZorluk.Items.AddRange(new object[] {
            "KOLAY",
            "ORTA",
            "ZOR",
            "ÇOK ZOR"});
            this.cbZorluk.Location = new System.Drawing.Point(111, 67);
            this.cbZorluk.Name = "cbZorluk";
            this.cbZorluk.Size = new System.Drawing.Size(121, 21);
            this.cbZorluk.TabIndex = 1;
            // 
            // btnGir
            // 
            this.btnGir.Location = new System.Drawing.Point(111, 110);
            this.btnGir.Name = "btnGir";
            this.btnGir.Size = new System.Drawing.Size(121, 23);
            this.btnGir.TabIndex = 2;
            this.btnGir.Text = "Oyuna Başla ";
            this.btnGir.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 300);
            this.Controls.Add(this.btnGir);
            this.Controls.Add(this.cbZorluk);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbZorluk;
        private System.Windows.Forms.Button btnGir;
    }
}

