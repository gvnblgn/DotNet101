namespace indexOfArray
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
            this.btnVar = new System.Windows.Forms.Button();
            this.txtVar = new System.Windows.Forms.TextBox();
            this.lbSort = new System.Windows.Forms.ListBox();
            this.btnSort = new System.Windows.Forms.Button();
            this.btnReverse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVar
            // 
            this.btnVar.Location = new System.Drawing.Point(39, 75);
            this.btnVar.Name = "btnVar";
            this.btnVar.Size = new System.Drawing.Size(75, 23);
            this.btnVar.TabIndex = 0;
            this.btnVar.Text = "Var mı?";
            this.btnVar.UseVisualStyleBackColor = true;
            this.btnVar.Click += new System.EventHandler(this.btnVar_Click);
            // 
            // txtVar
            // 
            this.txtVar.Location = new System.Drawing.Point(39, 35);
            this.txtVar.Name = "txtVar";
            this.txtVar.Size = new System.Drawing.Size(100, 20);
            this.txtVar.TabIndex = 1;
            // 
            // lbSort
            // 
            this.lbSort.FormattingEnabled = true;
            this.lbSort.Location = new System.Drawing.Point(253, 3);
            this.lbSort.Name = "lbSort";
            this.lbSort.Size = new System.Drawing.Size(224, 329);
            this.lbSort.TabIndex = 2;
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(39, 113);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(75, 23);
            this.btnSort.TabIndex = 3;
            this.btnSort.Text = "Sırala";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // btnReverse
            // 
            this.btnReverse.Location = new System.Drawing.Point(39, 158);
            this.btnReverse.Name = "btnReverse";
            this.btnReverse.Size = new System.Drawing.Size(75, 23);
            this.btnReverse.TabIndex = 4;
            this.btnReverse.Text = "tersten";
            this.btnReverse.UseVisualStyleBackColor = true;
            this.btnReverse.Click += new System.EventHandler(this.btnReverse_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 422);
            this.Controls.Add(this.btnReverse);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.lbSort);
            this.Controls.Add(this.txtVar);
            this.Controls.Add(this.btnVar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVar;
        private System.Windows.Forms.TextBox txtVar;
        private System.Windows.Forms.ListBox lbSort;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Button btnReverse;
    }
}

