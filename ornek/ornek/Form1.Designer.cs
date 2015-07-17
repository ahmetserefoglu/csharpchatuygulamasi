namespace ornek
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
            this.bhkayit = new System.Windows.Forms.Button();
            this.bdoktor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bhkayit
            // 
            this.bhkayit.Location = new System.Drawing.Point(53, 84);
            this.bhkayit.Name = "bhkayit";
            this.bhkayit.Size = new System.Drawing.Size(87, 68);
            this.bhkayit.TabIndex = 0;
            this.bhkayit.Text = "Hasta Kayıt";
            this.bhkayit.UseVisualStyleBackColor = true;
            this.bhkayit.Click += new System.EventHandler(this.bhkayit_Click);
            // 
            // bdoktor
            // 
            this.bdoktor.Location = new System.Drawing.Point(158, 84);
            this.bdoktor.Name = "bdoktor";
            this.bdoktor.Size = new System.Drawing.Size(87, 68);
            this.bdoktor.TabIndex = 1;
            this.bdoktor.Text = "Doktor";
            this.bdoktor.UseVisualStyleBackColor = true;
            this.bdoktor.Click += new System.EventHandler(this.bdoktor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.bdoktor);
            this.Controls.Add(this.bhkayit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bhkayit;
        private System.Windows.Forms.Button bdoktor;
    }
}

