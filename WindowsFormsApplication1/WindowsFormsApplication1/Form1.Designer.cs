namespace WindowsFormsApplication1
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
            this.btnToplama = new System.Windows.Forms.Button();
            this.btnCikarma = new System.Windows.Forms.Button();
            this.btnCarpma = new System.Windows.Forms.Button();
            this.btnBolme = new System.Windows.Forms.Button();
            this.btnMod = new System.Windows.Forms.Button();
            this.btnFunc = new System.Windows.Forms.Button();
            this.btnArt = new System.Windows.Forms.Button();
            this.btnAz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnToplama
            // 
            this.btnToplama.Location = new System.Drawing.Point(0, 1);
            this.btnToplama.Name = "btnToplama";
            this.btnToplama.Size = new System.Drawing.Size(283, 50);
            this.btnToplama.TabIndex = 0;
            this.btnToplama.Text = "Toplama";
            this.btnToplama.UseVisualStyleBackColor = true;
            this.btnToplama.Click += new System.EventHandler(this.btnToplama_Click);
            // 
            // btnCikarma
            // 
            this.btnCikarma.Location = new System.Drawing.Point(0, 57);
            this.btnCikarma.Name = "btnCikarma";
            this.btnCikarma.Size = new System.Drawing.Size(283, 55);
            this.btnCikarma.TabIndex = 1;
            this.btnCikarma.Text = "Çıkarma";
            this.btnCikarma.UseVisualStyleBackColor = true;
            this.btnCikarma.Click += new System.EventHandler(this.btnCikarma_Click);
            // 
            // btnCarpma
            // 
            this.btnCarpma.Location = new System.Drawing.Point(0, 118);
            this.btnCarpma.Name = "btnCarpma";
            this.btnCarpma.Size = new System.Drawing.Size(283, 55);
            this.btnCarpma.TabIndex = 2;
            this.btnCarpma.Text = "Çarpma";
            this.btnCarpma.UseVisualStyleBackColor = true;
            this.btnCarpma.Click += new System.EventHandler(this.btnCarpma_Click);
            // 
            // btnBolme
            // 
            this.btnBolme.Location = new System.Drawing.Point(0, 179);
            this.btnBolme.Name = "btnBolme";
            this.btnBolme.Size = new System.Drawing.Size(283, 55);
            this.btnBolme.TabIndex = 3;
            this.btnBolme.Text = "Bölme";
            this.btnBolme.UseVisualStyleBackColor = true;
            this.btnBolme.Click += new System.EventHandler(this.btnBolme_Click);
            // 
            // btnMod
            // 
            this.btnMod.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnMod.Location = new System.Drawing.Point(289, 1);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(283, 50);
            this.btnMod.TabIndex = 4;
            this.btnMod.Text = "Mod";
            this.btnMod.UseVisualStyleBackColor = false;
            this.btnMod.Click += new System.EventHandler(this.btnMod_Click);
            // 
            // btnFunc
            // 
            this.btnFunc.Location = new System.Drawing.Point(289, 57);
            this.btnFunc.Name = "btnFunc";
            this.btnFunc.Size = new System.Drawing.Size(283, 55);
            this.btnFunc.TabIndex = 5;
            this.btnFunc.Text = "Faktoriyel";
            this.btnFunc.UseVisualStyleBackColor = true;
            // 
            // btnArt
            // 
            this.btnArt.Location = new System.Drawing.Point(289, 118);
            this.btnArt.Name = "btnArt";
            this.btnArt.Size = new System.Drawing.Size(283, 55);
            this.btnArt.TabIndex = 6;
            this.btnArt.Text = "Arttır";
            this.btnArt.UseVisualStyleBackColor = true;
            this.btnArt.Click += new System.EventHandler(this.btnArt_Click);
            // 
            // btnAz
            // 
            this.btnAz.Location = new System.Drawing.Point(289, 181);
            this.btnAz.Name = "btnAz";
            this.btnAz.Size = new System.Drawing.Size(283, 53);
            this.btnAz.TabIndex = 7;
            this.btnAz.Text = "Azalt";
            this.btnAz.UseVisualStyleBackColor = true;
            this.btnAz.Click += new System.EventHandler(this.btnAz_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 238);
            this.Controls.Add(this.btnAz);
            this.Controls.Add(this.btnArt);
            this.Controls.Add(this.btnFunc);
            this.Controls.Add(this.btnMod);
            this.Controls.Add(this.btnBolme);
            this.Controls.Add(this.btnCarpma);
            this.Controls.Add(this.btnCikarma);
            this.Controls.Add(this.btnToplama);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnToplama;
        private System.Windows.Forms.Button btnCikarma;
        private System.Windows.Forms.Button btnCarpma;
        private System.Windows.Forms.Button btnBolme;
        private System.Windows.Forms.Button btnMod;
        private System.Windows.Forms.Button btnFunc;
        private System.Windows.Forms.Button btnArt;
        private System.Windows.Forms.Button btnAz;
    }
}

