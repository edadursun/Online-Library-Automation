using KitapProje.DataContext.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KitapProje
{
    public partial class Form_Kitaplar : Form
    {
        
        public Form_Kitaplar()
        {
            InitializeComponent();
        }

        private void dg_kitaplar_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if(dg_kitaplar.DataSource != null) { 
                this.txt_bookId.Value = this.dg_kitaplar.CurrentRow.Cells["book_id"].Value.ToString();
                this.txt_book.Value   = this.dg_kitaplar.CurrentRow.Cells["book_name"].Value.ToString();
                this.txt_author.SelectedValue = int.Parse(this.dg_kitaplar.CurrentRow.Cells["author_id"].Value.ToString());
                this.txt_genre.SelectedValue = int.Parse(this.dg_kitaplar.CurrentRow.Cells["genre_id"].Value.ToString());
                this.txt_publisher.SelectedValue = int.Parse(this.dg_kitaplar.CurrentRow.Cells["publisher_id"].Value.ToString());
                if (this.dg_kitaplar.CurrentRow.Cells["published_date"].Value != null)
                {
                    this.txt_publishDate.Value = this.dg_kitaplar.CurrentRow.Cells["published_date"].Value.ToString();
                }
            }

        }

        private void btn_kitapSorgula_Click(object sender, EventArgs e)
        {
            this.Sorgula();
        }

        void Sorgula()
        {      
            Kitaplar kitaplar = new Kitaplar();
            kitaplar.author_id = -1;
            kitaplar.publisher_id = -1;
            kitaplar.genre_id = -1;
            if(this.cmb_Authorname.SelectedValue != null) kitaplar.author_id = int.Parse(this.cmb_Authorname.SelectedValue.ToString());
            if(this.cmb_Genrename.SelectedValue != null) kitaplar.genre_id = int.Parse(this.cmb_Genrename.SelectedValue.ToString());
            if(this.cmb_Publishername.SelectedValue != null) kitaplar.publisher_id = int.Parse(this.cmb_Publishername.SelectedValue.ToString());

            this.dg_kitaplar.DataSource = kitaplar.Select(kitaplar);
        }

        private void btn_kitapEkle_Click(object sender, EventArgs e)
        {
            if (Form_Login.DoValidations(this) == false) return;

            try
            {
                Kitaplar kitaplar = new Kitaplar
                {
                    book_id = null,
                    book_name = this.txt_book.Value.ToString(),
                    publisher_id = int.Parse(this.txt_publisher.SelectedValue.ToString()),
                    genre_id = int.Parse(this.txt_genre.SelectedValue.ToString()),
                    author_id = int.Parse(this.txt_author.SelectedValue.ToString()),
                    published_date = DateTime.Parse(this.txt_publishDate.Value.ToString())
                };
                kitaplar.Insert(kitaplar);
                this.Sorgula();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form_Kitaplar_Load(object sender, EventArgs e)
        {
            this.Text = this.Text + "[ " + this.Name + " ]";

            Turler turler = new Turler();
            this.cmb_Genrename.DataSource = turler.Select();
            this.cmb_Genrename.SelectedIndex = -1;
            this.txt_genre.DataSource = turler.Select();
            this.txt_genre.SelectedIndex =-1;

            Yazarlar yazarlar = new Yazarlar();
            this.cmb_Authorname.DataSource = yazarlar.getListForCombo();
            this.cmb_Authorname.SelectedIndex = -1;
            this.txt_author.DataSource = yazarlar.getListForCombo();
            this.txt_author.SelectedIndex = -1;

            Yayinevleri yayinevleri = new Yayinevleri();
            this.cmb_Publishername.DataSource = yayinevleri.Select();
            this.cmb_Publishername.SelectedIndex = -1;
            this.txt_publisher.DataSource = yayinevleri.Select();
            this.txt_publisher.SelectedIndex = -1;

            this.Sorgula();
        }

        private void btn_kitapGuncelle_Click(object sender, EventArgs e)
        {
            if (Form_Login.DoValidations(this) == false) return;

            try
            {
                int bookId = int.Parse(this.txt_bookId.Value.ToString());
                Kitaplar mykitap = new Kitaplar();
                mykitap.Update(bookId, this.txt_book.Value.ToString(), int.Parse(this.txt_author.SelectedValue.ToString()), int.Parse(this.txt_publisher.SelectedValue.ToString()), int.Parse(this.txt_genre.SelectedValue.ToString()), DateTime.Parse(this.txt_publishDate.Value.ToString()));
                this.Sorgula();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_kitapSil_Click(object sender, EventArgs e)
        {
            if (Form_Login.ConfirmForDeletion() == true)
            {
                int book_id = int.Parse(this.txt_bookId.Value.ToString());
                Kitaplar myKitap = new Kitaplar();
                myKitap.Delete(book_id);
                this.Sorgula();
            }
        }
    }
}
