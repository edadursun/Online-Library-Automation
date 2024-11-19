namespace KitapProje
{
    partial class Form_Turler
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
            this.grb_turler = new System.Windows.Forms.GroupBox();
            this.btn_turlerSil = new System.Windows.Forms.Button();
            this.btn_turlerSorgula = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_turlerGuncelle = new System.Windows.Forms.Button();
            this.btn_turlerEkle = new System.Windows.Forms.Button();
            this.txt_genreName = new CustomControls.MyControls.StringControl();
            this.txt_genreId = new CustomControls.MyControls.StringControl();
            this.dg_turler = new System.Windows.Forms.DataGridView();
            this.genre_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genre_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grb_turler.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_turler)).BeginInit();
            this.SuspendLayout();
            // 
            // grb_turler
            // 
            this.grb_turler.Controls.Add(this.btn_turlerSil);
            this.grb_turler.Controls.Add(this.btn_turlerSorgula);
            this.grb_turler.Controls.Add(this.groupBox1);
            this.grb_turler.Controls.Add(this.dg_turler);
            this.grb_turler.Location = new System.Drawing.Point(12, 12);
            this.grb_turler.Name = "grb_turler";
            this.grb_turler.Size = new System.Drawing.Size(576, 343);
            this.grb_turler.TabIndex = 0;
            this.grb_turler.TabStop = false;
            this.grb_turler.Text = "Türler";
            // 
            // btn_turlerSil
            // 
            this.btn_turlerSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_turlerSil.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_turlerSil.Location = new System.Drawing.Point(398, 108);
            this.btn_turlerSil.Name = "btn_turlerSil";
            this.btn_turlerSil.Size = new System.Drawing.Size(109, 32);
            this.btn_turlerSil.TabIndex = 5;
            this.btn_turlerSil.Text = "Sil";
            this.btn_turlerSil.UseVisualStyleBackColor = false;
            this.btn_turlerSil.Click += new System.EventHandler(this.btn_turlerSil_Click);
            // 
            // btn_turlerSorgula
            // 
            this.btn_turlerSorgula.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_turlerSorgula.Location = new System.Drawing.Point(398, 34);
            this.btn_turlerSorgula.Name = "btn_turlerSorgula";
            this.btn_turlerSorgula.Size = new System.Drawing.Size(109, 32);
            this.btn_turlerSorgula.TabIndex = 4;
            this.btn_turlerSorgula.Text = "Sorgula";
            this.btn_turlerSorgula.UseVisualStyleBackColor = false;
            this.btn_turlerSorgula.Click += new System.EventHandler(this.btn_turlerSorgula_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Controls.Add(this.btn_turlerGuncelle);
            this.groupBox1.Controls.Add(this.btn_turlerEkle);
            this.groupBox1.Controls.Add(this.txt_genreName);
            this.groupBox1.Controls.Add(this.txt_genreId);
            this.groupBox1.Location = new System.Drawing.Point(6, 207);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(323, 127);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İşlemler";
            // 
            // btn_turlerGuncelle
            // 
            this.btn_turlerGuncelle.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_turlerGuncelle.Location = new System.Drawing.Point(206, 93);
            this.btn_turlerGuncelle.Name = "btn_turlerGuncelle";
            this.btn_turlerGuncelle.Size = new System.Drawing.Size(88, 28);
            this.btn_turlerGuncelle.TabIndex = 4;
            this.btn_turlerGuncelle.Text = "Güncelle";
            this.btn_turlerGuncelle.UseVisualStyleBackColor = false;
            this.btn_turlerGuncelle.Click += new System.EventHandler(this.btn_turlerGuncelle_Click);
            // 
            // btn_turlerEkle
            // 
            this.btn_turlerEkle.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_turlerEkle.Location = new System.Drawing.Point(25, 93);
            this.btn_turlerEkle.Name = "btn_turlerEkle";
            this.btn_turlerEkle.Size = new System.Drawing.Size(92, 28);
            this.btn_turlerEkle.TabIndex = 3;
            this.btn_turlerEkle.Text = "Ekle";
            this.btn_turlerEkle.UseVisualStyleBackColor = false;
            this.btn_turlerEkle.Click += new System.EventHandler(this.btn_turlerEkle_Click);
            // 
            // txt_genreName
            // 
            this.txt_genreName.BackColor = System.Drawing.SystemColors.Control;
            this.txt_genreName.FieldDataType = CustomControls.MyControls.StringControl.DataTypeEnum.DTMixed;
            this.txt_genreName.FieldLocked = false;
            this.txt_genreName.FieldMaxLength = 20;
            this.txt_genreName.FieldTextAligment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_genreName.FieldTextAlign = CustomControls.MyControls.StringControl.TextAlignEnum.AlnLeft;
            this.txt_genreName.FocusedColor = System.Drawing.Color.Beige;
            this.txt_genreName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_genreName.Label = "Tür Adı";
            this.txt_genreName.LabelVisible = true;
            this.txt_genreName.Location = new System.Drawing.Point(25, 36);
            this.txt_genreName.Name = "txt_genreName";
            this.txt_genreName.Padding = new System.Windows.Forms.Padding(7);
            this.txt_genreName.Required = true;
            this.txt_genreName.RequiredColor = System.Drawing.Color.DarkOliveGreen;
            this.txt_genreName.SelectText = false;
            this.txt_genreName.Size = new System.Drawing.Size(269, 20);
            this.txt_genreName.Spacing = 10;
            this.txt_genreName.TabIndex = 1;
            this.txt_genreName.Trimmed = true;
            this.txt_genreName.Value = null;
            // 
            // txt_genreId
            // 
            this.txt_genreId.FieldDataType = CustomControls.MyControls.StringControl.DataTypeEnum.DTNumeric;
            this.txt_genreId.FieldLocked = false;
            this.txt_genreId.FieldMaxLength = 20;
            this.txt_genreId.FieldTextAligment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_genreId.FieldTextAlign = CustomControls.MyControls.StringControl.TextAlignEnum.AlnLeft;
            this.txt_genreId.FocusedColor = System.Drawing.Color.Yellow;
            this.txt_genreId.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_genreId.Label = "label";
            this.txt_genreId.LabelVisible = false;
            this.txt_genreId.Location = new System.Drawing.Point(346, 0);
            this.txt_genreId.Name = "txt_genreId";
            this.txt_genreId.Padding = new System.Windows.Forms.Padding(7);
            this.txt_genreId.Required = false;
            this.txt_genreId.RequiredColor = System.Drawing.Color.Red;
            this.txt_genreId.SelectText = false;
            this.txt_genreId.Size = new System.Drawing.Size(42, 20);
            this.txt_genreId.Spacing = 10;
            this.txt_genreId.TabIndex = 2;
            this.txt_genreId.Trimmed = true;
            this.txt_genreId.Value = null;
            this.txt_genreId.Visible = false;
            // 
            // dg_turler
            // 
            this.dg_turler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_turler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.genre_id,
            this.genre_name});
            this.dg_turler.Location = new System.Drawing.Point(6, 19);
            this.dg_turler.Name = "dg_turler";
            this.dg_turler.Size = new System.Drawing.Size(323, 165);
            this.dg_turler.TabIndex = 0;
            this.dg_turler.TabStop = false;
            this.dg_turler.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_turler_CellEnter);
            // 
            // genre_id
            // 
            this.genre_id.DataPropertyName = "genre_id";
            this.genre_id.HeaderText = "Tür ID";
            this.genre_id.Name = "genre_id";
            // 
            // genre_name
            // 
            this.genre_name.DataPropertyName = "genre_name";
            this.genre_name.HeaderText = "Tür Adı";
            this.genre_name.Name = "genre_name";
            this.genre_name.Width = 180;
            // 
            // Form_Turler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 358);
            this.Controls.Add(this.grb_turler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form_Turler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Kitap Türleri";
            this.Load += new System.EventHandler(this.Form_Turler_Load);
            this.Shown += new System.EventHandler(this.Form_Turler_Shown);
            this.grb_turler.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_turler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grb_turler;
        private System.Windows.Forms.DataGridView dg_turler;
        private System.Windows.Forms.DataGridViewTextBoxColumn genre_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn genre_name;
        private CustomControls.MyControls.StringControl txt_genreName;
        private System.Windows.Forms.GroupBox groupBox1;
        private CustomControls.MyControls.StringControl txt_genreId;
        private System.Windows.Forms.Button btn_turlerSil;
        private System.Windows.Forms.Button btn_turlerSorgula;
        private System.Windows.Forms.Button btn_turlerGuncelle;
        private System.Windows.Forms.Button btn_turlerEkle;
    }
}