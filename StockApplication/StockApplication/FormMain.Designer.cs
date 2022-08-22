namespace StockApplication
{
    partial class FormMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.müşretiİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniMusteriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockGirişFişiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockÇıkışFişiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayarlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblUserame = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.müşretiİşlemleriToolStripMenuItem,
            this.stockİşlemleriToolStripMenuItem,
            this.ayarlarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(12, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(1185, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // müşretiİşlemleriToolStripMenuItem
            // 
            this.müşretiİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.müşteriListesiToolStripMenuItem,
            this.yeniMusteriToolStripMenuItem});
            this.müşretiİşlemleriToolStripMenuItem.Name = "müşretiİşlemleriToolStripMenuItem";
            this.müşretiİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(106, 19);
            this.müşretiİşlemleriToolStripMenuItem.Text = "Müşreti İşlemleri";
            // 
            // müşteriListesiToolStripMenuItem
            // 
            this.müşteriListesiToolStripMenuItem.Name = "müşteriListesiToolStripMenuItem";
            this.müşteriListesiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.müşteriListesiToolStripMenuItem.Text = "Müşteri Listesi";
            this.müşteriListesiToolStripMenuItem.Click += new System.EventHandler(this.müşteriListesiToolStripMenuItem_Click);
            // 
            // yeniMusteriToolStripMenuItem
            // 
            this.yeniMusteriToolStripMenuItem.Name = "yeniMusteriToolStripMenuItem";
            this.yeniMusteriToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.yeniMusteriToolStripMenuItem.Text = "Yeni Müşteri";
            this.yeniMusteriToolStripMenuItem.Click += new System.EventHandler(this.yeniMusteriToolStripMenuItem_Click);
            // 
            // stockİşlemleriToolStripMenuItem
            // 
            this.stockİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stockGirişFişiToolStripMenuItem,
            this.stockÇıkışFişiToolStripMenuItem});
            this.stockİşlemleriToolStripMenuItem.Name = "stockİşlemleriToolStripMenuItem";
            this.stockİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(95, 19);
            this.stockİşlemleriToolStripMenuItem.Text = "Stock İşlemleri";
            // 
            // stockGirişFişiToolStripMenuItem
            // 
            this.stockGirişFişiToolStripMenuItem.Name = "stockGirişFişiToolStripMenuItem";
            this.stockGirişFişiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.stockGirişFişiToolStripMenuItem.Text = "Stock Giriş Fişi";
            // 
            // stockÇıkışFişiToolStripMenuItem
            // 
            this.stockÇıkışFişiToolStripMenuItem.Name = "stockÇıkışFişiToolStripMenuItem";
            this.stockÇıkışFişiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.stockÇıkışFişiToolStripMenuItem.Text = "Stock Çıkış Fişi";
            // 
            // ayarlarToolStripMenuItem
            // 
            this.ayarlarToolStripMenuItem.Name = "ayarlarToolStripMenuItem";
            this.ayarlarToolStripMenuItem.Size = new System.Drawing.Size(56, 19);
            this.ayarlarToolStripMenuItem.Text = "Ayarlar";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblUserame);
            this.panel1.Controls.Add(this.lblUserName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 690);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1244, 45);
            this.panel1.TabIndex = 1;
            // 
            // lblUserame
            // 
            this.lblUserame.AutoSize = true;
            this.lblUserame.Location = new System.Drawing.Point(1079, 0);
            this.lblUserame.Name = "lblUserame";
            this.lblUserame.Size = new System.Drawing.Size(110, 17);
            this.lblUserame.TabIndex = 2;
            this.lblUserame.Text = "LabelUserName";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(1129, 0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(0, 17);
            this.lblUserName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Yaren Kasımoğlu";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 713);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock Application";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem stockGirişFişiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockÇıkışFişiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayarlarToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ToolStripMenuItem müşretiİşlemleriToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem stockİşlemleriToolStripMenuItem;
        public System.Windows.Forms.Label lblUserame;
        private System.Windows.Forms.ToolStripMenuItem müşteriListesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniMusteriToolStripMenuItem;
    }
}