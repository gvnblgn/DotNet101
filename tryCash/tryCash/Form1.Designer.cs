namespace tryCash
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
            this.txtDeger = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnDeger = new System.Windows.Forms.Button();
            this.btnKontrol = new System.Windows.Forms.Button();
            this.btnFinal = new System.Windows.Forms.Button();
            this.btnNot = new System.Windows.Forms.Button();
            this.btnTek = new System.Windows.Forms.Button();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDeger
            // 
            this.txtDeger.Location = new System.Drawing.Point(29, 12);
            this.txtDeger.Name = "txtDeger";
            this.txtDeger.Size = new System.Drawing.Size(422, 20);
            this.txtDeger.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnDeger
            // 
            this.btnDeger.Location = new System.Drawing.Point(29, 52);
            this.btnDeger.Name = "btnDeger";
            this.btnDeger.Size = new System.Drawing.Size(422, 23);
            this.btnDeger.TabIndex = 1;
            this.btnDeger.Text = "Hesapla";
            this.btnDeger.UseVisualStyleBackColor = true;
            this.btnDeger.Click += new System.EventHandler(this.btnDeger_Click);
            // 
            // btnKontrol
            // 
            this.btnKontrol.Location = new System.Drawing.Point(29, 90);
            this.btnKontrol.Name = "btnKontrol";
            this.btnKontrol.Size = new System.Drawing.Size(422, 23);
            this.btnKontrol.TabIndex = 2;
            this.btnKontrol.Text = "Kontrollü Onay";
            this.btnKontrol.UseVisualStyleBackColor = true;
            this.btnKontrol.Click += new System.EventHandler(this.btnKontrol_Click);
            // 
            // btnFinal
            // 
            this.btnFinal.Location = new System.Drawing.Point(29, 129);
            this.btnFinal.Name = "btnFinal";
            this.btnFinal.Size = new System.Drawing.Size(422, 23);
            this.btnFinal.TabIndex = 3;
            this.btnFinal.Text = "Final Kontrollü Onay";
            this.btnFinal.UseVisualStyleBackColor = true;
            this.btnFinal.Click += new System.EventHandler(this.btnFinal_Click);
            // 
            // btnNot
            // 
            this.btnNot.Location = new System.Drawing.Point(29, 168);
            this.btnNot.Name = "btnNot";
            this.btnNot.Size = new System.Drawing.Size(422, 23);
            this.btnNot.TabIndex = 4;
            this.btnNot.Text = "Onay";
            this.btnNot.UseVisualStyleBackColor = true;
            this.btnNot.Click += new System.EventHandler(this.btnNot_Click);
            // 
            // btnTek
            // 
            this.btnTek.Location = new System.Drawing.Point(29, 197);
            this.btnTek.Name = "btnTek";
            this.btnTek.Size = new System.Drawing.Size(422, 23);
            this.btnTek.TabIndex = 5;
            this.btnTek.Text = "tek çift";
            this.btnTek.UseVisualStyleBackColor = true;
            this.btnTek.Click += new System.EventHandler(this.btnTek_Click);
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(558, 12);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.PasswordChar = '*';
            this.txtLogin.Size = new System.Drawing.Size(100, 20);
            this.txtLogin.TabIndex = 6;
            this.txtLogin.UseSystemPasswordChar = true;
            this.txtLogin.Enter += new System.EventHandler(this.txtLogin_Enter);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(558, 38);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(100, 23);
            this.btnLogin.TabIndex = 7;
            this.btnLogin.Text = "LOGİN";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 351);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.btnTek);
            this.Controls.Add(this.btnNot);
            this.Controls.Add(this.btnFinal);
            this.Controls.Add(this.btnKontrol);
            this.Controls.Add(this.btnDeger);
            this.Controls.Add(this.txtDeger);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDeger;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnDeger;
        private System.Windows.Forms.Button btnKontrol;
        private System.Windows.Forms.Button btnFinal;
        private System.Windows.Forms.Button btnNot;
        private System.Windows.Forms.Button btnTek;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Button btnLogin;
    }
}

