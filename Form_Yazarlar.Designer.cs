namespace KitapProje
{
    partial class Form_Yazarlar
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
            this.grb_yazarlar = new System.Windows.Forms.GroupBox();
            this.btn_yazarSil = new System.Windows.Forms.Button();
            this.btn_yazarSorgula = new System.Windows.Forms.Button();
            this.grb_Islemler = new System.Windows.Forms.GroupBox();
            this.txt_authorSurname = new CustomControls.MyControls.StringControl();
            this.btn_yazarGuncelle = new System.Windows.Forms.Button();
            this.btn_yazarEkle = new System.Windows.Forms.Button();
            this.txt_authorName = new CustomControls.MyControls.StringControl();
            this.txt_authorId = new CustomControls.MyControls.StringControl();
            this.dg_yazarlar = new System.Windows.Forms.DataGridView();
            this.author_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.author_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.author_surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grb_yazarlar.SuspendLayout();
            this.grb_Islemler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_yazarlar)).BeginInit();
            this.SuspendLayout();
            // 
            // grb_yazarlar
            // 
            this.grb_yazarlar.Controls.Add(this.btn_yazarSil);
            this.grb_yazarlar.Controls.Add(this.btn_yazarSorgula);
            this.grb_yazarlar.Controls.Add(this.grb_Islemler);
            this.grb_yazarlar.Controls.Add(this.dg_yazarlar);
            this.grb_yazarlar.Location = new System.Drawing.Point(2, 3);
            this.grb_yazarlar.Name = "grb_yazarlar";
            this.grb_yazarlar.Size = new System.Drawing.Size(576, 343);
            this.grb_yazarlar.TabIndex = 1;
            this.grb_yazarlar.TabStop = false;
            this.grb_yazarlar.Text = "Yazarlar";
            // 
            // btn_yazarSil
            // 
            this.btn_yazarSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_yazarSil.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_yazarSil.Location = new System.Drawing.Point(448, 104);
            this.btn_yazarSil.Name = "btn_yazarSil";
            this.btn_yazarSil.Size = new System.Drawing.Size(109, 32);
            this.btn_yazarSil.TabIndex = 5;
            this.btn_yazarSil.Text = "Sil";
            this.btn_yazarSil.UseVisualStyleBackColor = false;
            this.btn_yazarSil.Click += new System.EventHandler(this.btn_yazarSil_Click);
            // 
            // btn_yazarSorgula
            // 
            this.btn_yazarSorgula.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_yazarSorgula.Location = new System.Drawing.Point(448, 34);
            this.btn_yazarSorgula.Name = "btn_yazarSorgula";
            this.btn_yazarSorgula.Size = new System.Drawing.Size(109, 32);
            this.btn_yazarSorgula.TabIndex = 4;
            this.btn_yazarSorgula.Text = "Sorgula";
            this.btn_yazarSorgula.UseVisualStyleBackColor = false;
            this.btn_yazarSorgula.Click += new System.EventHandler(this.btn_yazarSorgula_Click);
            // 
            // grb_Islemler
            // 
            this.grb_Islemler.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.grb_Islemler.Controls.Add(this.txt_authorSurname);
            this.grb_Islemler.Controls.Add(this.btn_yazarGuncelle);
            this.grb_Islemler.Controls.Add(this.btn_yazarEkle);
            this.grb_Islemler.Controls.Add(this.txt_authorName);
            this.grb_Islemler.Controls.Add(this.txt_authorId);
            this.grb_Islemler.Location = new System.Drawing.Point(6, 207);
            this.grb_Islemler.Name = "grb_Islemler";
            this.grb_Islemler.Size = new System.Drawing.Size(423, 127);
            this.grb_Islemler.TabIndex = 3;
            this.grb_Islemler.TabStop = false;
            this.grb_Islemler.Text = "İşlemler";
            // 
            // txt_authorSurname
            // 
            this.txt_authorSurname.BackColor = System.Drawing.SystemColors.Control;
            this.txt_authorSurname.FieldDataType = CustomControls.MyControls.StringControl.DataTypeEnum.DTMixed;
            this.txt_authorSurname.FieldLocked = false;
            this.txt_authorSurname.FieldMaxLength = 20;
            this.txt_authorSurname.FieldTextAligment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_authorSurname.FieldTextAlign = CustomControls.MyControls.StringControl.TextAlignEnum.AlnLeft;
            this.txt_authorSurname.FocusedColor = System.Drawing.Color.Beige;
            this.txt_authorSurname.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_authorSurname.Label = "Yazar Soyadı";
            this.txt_authorSurname.LabelVisible = true;
            this.txt_authorSurname.Location = new System.Drawing.Point(93, 57);
            this.txt_authorSurname.Name = "txt_authorSurname";
            this.txt_authorSurname.Padding = new System.Windows.Forms.Padding(7);
            this.txt_authorSurname.Required = false;
            this.txt_authorSurname.RequiredColor = System.Drawing.Color.Red;
            this.txt_authorSurname.SelectText = false;
            this.txt_authorSurname.Size = new System.Drawing.Size(245, 20);
            this.txt_authorSurname.Spacing = 10;
            this.txt_authorSurname.TabIndex = 5;
            this.txt_authorSurname.Trimmed = true;
            this.txt_authorSurname.Value = null;
            // 
            // btn_yazarGuncelle
            // 
            this.btn_yazarGuncelle.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_yazarGuncelle.Location = new System.Drawing.Point(298, 93);
            this.btn_yazarGuncelle.Name = "btn_yazarGuncelle";
            this.btn_yazarGuncelle.Size = new System.Drawing.Size(88, 28);
            this.btn_yazarGuncelle.TabIndex = 4;
            this.btn_yazarGuncelle.Text = "Güncelle";
            this.btn_yazarGuncelle.UseVisualStyleBackColor = false;
            this.btn_yazarGuncelle.Click += new System.EventHandler(this.btn_yazarGuncelle_Click);
            // 
            // btn_yazarEkle
            // 
            this.btn_yazarEkle.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_yazarEkle.Location = new System.Drawing.Point(59, 93);
            this.btn_yazarEkle.Name = "btn_yazarEkle";
            this.btn_yazarEkle.Size = new System.Drawing.Size(92, 28);
            this.btn_yazarEkle.TabIndex = 3;
            this.btn_yazarEkle.Text = "Ekle";
            this.btn_yazarEkle.UseVisualStyleBackColor = false;
            this.btn_yazarEkle.Click += new System.EventHandler(this.btn_yazarEkle_Click);
            // 
            // txt_authorName
            // 
            this.txt_authorName.BackColor = System.Drawing.SystemColors.Control;
            this.txt_authorName.FieldDataType = CustomControls.MyControls.StringControl.DataTypeEnum.DTMixed;
            this.txt_authorName.FieldLocked = false;
            this.txt_authorName.FieldMaxLength = 20;
            this.txt_authorName.FieldTextAligment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_authorName.FieldTextAlign = CustomControls.MyControls.StringControl.TextAlignEnum.AlnLeft;
            this.txt_authorName.FocusedColor = System.Drawing.Color.Beige;
            this.txt_authorName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_authorName.Label = "Yazar Adı";
            this.txt_authorName.LabelVisible = true;
            this.txt_authorName.Location = new System.Drawing.Point(93, 19);
            this.txt_authorName.Name = "txt_authorName";
            this.txt_authorName.Padding = new System.Windows.Forms.Padding(7);
            this.txt_authorName.Required = false;
            this.txt_authorName.RequiredColor = System.Drawing.Color.Red;
            this.txt_authorName.SelectText = false;
            this.txt_authorName.Size = new System.Drawing.Size(245, 20);
            this.txt_authorName.Spacing = 10;
            this.txt_authorName.TabIndex = 1;
            this.txt_authorName.Trimmed = true;
            this.txt_authorName.Value = null;
            // 
            // txt_authorId
            // 
            this.txt_authorId.FieldDataType = CustomControls.MyControls.StringControl.DataTypeEnum.DTNumeric;
            this.txt_authorId.FieldLocked = false;
            this.txt_authorId.FieldMaxLength = 20;
            this.txt_authorId.FieldTextAligment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_authorId.FieldTextAlign = CustomControls.MyControls.StringControl.TextAlignEnum.AlnLeft;
            this.txt_authorId.FocusedColor = System.Drawing.Color.Yellow;
            this.txt_authorId.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_authorId.Label = "label";
            this.txt_authorId.LabelVisible = false;
            this.txt_authorId.Location = new System.Drawing.Point(509, 0);
            this.txt_authorId.Name = "txt_authorId";
            this.txt_authorId.Padding = new System.Windows.Forms.Padding(7);
            this.txt_authorId.Required = false;
            this.txt_authorId.RequiredColor = System.Drawing.Color.Red;
            this.txt_authorId.SelectText = false;
            this.txt_authorId.Size = new System.Drawing.Size(42, 20);
            this.txt_authorId.Spacing = 10;
            this.txt_authorId.TabIndex = 2;
            this.txt_authorId.Trimmed = true;
            this.txt_authorId.Value = null;
            this.txt_authorId.Visible = false;
            // 
            // dg_yazarlar
            // 
            this.dg_yazarlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_yazarlar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.author_id,
            this.author_name,
            this.author_surname});
            this.dg_yazarlar.Location = new System.Drawing.Point(6, 19);
            this.dg_yazarlar.Name = "dg_yazarlar";
            this.dg_yazarlar.Size = new System.Drawing.Size(423, 165);
            this.dg_yazarlar.TabIndex = 0;
            this.dg_yazarlar.TabStop = false;
            this.dg_yazarlar.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_yazarlar_CellEnter);
            // 
            // author_id
            // 
            this.author_id.DataPropertyName = "author_id";
            this.author_id.HeaderText = "Yazar ID";
            this.author_id.Name = "author_id";
            // 
            // author_name
            // 
            this.author_name.DataPropertyName = "author_name";
            this.author_name.HeaderText = "Yazar Adı";
            this.author_name.Name = "author_name";
            this.author_name.Width = 130;
            // 
            // author_surname
            // 
            this.author_surname.DataPropertyName = "author_surname";
            this.author_surname.HeaderText = "Yazar Soyadı";
            this.author_surname.Name = "author_surname";
            this.author_surname.Width = 150;
            // 
            // Form_Yazarlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 358);
            this.Controls.Add(this.grb_yazarlar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form_Yazarlar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form_Yazarlar";
            this.Load += new System.EventHandler(this.Form_Yazarlar_Load);
            this.grb_yazarlar.ResumeLayout(false);
            this.grb_Islemler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_yazarlar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grb_yazarlar;
        private System.Windows.Forms.Button btn_yazarSil;
        private System.Windows.Forms.Button btn_yazarSorgula;
        private System.Windows.Forms.GroupBox grb_Islemler;
        private System.Windows.Forms.Button btn_yazarGuncelle;
        private System.Windows.Forms.Button btn_yazarEkle;
        private CustomControls.MyControls.StringControl txt_authorName;
        private CustomControls.MyControls.StringControl txt_authorId;
        private System.Windows.Forms.DataGridView dg_yazarlar;
        private CustomControls.MyControls.StringControl txt_authorSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn author_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn author_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn author_surname;
    }
}