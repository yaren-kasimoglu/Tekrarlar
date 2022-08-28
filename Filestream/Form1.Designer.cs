namespace Filestream
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
            this.btnDosyaSec = new System.Windows.Forms.Button();
            this.btnDosyayaYaz = new System.Windows.Forms.Button();
            this.btnDosyadanOku = new System.Windows.Forms.Button();
            this.txtDosyaAdi = new System.Windows.Forms.TextBox();
            this.txtMetin = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnDosyaSec
            // 
            this.btnDosyaSec.Location = new System.Drawing.Point(626, 63);
            this.btnDosyaSec.Name = "btnDosyaSec";
            this.btnDosyaSec.Size = new System.Drawing.Size(175, 105);
            this.btnDosyaSec.TabIndex = 0;
            this.btnDosyaSec.Text = "DosyaSeç";
            this.btnDosyaSec.UseVisualStyleBackColor = true;
            this.btnDosyaSec.Click += new System.EventHandler(this.btnDosyaSec_Click);
            // 
            // btnDosyayaYaz
            // 
            this.btnDosyayaYaz.Location = new System.Drawing.Point(626, 223);
            this.btnDosyayaYaz.Name = "btnDosyayaYaz";
            this.btnDosyayaYaz.Size = new System.Drawing.Size(175, 105);
            this.btnDosyayaYaz.TabIndex = 1;
            this.btnDosyayaYaz.Text = "Dosyaya Yaz";
            this.btnDosyayaYaz.UseVisualStyleBackColor = true;
            this.btnDosyayaYaz.Click += new System.EventHandler(this.btnDosyayaYaz_Click);
            // 
            // btnDosyadanOku
            // 
            this.btnDosyadanOku.Location = new System.Drawing.Point(626, 392);
            this.btnDosyadanOku.Name = "btnDosyadanOku";
            this.btnDosyadanOku.Size = new System.Drawing.Size(175, 105);
            this.btnDosyadanOku.TabIndex = 2;
            this.btnDosyadanOku.Text = "Dosyadan Oku";
            this.btnDosyadanOku.UseVisualStyleBackColor = true;
            this.btnDosyadanOku.Click += new System.EventHandler(this.btnDosyadanOku_Click);
            // 
            // txtDosyaAdi
            // 
            this.txtDosyaAdi.Location = new System.Drawing.Point(65, 59);
            this.txtDosyaAdi.Name = "txtDosyaAdi";
            this.txtDosyaAdi.Size = new System.Drawing.Size(379, 26);
            this.txtDosyaAdi.TabIndex = 3;
            // 
            // txtMetin
            // 
            this.txtMetin.Location = new System.Drawing.Point(47, 302);
            this.txtMetin.Name = "txtMetin";
            this.txtMetin.Size = new System.Drawing.Size(493, 275);
            this.txtMetin.TabIndex = 4;
            this.txtMetin.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 670);
            this.Controls.Add(this.txtMetin);
            this.Controls.Add(this.txtDosyaAdi);
            this.Controls.Add(this.btnDosyadanOku);
            this.Controls.Add(this.btnDosyayaYaz);
            this.Controls.Add(this.btnDosyaSec);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDosyaSec;
        private System.Windows.Forms.Button btnDosyayaYaz;
        private System.Windows.Forms.Button btnDosyadanOku;
        private System.Windows.Forms.TextBox txtDosyaAdi;
        private System.Windows.Forms.RichTextBox txtMetin;
    }
}

