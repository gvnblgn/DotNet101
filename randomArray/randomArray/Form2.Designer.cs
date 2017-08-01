namespace randomArray
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
            this.btnYanYana = new System.Windows.Forms.Button();
            this.lblYanYana = new System.Windows.Forms.Label();
            this.btnAltAlta = new System.Windows.Forms.Button();
            this.lblCmd = new System.Windows.Forms.Label();
            this.btnKare = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnYanYana
            // 
            this.btnYanYana.Location = new System.Drawing.Point(34, 34);
            this.btnYanYana.Name = "btnYanYana";
            this.btnYanYana.Size = new System.Drawing.Size(75, 23);
            this.btnYanYana.TabIndex = 0;
            this.btnYanYana.Text = "YanYanaX";
            this.btnYanYana.UseVisualStyleBackColor = true;
            this.btnYanYana.Click += new System.EventHandler(this.btnYanYana_Click);
            // 
            // lblYanYana
            // 
            this.lblYanYana.AutoSize = true;
            this.lblYanYana.Location = new System.Drawing.Point(149, 39);
            this.lblYanYana.Name = "lblYanYana";
            this.lblYanYana.Size = new System.Drawing.Size(14, 13);
            this.lblYanYana.TabIndex = 1;
            this.lblYanYana.Text = "X";
            // 
            // btnAltAlta
            // 
            this.btnAltAlta.Location = new System.Drawing.Point(34, 63);
            this.btnAltAlta.Name = "btnAltAlta";
            this.btnAltAlta.Size = new System.Drawing.Size(75, 23);
            this.btnAltAlta.TabIndex = 2;
            this.btnAltAlta.Text = "AltAltaX";
            this.btnAltAlta.UseVisualStyleBackColor = true;
            this.btnAltAlta.Click += new System.EventHandler(this.btnAltAlta_Click);
            // 
            // lblCmd
            // 
            this.lblCmd.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCmd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCmd.Location = new System.Drawing.Point(31, 166);
            this.lblCmd.Name = "lblCmd";
            this.lblCmd.Size = new System.Drawing.Size(132, 240);
            this.lblCmd.TabIndex = 3;
            // 
            // btnKare
            // 
            this.btnKare.Location = new System.Drawing.Point(34, 92);
            this.btnKare.Name = "btnKare";
            this.btnKare.Size = new System.Drawing.Size(75, 23);
            this.btnKare.TabIndex = 4;
            this.btnKare.Text = "Kare Çiz";
            this.btnKare.UseVisualStyleBackColor = true;
            this.btnKare.Click += new System.EventHandler(this.btnKare_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 432);
            this.Controls.Add(this.btnKare);
            this.Controls.Add(this.lblCmd);
            this.Controls.Add(this.btnAltAlta);
            this.Controls.Add(this.lblYanYana);
            this.Controls.Add(this.btnYanYana);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnYanYana;
        private System.Windows.Forms.Label lblYanYana;
        private System.Windows.Forms.Button btnAltAlta;
        private System.Windows.Forms.Label lblCmd;
        private System.Windows.Forms.Button btnKare;
    }
}