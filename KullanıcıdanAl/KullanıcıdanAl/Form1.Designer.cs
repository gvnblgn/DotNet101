namespace KullanıcıdanAl
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
            this.lblBir = new System.Windows.Forms.Label();
            this.lblIki = new System.Windows.Forms.Label();
            this.lblMod = new System.Windows.Forms.Label();
            this.lblModFark = new System.Windows.Forms.Label();
            this.txtBirinci = new System.Windows.Forms.TextBox();
            this.txtIkinci = new System.Windows.Forms.TextBox();
            this.txtMod = new System.Windows.Forms.TextBox();
            this.txtModFark = new System.Windows.Forms.TextBox();
            this.btnBir = new System.Windows.Forms.Button();
            this.btnIki = new System.Windows.Forms.Button();
            this.btnIkinci = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBir
            // 
            this.lblBir.AutoSize = true;
            this.lblBir.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBir.Location = new System.Drawing.Point(0, 0);
            this.lblBir.Name = "lblBir";
            this.lblBir.Size = new System.Drawing.Size(129, 21);
            this.lblBir.TabIndex = 0;
            this.lblBir.Text = "Birinci Sayı :";
            // 
            // lblIki
            // 
            this.lblIki.AutoSize = true;
            this.lblIki.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIki.Location = new System.Drawing.Point(0, 44);
            this.lblIki.Name = "lblIki";
            this.lblIki.Size = new System.Drawing.Size(114, 21);
            this.lblIki.TabIndex = 1;
            this.lblIki.Text = "İkinci Sayı :";
            // 
            // lblMod
            // 
            this.lblMod.AutoSize = true;
            this.lblMod.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMod.Location = new System.Drawing.Point(0, 90);
            this.lblMod.Name = "lblMod";
            this.lblMod.Size = new System.Drawing.Size(58, 21);
            this.lblMod.TabIndex = 2;
            this.lblMod.Text = "Mod :";
            // 
            // lblModFark
            // 
            this.lblModFark.AutoSize = true;
            this.lblModFark.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModFark.Location = new System.Drawing.Point(0, 138);
            this.lblModFark.Name = "lblModFark";
            this.lblModFark.Size = new System.Drawing.Size(113, 21);
            this.lblModFark.TabIndex = 3;
            this.lblModFark.Text = "Mod Farkı :";
            // 
            // txtBirinci
            // 
            this.txtBirinci.Location = new System.Drawing.Point(148, 0);
            this.txtBirinci.Name = "txtBirinci";
            this.txtBirinci.Size = new System.Drawing.Size(199, 20);
            this.txtBirinci.TabIndex = 4;
            this.txtBirinci.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtIkinci
            // 
            this.txtIkinci.Location = new System.Drawing.Point(148, 45);
            this.txtIkinci.Name = "txtIkinci";
            this.txtIkinci.Size = new System.Drawing.Size(199, 20);
            this.txtIkinci.TabIndex = 5;
            this.txtIkinci.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtMod
            // 
            this.txtMod.Location = new System.Drawing.Point(148, 93);
            this.txtMod.Name = "txtMod";
            this.txtMod.Size = new System.Drawing.Size(199, 20);
            this.txtMod.TabIndex = 6;
            this.txtMod.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtModFark
            // 
            this.txtModFark.Location = new System.Drawing.Point(148, 141);
            this.txtModFark.Name = "txtModFark";
            this.txtModFark.Size = new System.Drawing.Size(199, 20);
            this.txtModFark.TabIndex = 7;
            this.txtModFark.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnBir
            // 
            this.btnBir.Location = new System.Drawing.Point(148, 180);
            this.btnBir.Name = "btnBir";
            this.btnBir.Size = new System.Drawing.Size(199, 38);
            this.btnBir.TabIndex = 8;
            this.btnBir.Text = "Birinci Operasyon";
            this.btnBir.UseVisualStyleBackColor = true;
            this.btnBir.Click += new System.EventHandler(this.btnBir_Click);
            // 
            // btnIki
            // 
            this.btnIki.Location = new System.Drawing.Point(148, 224);
            this.btnIki.Name = "btnIki";
            this.btnIki.Size = new System.Drawing.Size(199, 38);
            this.btnIki.TabIndex = 9;
            this.btnIki.Text = "Mod ";
            this.btnIki.UseVisualStyleBackColor = true;
            this.btnIki.Click += new System.EventHandler(this.btnIki_Click);
            // 
            // btnIkinci
            // 
            this.btnIkinci.Location = new System.Drawing.Point(148, 268);
            this.btnIkinci.Name = "btnIkinci";
            this.btnIkinci.Size = new System.Drawing.Size(199, 38);
            this.btnIkinci.TabIndex = 10;
            this.btnIkinci.Text = "İkinci Operasyon";
            this.btnIkinci.UseVisualStyleBackColor = true;
            this.btnIkinci.Click += new System.EventHandler(this.btnIkinci_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 369);
            this.Controls.Add(this.btnIkinci);
            this.Controls.Add(this.btnIki);
            this.Controls.Add(this.btnBir);
            this.Controls.Add(this.txtModFark);
            this.Controls.Add(this.txtMod);
            this.Controls.Add(this.txtIkinci);
            this.Controls.Add(this.txtBirinci);
            this.Controls.Add(this.lblModFark);
            this.Controls.Add(this.lblMod);
            this.Controls.Add(this.lblIki);
            this.Controls.Add(this.lblBir);
            this.Name = "Form1";
            this.Text = "20.07.2017";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBir;
        private System.Windows.Forms.Label lblIki;
        private System.Windows.Forms.Label lblMod;
        private System.Windows.Forms.Label lblModFark;
        private System.Windows.Forms.TextBox txtBirinci;
        private System.Windows.Forms.TextBox txtIkinci;
        private System.Windows.Forms.TextBox txtMod;
        private System.Windows.Forms.TextBox txtModFark;
        private System.Windows.Forms.Button btnBir;
        private System.Windows.Forms.Button btnIki;
        private System.Windows.Forms.Button btnIkinci;
    }
}

