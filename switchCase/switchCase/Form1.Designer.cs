namespace switchCase
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
            this.cbMevsim = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cbMevsim
            // 
            this.cbMevsim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMevsim.FormattingEnabled = true;
            this.cbMevsim.Location = new System.Drawing.Point(0, 0);
            this.cbMevsim.Name = "cbMevsim";
            this.cbMevsim.Size = new System.Drawing.Size(208, 21);
            this.cbMevsim.TabIndex = 0;
            this.cbMevsim.SelectedIndexChanged += new System.EventHandler(this.cbMevsim_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.cbMevsim);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbMevsim;
    }
}

