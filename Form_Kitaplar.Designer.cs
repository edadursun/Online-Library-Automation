namespace KitapProje
{
    partial class Form_Kitaplar
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
            this.gb_kitaplar = new System.Windows.Forms.GroupBox();
            this.gb_kitapIslemler = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_publishDate = new CustomControls.MyControls.DateControl();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_genre = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_publisher = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_kitapGuncelle = new System.Windows.Forms.Button();
            this.txt_bookId = new CustomControls.MyControls.StringControl();
            this.txt_author = new System.Windows.Forms.ComboBox();
            this.btn_kitapEkle = new System.Windows.Forms.Button();
            this.txt_book = new CustomControls.MyControls.StringControl();
            this.btn_kitapSil = new System.Windows.Forms.Button();
            this.btn_kitapSorgula = new System.Windows.Forms.Button();
            this.dg_kitaplar = new System.Windows.Forms.DataGridView();
            this.book_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genre_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.book_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.author_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publisher_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.published_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_Publishername = new System.Windows.Forms.ComboBox();
            this.cmb_Authorname = new System.Windows.Forms.ComboBox();
            this.cmb_Genrename = new System.Windows.Forms.ComboBox();
            this.cmb_Bookname = new System.Windows.Forms.ComboBox();
            this.gb_kitaplar.SuspendLayout();
            this.gb_kitapIslemler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_kitaplar)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_kitaplar
            // 
            this.gb_kitaplar.Controls.Add(this.gb_kitapIslemler);
            this.gb_kitaplar.Controls.Add(this.btn_kitapSil);
            this.gb_kitaplar.Controls.Add(this.btn_kitapSorgula);
            this.gb_kitaplar.Controls.Add(this.dg_kitaplar);
            this.gb_kitaplar.Controls.Add(this.label4);
            this.gb_kitaplar.Controls.Add(this.label3);
            this.gb_kitaplar.Controls.Add(this.label2);
            this.gb_kitaplar.Controls.Add(this.label1);
            this.gb_kitaplar.Controls.Add(this.cmb_Publishername);
            this.gb_kitaplar.Controls.Add(this.cmb_Authorname);
            this.gb_kitaplar.Controls.Add(this.cmb_Genrename);
            this.gb_kitaplar.Controls.Add(this.cmb_Bookname);
            this.gb_kitaplar.Location = new System.Drawing.Point(12, 12);
            this.gb_kitaplar.Name = "gb_kitaplar";
            this.gb_kitaplar.Size = new System.Drawing.Size(790, 486);
            this.gb_kitaplar.TabIndex = 0;
            this.gb_kitaplar.TabStop = false;
            this.gb_kitaplar.Text = "Kitaplar";
            // 
            // gb_kitapIslemler
            // 
            this.gb_kitapIslemler.Controls.Add(this.label8);
            this.gb_kitapIslemler.Controls.Add(this.txt_publishDate);
            this.gb_kitapIslemler.Controls.Add(this.label7);
            this.gb_kitapIslemler.Controls.Add(this.txt_genre);
            this.gb_kitapIslemler.Controls.Add(this.label6);
            this.gb_kitapIslemler.Controls.Add(this.txt_publisher);
            this.gb_kitapIslemler.Controls.Add(this.label5);
            this.gb_kitapIslemler.Controls.Add(this.btn_kitapGuncelle);
            this.gb_kitapIslemler.Controls.Add(this.txt_bookId);
            this.gb_kitapIslemler.Controls.Add(this.txt_author);
            this.gb_kitapIslemler.Controls.Add(this.btn_kitapEkle);
            this.gb_kitapIslemler.Controls.Add(this.txt_book);
            this.gb_kitapIslemler.Location = new System.Drawing.Point(10, 317);
            this.gb_kitapIslemler.Name = "gb_kitapIslemler";
            this.gb_kitapIslemler.Size = new System.Drawing.Size(676, 163);
            this.gb_kitapIslemler.TabIndex = 13;
            this.gb_kitapIslemler.TabStop = false;
            this.gb_kitapIslemler.Text = "İşlemler";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(450, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Basım Tarihi";
            // 
            // txt_publishDate
            // 
            this.txt_publishDate.FocusedColor = System.Drawing.Color.Yellow;
            this.txt_publishDate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_publishDate.Label = "label";
            this.txt_publishDate.LabelVisible = false;
            this.txt_publishDate.Location = new System.Drawing.Point(453, 87);
            this.txt_publishDate.Name = "txt_publishDate";
            this.txt_publishDate.Padding = new System.Windows.Forms.Padding(7);
            this.txt_publishDate.Required = false;
            this.txt_publishDate.RequiredColor = System.Drawing.Color.Red;
            this.txt_publishDate.Size = new System.Drawing.Size(136, 20);
            this.txt_publishDate.Spacing = 10;
            this.txt_publishDate.TabIndex = 17;
            this.txt_publishDate.Value = new System.DateTime(2024, 10, 23, 0, 5, 43, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Tür";
            // 
            // txt_genre
            // 
            this.txt_genre.DisplayMember = "genre_name";
            this.txt_genre.FormattingEnabled = true;
            this.txt_genre.Location = new System.Drawing.Point(6, 87);
            this.txt_genre.Name = "txt_genre";
            this.txt_genre.Size = new System.Drawing.Size(143, 21);
            this.txt_genre.TabIndex = 13;
            this.txt_genre.ValueMember = "genre_id";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(312, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Yayınevi";
            // 
            // txt_publisher
            // 
            this.txt_publisher.DisplayMember = "publisher_name";
            this.txt_publisher.FormattingEnabled = true;
            this.txt_publisher.Location = new System.Drawing.Point(315, 87);
            this.txt_publisher.Name = "txt_publisher";
            this.txt_publisher.Size = new System.Drawing.Size(132, 21);
            this.txt_publisher.TabIndex = 12;
            this.txt_publisher.ValueMember = "publisher_id";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(152, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Yazar";
            // 
            // btn_kitapGuncelle
            // 
            this.btn_kitapGuncelle.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_kitapGuncelle.Location = new System.Drawing.Point(461, 126);
            this.btn_kitapGuncelle.Name = "btn_kitapGuncelle";
            this.btn_kitapGuncelle.Size = new System.Drawing.Size(113, 31);
            this.btn_kitapGuncelle.TabIndex = 10;
            this.btn_kitapGuncelle.Text = "Güncelle";
            this.btn_kitapGuncelle.UseVisualStyleBackColor = false;
            this.btn_kitapGuncelle.Click += new System.EventHandler(this.btn_kitapGuncelle_Click);
            // 
            // txt_bookId
            // 
            this.txt_bookId.FieldDataType = CustomControls.MyControls.StringControl.DataTypeEnum.DTMixed;
            this.txt_bookId.FieldLocked = false;
            this.txt_bookId.FieldMaxLength = 20;
            this.txt_bookId.FieldTextAligment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_bookId.FieldTextAlign = CustomControls.MyControls.StringControl.TextAlignEnum.AlnLeft;
            this.txt_bookId.FocusedColor = System.Drawing.Color.Yellow;
            this.txt_bookId.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_bookId.Label = "label";
            this.txt_bookId.LabelVisible = false;
            this.txt_bookId.Location = new System.Drawing.Point(709, 0);
            this.txt_bookId.Name = "txt_bookId";
            this.txt_bookId.Padding = new System.Windows.Forms.Padding(7);
            this.txt_bookId.Required = false;
            this.txt_bookId.RequiredColor = System.Drawing.Color.Red;
            this.txt_bookId.SelectText = false;
            this.txt_bookId.Size = new System.Drawing.Size(51, 20);
            this.txt_bookId.Spacing = 10;
            this.txt_bookId.TabIndex = 1;
            this.txt_bookId.Trimmed = true;
            this.txt_bookId.Value = null;
            // 
            // txt_author
            // 
            this.txt_author.DisplayMember = "ad_soyad";
            this.txt_author.FormattingEnabled = true;
            this.txt_author.Location = new System.Drawing.Point(155, 87);
            this.txt_author.Name = "txt_author";
            this.txt_author.Size = new System.Drawing.Size(154, 21);
            this.txt_author.TabIndex = 11;
            this.txt_author.ValueMember = "author_id";
            // 
            // btn_kitapEkle
            // 
            this.btn_kitapEkle.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_kitapEkle.Location = new System.Drawing.Point(11, 126);
            this.btn_kitapEkle.Name = "btn_kitapEkle";
            this.btn_kitapEkle.Size = new System.Drawing.Size(110, 35);
            this.btn_kitapEkle.TabIndex = 9;
            this.btn_kitapEkle.Text = "Ekle";
            this.btn_kitapEkle.UseVisualStyleBackColor = false;
            this.btn_kitapEkle.Click += new System.EventHandler(this.btn_kitapEkle_Click);
            // 
            // txt_book
            // 
            this.txt_book.FieldDataType = CustomControls.MyControls.StringControl.DataTypeEnum.DTMixed;
            this.txt_book.FieldLocked = false;
            this.txt_book.FieldMaxLength = 40;
            this.txt_book.FieldTextAligment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_book.FieldTextAlign = CustomControls.MyControls.StringControl.TextAlignEnum.AlnLeft;
            this.txt_book.FocusedColor = System.Drawing.Color.Yellow;
            this.txt_book.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_book.Label = "Kitap Adı";
            this.txt_book.LabelVisible = true;
            this.txt_book.Location = new System.Drawing.Point(146, 19);
            this.txt_book.Name = "txt_book";
            this.txt_book.Padding = new System.Windows.Forms.Padding(7);
            this.txt_book.Required = false;
            this.txt_book.RequiredColor = System.Drawing.Color.Red;
            this.txt_book.SelectText = false;
            this.txt_book.Size = new System.Drawing.Size(266, 20);
            this.txt_book.Spacing = 10;
            this.txt_book.TabIndex = 0;
            this.txt_book.Trimmed = true;
            this.txt_book.Value = null;
            // 
            // btn_kitapSil
            // 
            this.btn_kitapSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_kitapSil.Location = new System.Drawing.Point(682, 151);
            this.btn_kitapSil.Name = "btn_kitapSil";
            this.btn_kitapSil.Size = new System.Drawing.Size(102, 32);
            this.btn_kitapSil.TabIndex = 12;
            this.btn_kitapSil.Text = "Sil";
            this.btn_kitapSil.UseVisualStyleBackColor = false;
            this.btn_kitapSil.Click += new System.EventHandler(this.btn_kitapSil_Click);
            // 
            // btn_kitapSorgula
            // 
            this.btn_kitapSorgula.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_kitapSorgula.Location = new System.Drawing.Point(682, 116);
            this.btn_kitapSorgula.Name = "btn_kitapSorgula";
            this.btn_kitapSorgula.Size = new System.Drawing.Size(103, 29);
            this.btn_kitapSorgula.TabIndex = 11;
            this.btn_kitapSorgula.Text = "Sorgula";
            this.btn_kitapSorgula.UseVisualStyleBackColor = false;
            this.btn_kitapSorgula.Click += new System.EventHandler(this.btn_kitapSorgula_Click);
            // 
            // dg_kitaplar
            // 
            this.dg_kitaplar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_kitaplar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.book_id,
            this.genre_id,
            this.book_name,
            this.author_id,
            this.publisher_id,
            this.published_date});
            this.dg_kitaplar.Location = new System.Drawing.Point(21, 92);
            this.dg_kitaplar.Name = "dg_kitaplar";
            this.dg_kitaplar.Size = new System.Drawing.Size(655, 204);
            this.dg_kitaplar.TabIndex = 8;
            this.dg_kitaplar.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_kitaplar_CellEnter);
            // 
            // book_id
            // 
            this.book_id.DataPropertyName = "book_id";
            this.book_id.HeaderText = "Kitap ID";
            this.book_id.Name = "book_id";
            this.book_id.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.book_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.book_id.Width = 80;
            // 
            // genre_id
            // 
            this.genre_id.DataPropertyName = "genre_id";
            this.genre_id.HeaderText = "Tur ID";
            this.genre_id.Name = "genre_id";
            this.genre_id.Width = 80;
            // 
            // book_name
            // 
            this.book_name.DataPropertyName = "book_name";
            this.book_name.HeaderText = "Kitap Adı";
            this.book_name.Name = "book_name";
            this.book_name.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.book_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.book_name.Width = 180;
            // 
            // author_id
            // 
            this.author_id.DataPropertyName = "author_id";
            this.author_id.HeaderText = "Yazar ID";
            this.author_id.Name = "author_id";
            this.author_id.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.author_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.author_id.Width = 80;
            // 
            // publisher_id
            // 
            this.publisher_id.DataPropertyName = "publisher_id";
            this.publisher_id.HeaderText = "Yayınevi ID";
            this.publisher_id.Name = "publisher_id";
            this.publisher_id.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.publisher_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.publisher_id.Width = 80;
            // 
            // published_date
            // 
            this.published_date.DataPropertyName = "published_date";
            this.published_date.HeaderText = "Yayınlanma Tarihi";
            this.published_date.Name = "published_date";
            this.published_date.Width = 120;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(592, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Yayınevi Seçiniz";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(396, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Yazar Seçiniz";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(198, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tür Seçiniz";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(6, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kitap Seçiniz";
            // 
            // cmb_Publishername
            // 
            this.cmb_Publishername.DisplayMember = "publisher_name";
            this.cmb_Publishername.FormattingEnabled = true;
            this.cmb_Publishername.Location = new System.Drawing.Point(595, 54);
            this.cmb_Publishername.Name = "cmb_Publishername";
            this.cmb_Publishername.Size = new System.Drawing.Size(175, 21);
            this.cmb_Publishername.TabIndex = 3;
            this.cmb_Publishername.ValueMember = "publisher_id";
            // 
            // cmb_Authorname
            // 
            this.cmb_Authorname.DisplayMember = "ad_soyad";
            this.cmb_Authorname.FormattingEnabled = true;
            this.cmb_Authorname.Location = new System.Drawing.Point(399, 54);
            this.cmb_Authorname.Name = "cmb_Authorname";
            this.cmb_Authorname.Size = new System.Drawing.Size(175, 21);
            this.cmb_Authorname.TabIndex = 2;
            this.cmb_Authorname.ValueMember = "author_id";
            // 
            // cmb_Genrename
            // 
            this.cmb_Genrename.DisplayMember = "genre_name";
            this.cmb_Genrename.FormattingEnabled = true;
            this.cmb_Genrename.Location = new System.Drawing.Point(201, 54);
            this.cmb_Genrename.Name = "cmb_Genrename";
            this.cmb_Genrename.Size = new System.Drawing.Size(175, 21);
            this.cmb_Genrename.TabIndex = 1;
            this.cmb_Genrename.ValueMember = "genre_id";
            // 
            // cmb_Bookname
            // 
            this.cmb_Bookname.DisplayMember = "book_name";
            this.cmb_Bookname.DropDownWidth = 175;
            this.cmb_Bookname.FormattingEnabled = true;
            this.cmb_Bookname.Location = new System.Drawing.Point(6, 54);
            this.cmb_Bookname.Name = "cmb_Bookname";
            this.cmb_Bookname.Size = new System.Drawing.Size(175, 21);
            this.cmb_Bookname.TabIndex = 0;
            this.cmb_Bookname.ValueMember = "book_id";
            // 
            // Form_Kitaplar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 510);
            this.Controls.Add(this.gb_kitaplar);
            this.Name = "Form_Kitaplar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form_Kitaplar";
            this.Load += new System.EventHandler(this.Form_Kitaplar_Load);
            this.gb_kitaplar.ResumeLayout(false);
            this.gb_kitaplar.PerformLayout();
            this.gb_kitapIslemler.ResumeLayout(false);
            this.gb_kitapIslemler.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_kitaplar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_kitaplar;
        private System.Windows.Forms.ComboBox cmb_Bookname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_Publishername;
        private System.Windows.Forms.ComboBox cmb_Authorname;
        private System.Windows.Forms.ComboBox cmb_Genrename;
        private System.Windows.Forms.DataGridView dg_kitaplar;
        private System.Windows.Forms.GroupBox gb_kitapIslemler;
        private CustomControls.MyControls.StringControl txt_book;
        private System.Windows.Forms.Button btn_kitapSil;
        private System.Windows.Forms.Button btn_kitapSorgula;
        private System.Windows.Forms.Button btn_kitapGuncelle;
        private System.Windows.Forms.Button btn_kitapEkle;
        private CustomControls.MyControls.StringControl txt_bookId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox txt_genre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox txt_publisher;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox txt_author;
        private System.Windows.Forms.DataGridViewTextBoxColumn book_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn genre_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn book_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn author_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn publisher_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn published_date;
        private System.Windows.Forms.Label label8;
        private CustomControls.MyControls.DateControl txt_publishDate;
    }
}