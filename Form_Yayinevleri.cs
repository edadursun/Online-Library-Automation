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
    public partial class Form_Yayinevleri : Form
    {
        public Form_Yayinevleri()
        {
            InitializeComponent();
        }

        private void btn_yayineviSorgula_Click(object sender, EventArgs e)
        {
            this.Sorgula();
        }

        void Sorgula ()
        {
            Yayinevleri yayinevleri = new Yayinevleri();
            this.dg_yayinevleri.DataSource = yayinevleri.Select();
        }

        private void btn_yayineviEkle_Click(object sender, EventArgs e)
        {
            if (Form_Login.DoValidations(this) == false) return;

            try
            {
                Yayinevleri myYayin = new Yayinevleri
                {
                    publisher_id = null,
                    publisher_name = this.txt_publisherName.Value.ToString(),
                    establishment_date = DateTime.Parse(this.txt_establishmentDate.Value.ToString()),
                };
                myYayin.Insert(myYayin);
                this.Sorgula();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_yayineviGuncelle_Click(object sender, EventArgs e)
        {
            if (Form_Login.DoValidations(this) == false) return;

            try
            {
                int publisher_id = int.Parse(this.txt_publisherId.Value.ToString());
                Yayinevleri myYayin = new Yayinevleri();
                myYayin.Update(publisher_id, this.txt_publisherName.Value.ToString(), DateTime.Parse(this.txt_establishmentDate.Value.ToString()));
                this.Sorgula();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btn_yayineviSil_Click(object sender, EventArgs e)
        {
            if (Form_Login.ConfirmForDeletion() == true)
            {
                int publisher_id = int.Parse(this.txt_publisherId.Value.ToString());
                Yayinevleri myYayin = new Yayinevleri();
                myYayin.Delete(publisher_id);
                this.Sorgula();
            }
        }

        private void dg_yayinevleri_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dg_yayinevleri.DataSource != null)
            {
                this.txt_publisherId.Value = this.dg_yayinevleri.CurrentRow.Cells["publisher_id"].Value.ToString();
                this.txt_publisherName.Value = this.dg_yayinevleri.CurrentRow.Cells["publisher_name"].Value.ToString();
                if (this.dg_yayinevleri.CurrentRow.Cells["establishment_date"].Value != null)
                {
                    this.txt_establishmentDate.Value = this.dg_yayinevleri.CurrentRow.Cells["establishment_date"].Value.ToString();
                }
            }
            

        }

        private void Form_Yayinevleri_Load(object sender, EventArgs e)
        {
            this.Sorgula();
            this.Text = this.Text + "[ " + this.Name + " ]";
        }
    }
}
