using KitapProje.DataContext.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KitapProje
{
    public partial class Form_Yorumlar : Form
    {
        private Form_Login LoginFormRef = null;

        public Form_Yorumlar (Form_Login loginFormRef)
        {
            this.LoginFormRef = loginFormRef;
            InitializeComponent();
        }
        //public Form_Yorumlar()
        //{
        //    InitializeComponent();
        //}

        private void Form_Yorumlar_Load(object sender, EventArgs e)
        {
            Kitaplar myKitap = new Kitaplar();
            this.cmb_kitaplar.DataSource = myKitap.SelectKitap();
            this.Text = this.Text + "[ " + this.Name + " ]";
        }

        void Sorgula()
        {
            Yorumlar yorumlar = new Yorumlar();
            this.dg_yorumlar.DataSource = yorumlar.Select(int.Parse(this.cmb_kitaplar.SelectedValue.ToString()));
        }

        private void btn_Sorgula_Click(object sender, EventArgs e)
        {
            this.Sorgula();
        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            if (Form_Login.DoValidations(this) == false) return;

            try
            {
                Yorumlar yorumlar = new Yorumlar()
                {
                    comment_id = null,
                    commenter_mail = this.LoginFormRef.txt_email.Value.ToString(),
                    comment = this.txt_yorum.Text.ToString(),
                    book_id = int.Parse(this.cmb_kitaplar.SelectedValue.ToString()),

                };
                yorumlar.Insert(yorumlar);
                this.Sorgula();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dg_yorumlar_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if(dg_yorumlar.DataSource != null) {
                this.txt_yorumId.Value = this.dg_yorumlar.CurrentRow.Cells["comment_id"].Value.ToString();
                this.txt_yorum.Text = this.dg_yorumlar.CurrentRow.Cells["comment"].Value.ToString();
            }
        }

        private void btn_Guncelle_Click_1(object sender, EventArgs e)
        {

            if (Form_Login.DoValidations(this) == false) return;

            try
            {
                int book_id = int.Parse(this.cmb_kitaplar.SelectedValue.ToString());
                int comment_id = int.Parse(this.txt_yorumId.Value.ToString());
                string commenter_mail = this.LoginFormRef.txt_email.Value.ToString();
                Yorumlar myYorum = new Yorumlar();
                myYorum.Update(comment_id, book_id, commenter_mail, this.txt_yorum.Text.ToString());
                this.Sorgula();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            if (Form_Login.ConfirmForDeletion() == true)
            {
                int yorum_id = int.Parse(this.txt_yorumId.Value.ToString());
                Yorumlar myYorum = new Yorumlar();
                myYorum.Delete(yorum_id);
                this.Sorgula();
            }
        }
    }
}
