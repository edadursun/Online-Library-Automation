namespace KitapProje
{
    partial class Form_Yorumlar
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
            this.grb_yorumlar = new System.Windows.Forms.GroupBox();
            this.btn_Sil = new System.Windows.Forms.Button();
            this.btn_Sorgula = new System.Windows.Forms.Button();
            this.grp_yorumIslemler = new System.Windows.Forms.GroupBox();
            this.btn_Guncelle = new System.Windows.Forms.Button();
            this.btn_Ekle = new System.Windows.Forms.Button();
            this.txt_yorumId = new CustomControls.MyControls.StringControl();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_yorum = new System.Windows.Forms.TextBox();
            this.dg_yorumlar = new System.Windows.Forms.DataGridView();
            this.comment_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commenter_mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.book_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_kitaplar = new System.Windows.Forms.ComboBox();
            this.grb_yorumlar.SuspendLayout();
            this.grp_yorumIslemler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_yorumlar)).BeginInit();
            this.SuspendLayout();
            // 
            // grb_yorumlar
            // 
            this.grb_yorumlar.Controls.Add(this.btn_Sil);
            this.grb_yorumlar.Controls.Add(this.btn_Sorgula);
            this.grb_yorumlar.Controls.Add(this.grp_yorumIslemler);
            this.grb_yorumlar.Controls.Add(this.dg_yorumlar);
            this.grb_yorumlar.Controls.Add(this.label1);
            this.grb_yorumlar.Controls.Add(this.cmb_kitaplar);
            this.grb_yorumlar.Location = new System.Drawing.Point(12, 12);
            this.grb_yorumlar.Name = "grb_yorumlar";
            this.grb_yorumlar.Size = new System.Drawing.Size(776, 426);
            this.grb_yorumlar.TabIndex = 0;
            this.grb_yorumlar.TabStop = false;
            this.grb_yorumlar.Text = "Yorumlar";
            // 
            // btn_Sil
            // 
            this.btn_Sil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Sil.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Sil.Location = new System.Drawing.Point(647, 132);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.Size = new System.Drawing.Size(95, 27);
            this.btn_Sil.TabIndex = 5;
            this.btn_Sil.Text = "Sil";
            this.btn_Sil.UseVisualStyleBackColor = false;
            this.btn_Sil.Click += new System.EventHandler(this.btn_Sil_Click);
            // 
            // btn_Sorgula
            // 
            this.btn_Sorgula.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_Sorgula.Location = new System.Drawing.Point(647, 75);
            this.btn_Sorgula.Name = "btn_Sorgula";
            this.btn_Sorgula.Size = new System.Drawing.Size(95, 26);
            this.btn_Sorgula.TabIndex = 4;
            this.btn_Sorgula.Text = "Sorgula";
            this.btn_Sorgula.UseVisualStyleBackColor = false;
            this.btn_Sorgula.Click += new System.EventHandler(this.btn_Sorgula_Click);
            // 
            // grp_yorumIslemler
            // 
            this.grp_yorumIslemler.Controls.Add(this.btn_Guncelle);
            this.grp_yorumIslemler.Controls.Add(this.btn_Ekle);
            this.grp_yorumIslemler.Controls.Add(this.txt_yorumId);
            this.grp_yorumIslemler.Controls.Add(this.label2);
            this.grp_yorumIslemler.Controls.Add(this.txt_yorum);
            this.grp_yorumIslemler.Location = new System.Drawing.Point(9, 286);
            this.grp_yorumIslemler.Name = "grp_yorumIslemler";
            this.grp_yorumIslemler.Size = new System.Drawing.Size(598, 134);
            this.grp_yorumIslemler.TabIndex = 3;
            this.grp_yorumIslemler.TabStop = false;
            this.grp_yorumIslemler.Text = "İşlemler";
            // 
            // btn_Guncelle
            // 
            this.btn_Guncelle.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_Guncelle.Location = new System.Drawing.Point(392, 81);
            this.btn_Guncelle.Name = "btn_Guncelle";
            this.btn_Guncelle.Size = new System.Drawing.Size(103, 26);
            this.btn_Guncelle.TabIndex = 4;
            this.btn_Guncelle.Text = "Güncelle";
            this.btn_Guncelle.UseVisualStyleBackColor = false;
            this.btn_Guncelle.Click += new System.EventHandler(this.btn_Guncelle_Click_1);
            // 
            // btn_Ekle
            // 
            this.btn_Ekle.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_Ekle.Location = new System.Drawing.Point(392, 17);
            this.btn_Ekle.Name = "btn_Ekle";
            this.btn_Ekle.Size = new System.Drawing.Size(103, 26);
            this.btn_Ekle.TabIndex = 3;
            this.btn_Ekle.Text = "Ekle";
            this.btn_Ekle.UseVisualStyleBackColor = false;
            this.btn_Ekle.Click += new System.EventHandler(this.btn_Ekle_Click);
            // 
            // txt_yorumId
            // 
            this.txt_yorumId.FieldDataType = CustomControls.MyControls.StringControl.DataTypeEnum.DTMixed;
            this.txt_yorumId.FieldLocked = false;
            this.txt_yorumId.FieldMaxLength = 20;
            this.txt_yorumId.FieldTextAligment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_yorumId.FieldTextAlign = CustomControls.MyControls.StringControl.TextAlignEnum.AlnLeft;
            this.txt_yorumId.FocusedColor = System.Drawing.Color.Yellow;
            this.txt_yorumId.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_yorumId.Label = "label";
            this.txt_yorumId.LabelVisible = false;
            this.txt_yorumId.Location = new System.Drawing.Point(665, 0);
            this.txt_yorumId.Name = "txt_yorumId";
            this.txt_yorumId.Padding = new System.Windows.Forms.Padding(7);
            this.txt_yorumId.Required = false;
            this.txt_yorumId.RequiredColor = System.Drawing.Color.Red;
            this.txt_yorumId.SelectText = false;
            this.txt_yorumId.Size = new System.Drawing.Size(17, 20);
            this.txt_yorumId.Spacing = 10;
            this.txt_yorumId.TabIndex = 2;
            this.txt_yorumId.Trimmed = true;
            this.txt_yorumId.Value = null;
            this.txt_yorumId.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Yorumunuzu Giriniz.";
            // 
            // txt_yorum
            // 
            this.txt_yorum.Location = new System.Drawing.Point(6, 40);
            this.txt_yorum.Multiline = true;
            this.txt_yorum.Name = "txt_yorum";
            this.txt_yorum.Size = new System.Drawing.Size(301, 88);
            this.txt_yorum.TabIndex = 0;
            // 
            // dg_yorumlar
            // 
            this.dg_yorumlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_yorumlar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.comment_id,
            this.commenter_mail,
            this.book_id,
            this.comment});
            this.dg_yorumlar.Location = new System.Drawing.Point(6, 75);
            this.dg_yorumlar.Name = "dg_yorumlar";
            this.dg_yorumlar.Size = new System.Drawing.Size(601, 193);
            this.dg_yorumlar.TabIndex = 2;
            this.dg_yorumlar.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_yorumlar_CellEnter);
            // 
            // comment_id
            // 
            this.comment_id.DataPropertyName = "comment_id";
            this.comment_id.HeaderText = "Yorum ID";
            this.comment_id.Name = "comment_id";
            this.comment_id.Width = 80;
            // 
            // commenter_mail
            // 
            this.commenter_mail.DataPropertyName = "commenter_mail";
            this.commenter_mail.HeaderText = "Yorum Yapan Kişi Maili";
            this.commenter_mail.Name = "commenter_mail";
            this.commenter_mail.Width = 150;
            // 
            // book_id
            // 
            this.book_id.DataPropertyName = "book_id";
            this.book_id.HeaderText = "Kitap ID";
            this.book_id.Name = "book_id";
            this.book_id.Width = 80;
            // 
            // comment
            // 
            this.comment.DataPropertyName = "comment";
            this.comment.HeaderText = "Yorum";
            this.comment.Name = "comment";
            this.comment.ReadOnly = true;
            this.comment.Width = 250;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kitaplar";
            // 
            // cmb_kitaplar
            // 
            this.cmb_kitaplar.DisplayMember = "book_name";
            this.cmb_kitaplar.FormattingEnabled = true;
            this.cmb_kitaplar.Location = new System.Drawing.Point(6, 36);
            this.cmb_kitaplar.Name = "cmb_kitaplar";
            this.cmb_kitaplar.Size = new System.Drawing.Size(197, 21);
            this.cmb_kitaplar.TabIndex = 0;
            this.cmb_kitaplar.ValueMember = "book_id";
            // 
            // Form_Yorumlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grb_yorumlar);
            this.Name = "Form_Yorumlar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form_Yorumlar";
            this.Load += new System.EventHandler(this.Form_Yorumlar_Load);
            this.grb_yorumlar.ResumeLayout(false);
            this.grb_yorumlar.PerformLayout();
            this.grp_yorumIslemler.ResumeLayout(false);
            this.grp_yorumIslemler.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_yorumlar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grb_yorumlar;
        private System.Windows.Forms.ComboBox cmb_kitaplar;
        private System.Windows.Forms.DataGridView dg_yorumlar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grp_yorumIslemler;
        private System.Windows.Forms.DataGridViewTextBoxColumn comment_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn commenter_mail;
        private System.Windows.Forms.DataGridViewTextBoxColumn book_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn comment;
        private CustomControls.MyControls.StringControl txt_yorumId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_yorum;
        private System.Windows.Forms.Button btn_Sil;
        private System.Windows.Forms.Button btn_Sorgula;
        private System.Windows.Forms.Button btn_Guncelle;
        private System.Windows.Forms.Button btn_Ekle;
    }
}