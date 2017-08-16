namespace mathClass
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
            this.btnPi = new System.Windows.Forms.Button();
            this.txtPi = new System.Windows.Forms.TextBox();
            this.btnMutlak = new System.Windows.Forms.Button();
            this.btnFloor = new System.Windows.Forms.Button();
            this.btnCeiling = new System.Windows.Forms.Button();
            this.btnRound = new System.Windows.Forms.Button();
            this.btnMax = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtKuvvet = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnPi
            // 
            this.btnPi.Location = new System.Drawing.Point(3, 79);
            this.btnPi.Name = "btnPi";
            this.btnPi.Size = new System.Drawing.Size(75, 23);
            this.btnPi.TabIndex = 0;
            this.btnPi.Text = "Pi";
            this.btnPi.UseVisualStyleBackColor = true;
            this.btnPi.Click += new System.EventHandler(this.btnPi_Click);
            // 
            // txtPi
            // 
            this.txtPi.Location = new System.Drawing.Point(3, 42);
            this.txtPi.Name = "txtPi";
            this.txtPi.Size = new System.Drawing.Size(100, 20);
            this.txtPi.TabIndex = 1;
            // 
            // btnMutlak
            // 
            this.btnMutlak.Location = new System.Drawing.Point(3, 108);
            this.btnMutlak.Name = "btnMutlak";
            this.btnMutlak.Size = new System.Drawing.Size(75, 23);
            this.btnMutlak.TabIndex = 2;
            this.btnMutlak.Text = "Mutlak";
            this.btnMutlak.UseVisualStyleBackColor = true;
            // 
            // btnFloor
            // 
            this.btnFloor.Location = new System.Drawing.Point(84, 79);
            this.btnFloor.Name = "btnFloor";
            this.btnFloor.Size = new System.Drawing.Size(75, 23);
            this.btnFloor.TabIndex = 3;
            this.btnFloor.Text = "Floor";
            this.btnFloor.UseVisualStyleBackColor = true;
            this.btnFloor.Click += new System.EventHandler(this.btnFloor_Click);
            // 
            // btnCeiling
            // 
            this.btnCeiling.Location = new System.Drawing.Point(84, 108);
            this.btnCeiling.Name = "btnCeiling";
            this.btnCeiling.Size = new System.Drawing.Size(75, 23);
            this.btnCeiling.TabIndex = 4;
            this.btnCeiling.Text = "Ceiling";
            this.btnCeiling.UseVisualStyleBackColor = true;
            this.btnCeiling.Click += new System.EventHandler(this.btnCeiling_Click);
            // 
            // btnRound
            // 
            this.btnRound.Location = new System.Drawing.Point(165, 79);
            this.btnRound.Name = "btnRound";
            this.btnRound.Size = new System.Drawing.Size(75, 23);
            this.btnRound.TabIndex = 5;
            this.btnRound.Text = "Round";
            this.btnRound.UseVisualStyleBackColor = true;
            this.btnRound.Click += new System.EventHandler(this.btnRound_Click);
            // 
            // btnMax
            // 
            this.btnMax.Location = new System.Drawing.Point(165, 108);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(75, 23);
            this.btnMax.TabIndex = 6;
            this.btnMax.Text = "Max";
            this.btnMax.UseVisualStyleBackColor = true;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnMin
            // 
            this.btnMin.Location = new System.Drawing.Point(246, 79);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(75, 23);
            this.btnMin.TabIndex = 7;
            this.btnMin.Text = "Min";
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(246, 108);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "sayi kuvvet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtKuvvet
            // 
            this.txtKuvvet.Location = new System.Drawing.Point(109, 42);
            this.txtKuvvet.Name = "txtKuvvet";
            this.txtKuvvet.Size = new System.Drawing.Size(100, 20);
            this.txtKuvvet.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 427);
            this.Controls.Add(this.txtKuvvet);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.btnMax);
            this.Controls.Add(this.btnRound);
            this.Controls.Add(this.btnCeiling);
            this.Controls.Add(this.btnFloor);
            this.Controls.Add(this.btnMutlak);
            this.Controls.Add(this.txtPi);
            this.Controls.Add(this.btnPi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPi;
        private System.Windows.Forms.TextBox txtPi;
        private System.Windows.Forms.Button btnMutlak;
        private System.Windows.Forms.Button btnFloor;
        private System.Windows.Forms.Button btnCeiling;
        private System.Windows.Forms.Button btnRound;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtKuvvet;
    }
}

