namespace modIki
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
            this.txtMod = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnMod = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnOyun = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMod
            // 
            this.txtMod.Location = new System.Drawing.Point(0, 0);
            this.txtMod.Name = "txtMod";
            this.txtMod.Size = new System.Drawing.Size(124, 20);
            this.txtMod.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnMod
            // 
            this.btnMod.Location = new System.Drawing.Point(0, 37);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(124, 23);
            this.btnMod.TabIndex = 2;
            this.btnMod.Text = "2LI BASAMAKTA YAZ";
            this.btnMod.UseVisualStyleBackColor = true;
            this.btnMod.Click += new System.EventHandler(this.btnMod_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(299, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(287, 381);
            this.listBox1.TabIndex = 3;
            // 
            // btnOyun
            // 
            this.btnOyun.Location = new System.Drawing.Point(0, 85);
            this.btnOyun.Name = "btnOyun";
            this.btnOyun.Size = new System.Drawing.Size(124, 23);
            this.btnOyun.TabIndex = 4;
            this.btnOyun.Text = "Oyun";
            this.btnOyun.UseVisualStyleBackColor = true;
            this.btnOyun.Click += new System.EventHandler(this.btnOyun_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 407);
            this.Controls.Add(this.btnOyun);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnMod);
            this.Controls.Add(this.txtMod);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMod;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnMod;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnOyun;
    }
}

