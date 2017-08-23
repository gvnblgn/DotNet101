namespace GuvenBilgin_Odev2_2
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
            this.btnUc = new System.Windows.Forms.Button();
            this.btnDort = new System.Windows.Forms.Button();
            this.btnBes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUc
            // 
            this.btnUc.BackColor = System.Drawing.Color.Gold;
            this.btnUc.Location = new System.Drawing.Point(12, 21);
            this.btnUc.Name = "btnUc";
            this.btnUc.Size = new System.Drawing.Size(128, 53);
            this.btnUc.TabIndex = 0;
            this.btnUc.Text = "3 sayının En Büyüğü";
            this.btnUc.UseVisualStyleBackColor = false;
            this.btnUc.Click += new System.EventHandler(this.btnUc_Click);
            // 
            // btnDort
            // 
            this.btnDort.BackColor = System.Drawing.Color.Gold;
            this.btnDort.Location = new System.Drawing.Point(12, 80);
            this.btnDort.Name = "btnDort";
            this.btnDort.Size = new System.Drawing.Size(128, 53);
            this.btnDort.TabIndex = 1;
            this.btnDort.Text = "4 sayının En Büyüğü";
            this.btnDort.UseVisualStyleBackColor = false;
            this.btnDort.Click += new System.EventHandler(this.btnDort_Click);
            // 
            // btnBes
            // 
            this.btnBes.BackColor = System.Drawing.Color.Gold;
            this.btnBes.Location = new System.Drawing.Point(12, 139);
            this.btnBes.Name = "btnBes";
            this.btnBes.Size = new System.Drawing.Size(128, 53);
            this.btnBes.TabIndex = 2;
            this.btnBes.Text = "5 sayının En Büyüğü";
            this.btnBes.UseVisualStyleBackColor = false;
            this.btnBes.Click += new System.EventHandler(this.btnBes_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(156, 207);
            this.Controls.Add(this.btnBes);
            this.Controls.Add(this.btnDort);
            this.Controls.Add(this.btnUc);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUc;
        private System.Windows.Forms.Button btnDort;
        private System.Windows.Forms.Button btnBes;
    }
}

