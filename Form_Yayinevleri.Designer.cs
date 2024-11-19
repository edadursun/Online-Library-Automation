namespace KitapProje
{
    partial class Form_Yayinevleri
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
            this.grb_yayinevleri = new System.Windows.Forms.GroupBox();
            this.btn_yayineviSil = new System.Windows.Forms.Button();
            this.btn_yayineviSorgula = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_establishmentDate = new CustomControls.MyControls.DateControl();
            this.btn_yayineviGuncelle = new System.Windows.Forms.Button();
            this.btn_yayineviEkle = new System.Windows.Forms.Button();
            this.txt_publisherName = new CustomControls.MyControls.StringControl();
            this.txt_publisherId = new CustomControls.MyControls.StringControl();
            this.dg_yayinevleri = new System.Windows.Forms.DataGridView();
            this.publisher_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publisher_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.establishment_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grb_yayinevleri.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_yayinevleri)).BeginInit();
            this.SuspendLayout();
            // 
            // grb_yayinevleri
            // 
            this.grb_yayinevleri.Controls.Add(this.btn_yayineviSil);
            this.grb_yayinevleri.Controls.Add(this.btn_yayineviSorgula);
            this.grb_yayinevleri.Controls.Add(this.groupBox1);
            this.grb_yayinevleri.Controls.Add(this.dg_yayinevleri);
            this.grb_yayinevleri.Location = new System.Drawing.Point(12, 8);
            this.grb_yayinevleri.Name = "grb_yayinevleri";
            this.grb_yayinevleri.Size = new System.Drawing.Size(576, 343);
            this.grb_yayinevleri.TabIndex = 1;
            this.grb_yayinevleri.TabStop = false;
            this.grb_yayinevleri.Text = "Türler";
            // 
            // btn_yayineviSil
            // 
            this.btn_yayineviSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_yayineviSil.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_yayineviSil.Location = new System.Drawing.Point(444, 95);
            this.btn_yayineviSil.Name = "btn_yayineviSil";
            this.btn_yayineviSil.Size = new System.Drawing.Size(109, 32);
            this.btn_yayineviSil.TabIndex = 5;
            this.btn_yayineviSil.Text = "Sil";
            this.btn_yayineviSil.UseVisualStyleBackColor = false;
            this.btn_yayineviSil.Click += new System.EventHandler(this.btn_yayineviSil_Click);
            // 
            // btn_yayineviSorgula
            // 
            this.btn_yayineviSorgula.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_yayineviSorgula.Location = new System.Drawing.Point(444, 36);
            this.btn_yayineviSorgula.Name = "btn_yayineviSorgula";
            this.btn_yayineviSorgula.Size = new System.Drawing.Size(109, 32);
            this.btn_yayineviSorgula.TabIndex = 4;
            this.btn_yayineviSorgula.Text = "Sorgula";
            this.btn_yayineviSorgula.UseVisualStyleBackColor = false;
            this.btn_yayineviSorgula.Click += new System.EventHandler(this.btn_yayineviSorgula_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Controls.Add(this.txt_establishmentDate);
            this.groupBox1.Controls.Add(this.btn_yayineviGuncelle);
            this.groupBox1.Controls.Add(this.btn_yayineviEkle);
            this.groupBox1.Controls.Add(this.txt_publisherName);
            this.groupBox1.Controls.Add(this.txt_publisherId);
            this.groupBox1.Location = new System.Drawing.Point(6, 207);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(413, 127);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İşlemler";
            // 
            // txt_establishmentDate
            // 
            this.txt_establishmentDate.BackColor = System.Drawing.SystemColors.Control;
            this.txt_establishmentDate.FocusedColor = System.Drawing.Color.Yellow;
            this.txt_establishmentDate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_establishmentDate.Label = "Kuruluş Tarihi";
            this.txt_establishmentDate.LabelVisible = true;
            this.txt_establishmentDate.Location = new System.Drawing.Point(62, 57);
            this.txt_establishmentDate.Name = "txt_establishmentDate";
            this.txt_establishmentDate.Padding = new System.Windows.Forms.Padding(7);
            this.txt_establishmentDate.Required = false;
            this.txt_establishmentDate.RequiredColor = System.Drawing.Color.Red;
            this.txt_establishmentDate.Size = new System.Drawing.Size(296, 20);
            this.txt_establishmentDate.Spacing = 10;
            this.txt_establishmentDate.TabIndex = 6;
            this.txt_establishmentDate.Value = new System.DateTime(2024, 10, 22, 17, 59, 58, 0);
            // 
            // btn_yayineviGuncelle
            // 
            this.btn_yayineviGuncelle.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_yayineviGuncelle.Location = new System.Drawing.Point(308, 93);
            this.btn_yayineviGuncelle.Name = "btn_yayineviGuncelle";
            this.btn_yayineviGuncelle.Size = new System.Drawing.Size(88, 28);
            this.btn_yayineviGuncelle.TabIndex = 4;
            this.btn_yayineviGuncelle.Text = "Güncelle";
            this.btn_yayineviGuncelle.UseVisualStyleBackColor = false;
            this.btn_yayineviGuncelle.Click += new System.EventHandler(this.btn_yayineviGuncelle_Click);
            // 
            // btn_yayineviEkle
            // 
            this.btn_yayineviEkle.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_yayineviEkle.Location = new System.Drawing.Point(16, 93);
            this.btn_yayineviEkle.Name = "btn_yayineviEkle";
            this.btn_yayineviEkle.Size = new System.Drawing.Size(92, 28);
            this.btn_yayineviEkle.TabIndex = 3;
            this.btn_yayineviEkle.Text = "Ekle";
            this.btn_yayineviEkle.UseVisualStyleBackColor = false;
            this.btn_yayineviEkle.Click += new System.EventHandler(this.btn_yayineviEkle_Click);
            // 
            // txt_publisherName
            // 
            this.txt_publisherName.BackColor = System.Drawing.SystemColors.Control;
            this.txt_publisherName.FieldDataType = CustomControls.MyControls.StringControl.DataTypeEnum.DTMixed;
            this.txt_publisherName.FieldLocked = false;
            this.txt_publisherName.FieldMaxLength = 20;
            this.txt_publisherName.FieldTextAligment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_publisherName.FieldTextAlign = CustomControls.MyControls.StringControl.TextAlignEnum.AlnLeft;
            this.txt_publisherName.FocusedColor = System.Drawing.Color.Beige;
            this.txt_publisherName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_publisherName.Label = "Yayınevi Adı";
            this.txt_publisherName.LabelVisible = true;
            this.txt_publisherName.Location = new System.Drawing.Point(62, 19);
            this.txt_publisherName.Name = "txt_publisherName";
            this.txt_publisherName.Padding = new System.Windows.Forms.Padding(7);
            this.txt_publisherName.Required = false;
            this.txt_publisherName.RequiredColor = System.Drawing.Color.Red;
            this.txt_publisherName.SelectText = false;
            this.txt_publisherName.Size = new System.Drawing.Size(296, 20);
            this.txt_publisherName.Spacing = 10;
            this.txt_publisherName.TabIndex = 1;
            this.txt_publisherName.Trimmed = true;
            this.txt_publisherName.Value = null;
            // 
            // txt_publisherId
            // 
            this.txt_publisherId.FieldDataType = CustomControls.MyControls.StringControl.DataTypeEnum.DTNumeric;
            this.txt_publisherId.FieldLocked = false;
            this.txt_publisherId.FieldMaxLength = 20;
            this.txt_publisherId.FieldTextAligment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_publisherId.FieldTextAlign = CustomControls.MyControls.StringControl.TextAlignEnum.AlnLeft;
            this.txt_publisherId.FocusedColor = System.Drawing.Color.Yellow;
            this.txt_publisherId.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_publisherId.Label = "label";
            this.txt_publisherId.LabelVisible = false;
            this.txt_publisherId.Location = new System.Drawing.Point(457, 0);
            this.txt_publisherId.Name = "txt_publisherId";
            this.txt_publisherId.Padding = new System.Windows.Forms.Padding(7);
            this.txt_publisherId.Required = false;
            this.txt_publisherId.RequiredColor = System.Drawing.Color.Red;
            this.txt_publisherId.SelectText = false;
            this.txt_publisherId.Size = new System.Drawing.Size(42, 20);
            this.txt_publisherId.Spacing = 10;
            this.txt_publisherId.TabIndex = 2;
            this.txt_publisherId.Trimmed = true;
            this.txt_publisherId.Value = null;
            this.txt_publisherId.Visible = false;
            // 
            // dg_yayinevleri
            // 
            this.dg_yayinevleri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_yayinevleri.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.publisher_id,
            this.publisher_name,
            this.establishment_date});
            this.dg_yayinevleri.Location = new System.Drawing.Point(6, 19);
            this.dg_yayinevleri.Name = "dg_yayinevleri";
            this.dg_yayinevleri.Size = new System.Drawing.Size(413, 165);
            this.dg_yayinevleri.TabIndex = 0;
            this.dg_yayinevleri.TabStop = false;
            this.dg_yayinevleri.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_yayinevleri_CellEnter);
            // 
            // publisher_id
            // 
            this.publisher_id.DataPropertyName = "publisher_id";
            this.publisher_id.HeaderText = "Yayınevi ID";
            this.publisher_id.Name = "publisher_id";
            this.publisher_id.Width = 90;
            // 
            // publisher_name
            // 
            this.publisher_name.DataPropertyName = "publisher_name";
            this.publisher_name.HeaderText = "Yayınevi Adı";
            this.publisher_name.Name = "publisher_name";
            this.publisher_name.Width = 150;
            // 
            // establishment_date
            // 
            this.establishment_date.DataPropertyName = "establishment_date";
            this.establishment_date.HeaderText = "Kuruluş Tarihi";
            this.establishment_date.Name = "establishment_date";
            this.establishment_date.Width = 130;
            // 
            // Form_Yayinevleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 363);
            this.Controls.Add(this.grb_yayinevleri);
            this.Name = "Form_Yayinevleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form_Yayinevleri";
            this.Load += new System.EventHandler(this.Form_Yayinevleri_Load);
            this.grb_yayinevleri.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_yayinevleri)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grb_yayinevleri;
        private System.Windows.Forms.Button btn_yayineviSil;
        private System.Windows.Forms.Button btn_yayineviSorgula;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_yayineviGuncelle;
        private System.Windows.Forms.Button btn_yayineviEkle;
        private CustomControls.MyControls.StringControl txt_publisherName;
        private CustomControls.MyControls.StringControl txt_publisherId;
        private System.Windows.Forms.DataGridView dg_yayinevleri;
        private CustomControls.MyControls.DateControl txt_establishmentDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn publisher_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn publisher_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn establishment_date;
    }
}