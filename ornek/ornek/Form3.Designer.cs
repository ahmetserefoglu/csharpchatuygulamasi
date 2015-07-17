namespace ornek
{
    partial class Form3
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
            this.ltc = new System.Windows.Forms.ListBox();
            this.ladsoyad = new System.Windows.Forms.ListBox();
            this.ldoktor = new System.Windows.Forms.ListBox();
            this.ttc = new System.Windows.Forms.TextBox();
            this.tadsoyad = new System.Windows.Forms.TextBox();
            this.cdoktor = new System.Windows.Forms.ComboBox();
            this.bekle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ltc
            // 
            this.ltc.FormattingEnabled = true;
            this.ltc.Location = new System.Drawing.Point(6, 12);
            this.ltc.Name = "ltc";
            this.ltc.Size = new System.Drawing.Size(72, 186);
            this.ltc.TabIndex = 0;
            // 
            // ladsoyad
            // 
            this.ladsoyad.FormattingEnabled = true;
            this.ladsoyad.Location = new System.Drawing.Point(84, 12);
            this.ladsoyad.Name = "ladsoyad";
            this.ladsoyad.Size = new System.Drawing.Size(112, 186);
            this.ladsoyad.TabIndex = 1;
            // 
            // ldoktor
            // 
            this.ldoktor.FormattingEnabled = true;
            this.ldoktor.Location = new System.Drawing.Point(202, 12);
            this.ldoktor.Name = "ldoktor";
            this.ldoktor.Size = new System.Drawing.Size(112, 186);
            this.ldoktor.TabIndex = 2;
            // 
            // ttc
            // 
            this.ttc.Location = new System.Drawing.Point(6, 233);
            this.ttc.Name = "ttc";
            this.ttc.Size = new System.Drawing.Size(72, 20);
            this.ttc.TabIndex = 3;
            // 
            // tadsoyad
            // 
            this.tadsoyad.Location = new System.Drawing.Point(84, 233);
            this.tadsoyad.Name = "tadsoyad";
            this.tadsoyad.Size = new System.Drawing.Size(112, 20);
            this.tadsoyad.TabIndex = 4;
            // 
            // cdoktor
            // 
            this.cdoktor.FormattingEnabled = true;
            this.cdoktor.Location = new System.Drawing.Point(202, 233);
            this.cdoktor.Name = "cdoktor";
            this.cdoktor.Size = new System.Drawing.Size(112, 21);
            this.cdoktor.TabIndex = 5;
            // 
            // bekle
            // 
            this.bekle.Location = new System.Drawing.Point(202, 280);
            this.bekle.Name = "bekle";
            this.bekle.Size = new System.Drawing.Size(112, 33);
            this.bekle.TabIndex = 6;
            this.bekle.Text = "Ekle";
            this.bekle.UseVisualStyleBackColor = true;
            this.bekle.Click += new System.EventHandler(this.bekle_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 336);
            this.Controls.Add(this.bekle);
            this.Controls.Add(this.cdoktor);
            this.Controls.Add(this.tadsoyad);
            this.Controls.Add(this.ttc);
            this.Controls.Add(this.ldoktor);
            this.Controls.Add(this.ladsoyad);
            this.Controls.Add(this.ltc);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ltc;
        private System.Windows.Forms.ListBox ladsoyad;
        private System.Windows.Forms.ListBox ldoktor;
        private System.Windows.Forms.TextBox ttc;
        private System.Windows.Forms.TextBox tadsoyad;
        private System.Windows.Forms.ComboBox cdoktor;
        private System.Windows.Forms.Button bekle;
    }
}