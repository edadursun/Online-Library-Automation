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
    public partial class Form_Turler : Form
    {
        public Form_Turler()
        {
            InitializeComponent();
            //KitapProje.DataContext.SharedThings.ConnectDB();
        }

        private void btn_turlerSorgula_Click(object sender, EventArgs e)
        {
            this.Sorgula();
        }

        void Sorgula ()
        {
            Turler myTur = new Turler();
            this.dg_turler.DataSource = myTur.Select();
        }

        private void btn_turlerEkle_Click(object sender, EventArgs e)
        {
            if (Form_Login.DoValidations(this) == false) return;

            try
            {
                Turler mytur = new Turler
                {
                    genre_id = null,
                    genre_name = this.txt_genreName.Value.ToString(),
                };
                mytur.Insert(mytur);
                this.Sorgula();

            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_turlerGuncelle_Click(object sender, EventArgs e)
        {
            if (Form_Login.DoValidations(this) == false) return;

            try
            {
                int genreId = int.Parse(this.txt_genreId.Value.ToString());
                Turler mytur = new Turler();
                mytur.Update(genreId, this.txt_genreName.Value.ToString());
                this.Sorgula();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_turlerSil_Click(object sender, EventArgs e)
        {
            if (Form_Login.ConfirmForDeletion() == true)
            {
                Turler mytur = new Turler();
                int genreId = int.Parse(this.txt_genreId.Value.ToString());
                mytur.Delete(genreId);
                this.Sorgula();
            }

        }

        private void dg_turler_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dg_turler.DataSource != null)
            {
                this.txt_genreId.Value = this.dg_turler.CurrentRow.Cells["genre_id"].Value.ToString();
                this.txt_genreName.Value = this.dg_turler.CurrentRow.Cells["genre_name"].Value.ToString();
            }

        }

        private void Form_Turler_Shown(object sender, EventArgs e)
        {
            this.Sorgula();
        }

        private void Form_Turler_Load(object sender, EventArgs e)
        {
            this.Sorgula();
            this.Text = this.Text + "[ " + this.Name + " ]";
        }
    }
}
