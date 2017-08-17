namespace outReffParams
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnOut_2 = new System.Windows.Forms.Button();
            this.btnOut_3 = new System.Windows.Forms.Button();
            this.btnRef = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(241, 85);
            this.button1.TabIndex = 0;
            this.button1.Text = "Out1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnOut_2
            // 
            this.btnOut_2.Location = new System.Drawing.Point(0, 91);
            this.btnOut_2.Name = "btnOut_2";
            this.btnOut_2.Size = new System.Drawing.Size(241, 85);
            this.btnOut_2.TabIndex = 1;
            this.btnOut_2.Text = "Out 2";
            this.btnOut_2.UseVisualStyleBackColor = true;
            this.btnOut_2.Click += new System.EventHandler(this.btnOut_2_Click);
            // 
            // btnOut_3
            // 
            this.btnOut_3.Location = new System.Drawing.Point(0, 182);
            this.btnOut_3.Name = "btnOut_3";
            this.btnOut_3.Size = new System.Drawing.Size(241, 85);
            this.btnOut_3.TabIndex = 2;
            this.btnOut_3.Text = "Out 3";
            this.btnOut_3.UseVisualStyleBackColor = true;
            this.btnOut_3.Click += new System.EventHandler(this.btnOut_3_Click);
            // 
            // btnRef
            // 
            this.btnRef.Location = new System.Drawing.Point(0, 273);
            this.btnRef.Name = "btnRef";
            this.btnRef.Size = new System.Drawing.Size(241, 85);
            this.btnRef.TabIndex = 3;
            this.btnRef.Text = "REF";
            this.btnRef.UseVisualStyleBackColor = true;
            this.btnRef.Click += new System.EventHandler(this.btnRef_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 432);
            this.Controls.Add(this.btnRef);
            this.Controls.Add(this.btnOut_3);
            this.Controls.Add(this.btnOut_2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnOut_2;
        private System.Windows.Forms.Button btnOut_3;
        private System.Windows.Forms.Button btnRef;
    }
}

