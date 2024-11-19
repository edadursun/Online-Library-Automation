namespace KitapProje
{
    partial class MainPage
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
            this.mi_islemler = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_yazarlar = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_yayinevleri = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_turler = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_kitaplar = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_yorumekle = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_raporlar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mi_islemler,
            this.mi_yorumekle,
            this.mi_raporlar});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(829, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mi_islemler
            // 
            this.mi_islemler.BackColor = System.Drawing.SystemColors.ControlDark;
            this.mi_islemler.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mi_yazarlar,
            this.mi_yayinevleri,
            this.mi_turler,
            this.mi_kitaplar});
            this.mi_islemler.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.mi_islemler.Name = "mi_islemler";
            this.mi_islemler.Size = new System.Drawing.Size(68, 23);
            this.mi_islemler.Text = "İşlemler";
            // 
            // mi_yazarlar
            // 
            this.mi_yazarlar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.mi_yazarlar.Name = "mi_yazarlar";
            this.mi_yazarlar.Size = new System.Drawing.Size(142, 24);
            this.mi_yazarlar.Text = "Yazarlar";
            this.mi_yazarlar.Click += new System.EventHandler(this.mi_yazarlar_Click);
            // 
            // mi_yayinevleri
            // 
            this.mi_yayinevleri.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.mi_yayinevleri.Name = "mi_yayinevleri";
            this.mi_yayinevleri.Size = new System.Drawing.Size(142, 24);
            this.mi_yayinevleri.Text = "Yayınevleri";
            this.mi_yayinevleri.Click += new System.EventHandler(this.mi_yayinevleri_Click);
            // 
            // mi_turler
            // 
            this.mi_turler.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.mi_turler.Name = "mi_turler";
            this.mi_turler.Size = new System.Drawing.Size(142, 24);
            this.mi_turler.Text = "Türler";
            this.mi_turler.Click += new System.EventHandler(this.mi_turler_Click);
            // 
            // mi_kitaplar
            // 
            this.mi_kitaplar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.mi_kitaplar.Name = "mi_kitaplar";
            this.mi_kitaplar.Size = new System.Drawing.Size(142, 24);
            this.mi_kitaplar.Text = "Kitaplar";
            this.mi_kitaplar.Click += new System.EventHandler(this.mi_kitaplar_Click);
            // 
            // mi_yorumekle
            // 
            this.mi_yorumekle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.mi_yorumekle.Name = "mi_yorumekle";
            this.mi_yorumekle.Size = new System.Drawing.Size(89, 23);
            this.mi_yorumekle.Text = "Yorum Ekle";
            this.mi_yorumekle.Click += new System.EventHandler(this.mi_yorumekle_Click);
            // 
            // mi_raporlar
            // 
            this.mi_raporlar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.mi_raporlar.Name = "mi_raporlar";
            this.mi_raporlar.Size = new System.Drawing.Size(72, 23);
            this.mi_raporlar.Text = "Raporlar";
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 461);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Menü";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainPage_FormClosing);
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mi_islemler;
        private System.Windows.Forms.ToolStripMenuItem mi_yazarlar;
        private System.Windows.Forms.ToolStripMenuItem mi_yayinevleri;
        private System.Windows.Forms.ToolStripMenuItem mi_turler;
        private System.Windows.Forms.ToolStripMenuItem mi_kitaplar;
        private System.Windows.Forms.ToolStripMenuItem mi_yorumekle;
        private System.Windows.Forms.ToolStripMenuItem mi_raporlar;
    }
}