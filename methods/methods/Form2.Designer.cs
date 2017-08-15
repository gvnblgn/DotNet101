namespace methods
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
            this.num1 = new System.Windows.Forms.NumericUpDown();
            this.num2 = new System.Windows.Forms.NumericUpDown();
            this.btnTopla = new System.Windows.Forms.Button();
            this.btnCiftTek = new System.Windows.Forms.Button();
            this.txtSayi = new System.Windows.Forms.TextBox();
            this.btnRandom = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnRandomColor = new System.Windows.Forms.Button();
            this.btnRenkBul = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.num1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num2)).BeginInit();
            this.SuspendLayout();
            // 
            // num1
            // 
            this.num1.Location = new System.Drawing.Point(0, 0);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(120, 20);
            this.num1.TabIndex = 0;
            // 
            // num2
            // 
            this.num2.Location = new System.Drawing.Point(160, 0);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(120, 20);
            this.num2.TabIndex = 1;
            // 
            // btnTopla
            // 
            this.btnTopla.Location = new System.Drawing.Point(0, 49);
            this.btnTopla.Name = "btnTopla";
            this.btnTopla.Size = new System.Drawing.Size(280, 23);
            this.btnTopla.TabIndex = 2;
            this.btnTopla.Text = "TOPLA";
            this.btnTopla.UseVisualStyleBackColor = true;
            this.btnTopla.Click += new System.EventHandler(this.btnTopla_Click);
            // 
            // btnCiftTek
            // 
            this.btnCiftTek.Location = new System.Drawing.Point(0, 90);
            this.btnCiftTek.Name = "btnCiftTek";
            this.btnCiftTek.Size = new System.Drawing.Size(280, 23);
            this.btnCiftTek.TabIndex = 3;
            this.btnCiftTek.Text = "ÇİFT TEK";
            this.btnCiftTek.UseVisualStyleBackColor = true;
            this.btnCiftTek.Click += new System.EventHandler(this.btnCiftTek_Click);
            // 
            // txtSayi
            // 
            this.txtSayi.Location = new System.Drawing.Point(12, 23);
            this.txtSayi.Name = "txtSayi";
            this.txtSayi.Size = new System.Drawing.Size(256, 20);
            this.txtSayi.TabIndex = 4;
            // 
            // btnRandom
            // 
            this.btnRandom.Location = new System.Drawing.Point(0, 119);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(280, 23);
            this.btnRandom.TabIndex = 5;
            this.btnRandom.Text = "random";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Blue",
            "Gray",
            "White",
            "Yellow",
            "Black",
            "Morron",
            "Orange",
            "Red",
            "Green"});
            this.comboBox1.Location = new System.Drawing.Point(-1, 148);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnRandomColor
            // 
            this.btnRandomColor.Location = new System.Drawing.Point(0, 175);
            this.btnRandomColor.Name = "btnRandomColor";
            this.btnRandomColor.Size = new System.Drawing.Size(280, 23);
            this.btnRandomColor.TabIndex = 7;
            this.btnRandomColor.Text = "random Color";
            this.btnRandomColor.UseVisualStyleBackColor = true;
            this.btnRandomColor.Click += new System.EventHandler(this.btnRandomColor_Click);
            // 
            // btnRenkBul
            // 
            this.btnRenkBul.Location = new System.Drawing.Point(0, 204);
            this.btnRenkBul.Name = "btnRenkBul";
            this.btnRenkBul.Size = new System.Drawing.Size(280, 23);
            this.btnRenkBul.TabIndex = 8;
            this.btnRenkBul.Text = "Renk Neymiş";
            this.btnRenkBul.UseVisualStyleBackColor = true;
            this.btnRenkBul.Click += new System.EventHandler(this.btnRenkBul_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 431);
            this.Controls.Add(this.btnRenkBul);
            this.Controls.Add(this.btnRandomColor);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.txtSayi);
            this.Controls.Add(this.btnCiftTek);
            this.Controls.Add(this.btnTopla);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.num1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown num1;
        private System.Windows.Forms.NumericUpDown num2;
        private System.Windows.Forms.Button btnTopla;
        private System.Windows.Forms.Button btnCiftTek;
        private System.Windows.Forms.TextBox txtSayi;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnRandomColor;
        private System.Windows.Forms.Button btnRenkBul;
    }
}