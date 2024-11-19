namespace KitapProje
{
    partial class Form_Login
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
            this.txt_email = new CustomControls.MyControls.StringControl();
            this.txt_password = new CustomControls.MyControls.StringControl();
            this.btn_login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_email
            // 
            this.txt_email.FieldDataType = CustomControls.MyControls.StringControl.DataTypeEnum.DTMixed;
            this.txt_email.FieldLocked = false;
            this.txt_email.FieldMaxLength = 20;
            this.txt_email.FieldTextAligment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_email.FieldTextAlign = CustomControls.MyControls.StringControl.TextAlignEnum.AlnLeft;
            this.txt_email.FocusedColor = System.Drawing.Color.Yellow;
            this.txt_email.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_email.Label = "E-posta Adresi:";
            this.txt_email.LabelVisible = true;
            this.txt_email.Location = new System.Drawing.Point(44, 42);
            this.txt_email.Name = "txt_email";
            this.txt_email.Padding = new System.Windows.Forms.Padding(7);
            this.txt_email.Required = true;
            this.txt_email.RequiredColor = System.Drawing.Color.DarkOliveGreen;
            this.txt_email.SelectText = false;
            this.txt_email.Size = new System.Drawing.Size(271, 20);
            this.txt_email.Spacing = 10;
            this.txt_email.TabIndex = 0;
            this.txt_email.Trimmed = true;
            this.txt_email.Value = null;
            // 
            // txt_password
            // 
            this.txt_password.FieldDataType = CustomControls.MyControls.StringControl.DataTypeEnum.DTMixed;
            this.txt_password.FieldLocked = false;
            this.txt_password.FieldMaxLength = 20;
            this.txt_password.FieldTextAligment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_password.FieldTextAlign = CustomControls.MyControls.StringControl.TextAlignEnum.AlnLeft;
            this.txt_password.FocusedColor = System.Drawing.Color.Yellow;
            this.txt_password.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_password.Label = "Şifre:";
            this.txt_password.LabelVisible = true;
            this.txt_password.Location = new System.Drawing.Point(97, 68);
            this.txt_password.Name = "txt_password";
            this.txt_password.Padding = new System.Windows.Forms.Padding(7);
            this.txt_password.Required = true;
            this.txt_password.RequiredColor = System.Drawing.Color.DarkOliveGreen;
            this.txt_password.SelectText = false;
            this.txt_password.Size = new System.Drawing.Size(218, 20);
            this.txt_password.Spacing = 10;
            this.txt_password.TabIndex = 1;
            this.txt_password.Trimmed = true;
            this.txt_password.Value = null;
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(302, 160);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(98, 30);
            this.btn_login.TabIndex = 2;
            this.btn_login.Text = "Giriş Yap";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // Form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(412, 202);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_email);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş Formu";
            this.Load += new System.EventHandler(this.Form_Login_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private CustomControls.MyControls.StringControl txt_password;
        private System.Windows.Forms.Button btn_login;
        public CustomControls.MyControls.StringControl txt_email;
    }
}