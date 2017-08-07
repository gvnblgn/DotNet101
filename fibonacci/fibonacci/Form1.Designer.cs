namespace fibonacci
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
            this.txtIndex = new System.Windows.Forms.TextBox();
            this.lbIndex = new System.Windows.Forms.Label();
            this.lbFibonacci = new System.Windows.Forms.ListBox();
            this.btnIndex = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtIndex
            // 
            this.txtIndex.Location = new System.Drawing.Point(186, 12);
            this.txtIndex.Name = "txtIndex";
            this.txtIndex.Size = new System.Drawing.Size(100, 20);
            this.txtIndex.TabIndex = 0;
            // 
            // lbIndex
            // 
            this.lbIndex.AutoSize = true;
            this.lbIndex.Location = new System.Drawing.Point(13, 12);
            this.lbIndex.Name = "lbIndex";
            this.lbIndex.Size = new System.Drawing.Size(161, 13);
            this.lbIndex.TabIndex = 1;
            this.lbIndex.Text = "Lutfen Fibonacci indexini Giriniz :";
            // 
            // lbFibonacci
            // 
            this.lbFibonacci.FormattingEnabled = true;
            this.lbFibonacci.Location = new System.Drawing.Point(335, 12);
            this.lbFibonacci.Name = "lbFibonacci";
            this.lbFibonacci.Size = new System.Drawing.Size(231, 433);
            this.lbFibonacci.TabIndex = 2;
            // 
            // btnIndex
            // 
            this.btnIndex.Location = new System.Drawing.Point(186, 77);
            this.btnIndex.Name = "btnIndex";
            this.btnIndex.Size = new System.Drawing.Size(100, 23);
            this.btnIndex.TabIndex = 3;
            this.btnIndex.Text = "Index i Bul";
            this.btnIndex.UseVisualStyleBackColor = true;
            this.btnIndex.Click += new System.EventHandler(this.btnIndex_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(186, 106);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 23);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Ekran Temizle";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 466);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnIndex);
            this.Controls.Add(this.lbFibonacci);
            this.Controls.Add(this.lbIndex);
            this.Controls.Add(this.txtIndex);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIndex;
        private System.Windows.Forms.Label lbIndex;
        private System.Windows.Forms.ListBox lbFibonacci;
        private System.Windows.Forms.Button btnIndex;
        private System.Windows.Forms.Button btnClear;
    }
}

