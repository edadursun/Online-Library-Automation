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
    public partial class Form_Yazarlar : Form
    {
        public Form_Yazarlar()
        {
            InitializeComponent();
        }

        private void btn_yazarSorgula_Click(object sender, EventArgs e)
        {
            this.Sorgula();
        }

        void Sorgula()
        {   
            Yazarlar myYazar = new Yazarlar();
            this.dg_yazarlar.DataSource = myYazar.Select();
        }

        private void dg_yazarlar_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dg_yazarlar.DataSource != null) {
                this.txt_authorId.Value = this.dg_yazarlar.CurrentRow.Cells["author_id"].Value.ToString();
                this.txt_authorName.Value = this.dg_yazarlar.CurrentRow.Cells["author_name"].Value.ToString();
                this.txt_authorSurname.Value = this.dg_yazarlar.CurrentRow.Cells["author_surname"].Value.ToString();
            }

        }

        private void btn_yazarEkle_Click(object sender, EventArgs e)
        {
            if (Form_Login.DoValidations(this) == false) return;

            try
            {
                Yazarlar myYazar = new Yazarlar
                {
                    author_id = null,
                    author_name = this.txt_authorName.Value.ToString(),
                    author_surname = this.txt_authorSurname.Value.ToString(),
                };
                myYazar.Insert(myYazar);
                this.Sorgula();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btn_yazarGuncelle_Click(object sender, EventArgs e)
        {

            if (Form_Login.DoValidations(this) == false) return;

            try
            {
                int author_id = int.Parse(this.txt_authorId.Value.ToString());
                Yazarlar myYazar = new Yazarlar();
                myYazar.Update(author_id, this.txt_authorName.Value.ToString(), this.txt_authorSurname.Value.ToString());
                this.Sorgula();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btn_yazarSil_Click(object sender, EventArgs e)
        {
            if (Form_Login.ConfirmForDeletion() == true) 
            {
                int author_id = int.Parse(this.txt_authorId.Value.ToString());
                Yazarlar myYazar = new Yazarlar();
                myYazar.Delete(author_id);
                this.Sorgula();
            }
        }

        private void Form_Yazarlar_Load(object sender, EventArgs e)
        {
            this.Sorgula();
            this.Text = this.Text + "[ " + this.Name + " ]";
        }
    }
}
