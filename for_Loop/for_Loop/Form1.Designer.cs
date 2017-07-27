namespace for_Loop
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
            this.lbEkran = new System.Windows.Forms.ListBox();
            this.btnBirBin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbEkran
            // 
            this.lbEkran.FormattingEnabled = true;
            this.lbEkran.Location = new System.Drawing.Point(137, 8);
            this.lbEkran.Name = "lbEkran";
            this.lbEkran.Size = new System.Drawing.Size(166, 368);
            this.lbEkran.TabIndex = 0;
            // 
            // btnBirBin
            // 
            this.btnBirBin.Location = new System.Drawing.Point(8, 8);
            this.btnBirBin.Name = "btnBirBin";
            this.btnBirBin.Size = new System.Drawing.Size(123, 37);
            this.btnBirBin.TabIndex = 1;
            this.btnBirBin.Text = "1-1000";
            this.btnBirBin.UseVisualStyleBackColor = true;
            this.btnBirBin.Click += new System.EventHandler(this.btnBirBin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 418);
            this.Controls.Add(this.btnBirBin);
            this.Controls.Add(this.lbEkran);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbEkran;
        private System.Windows.Forms.Button btnBirBin;
    }
}

