namespace odev_2
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
            this.lblBilgi = new System.Windows.Forms.Label();
            this.txtDene = new System.Windows.Forms.TextBox();
            this.btnDene = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBilgi
            // 
            this.lblBilgi.AutoSize = true;
            this.lblBilgi.Location = new System.Drawing.Point(12, 24);
            this.lblBilgi.Name = "lblBilgi";
            this.lblBilgi.Size = new System.Drawing.Size(241, 13);
            this.lblBilgi.TabIndex = 0;
            this.lblBilgi.Text = "Lütfen tahmin ettiğiniz sayıyı girip deneye basınız : ";
            // 
            // txtDene
            // 
            this.txtDene.Location = new System.Drawing.Point(15, 40);
            this.txtDene.Name = "txtDene";
            this.txtDene.Size = new System.Drawing.Size(100, 20);
            this.txtDene.TabIndex = 1;
            // 
            // btnDene
            // 
            this.btnDene.Location = new System.Drawing.Point(15, 66);
            this.btnDene.Name = "btnDene";
            this.btnDene.Size = new System.Drawing.Size(75, 23);
            this.btnDene.TabIndex = 2;
            this.btnDene.Text = "Dene";
            this.btnDene.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 411);
            this.Controls.Add(this.btnDene);
            this.Controls.Add(this.txtDene);
            this.Controls.Add(this.lblBilgi);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBilgi;
        private System.Windows.Forms.TextBox txtDene;
        private System.Windows.Forms.Button btnDene;
    }
}