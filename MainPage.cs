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
    public partial class MainPage : Form
    {
        private Form_Login LoginFormRef = null;

        public MainPage(Form_Login loginFormRef)
        {
            this.LoginFormRef = loginFormRef;
            InitializeComponent();
        }
        //public MainPage()
        //{
        //    InitializeComponent();
        //}

        private void mi_turler_Click(object sender, EventArgs e)
        {
            Form_Turler form_Turler = new Form_Turler();
            form_Turler.ShowDialog(this);
        }

        private void MainPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void mi_yazarlar_Click(object sender, EventArgs e)
        {
            Form_Yazarlar form_Yazarlar = new Form_Yazarlar();
            form_Yazarlar.ShowDialog(this);
        }

        private void mi_yayinevleri_Click(object sender, EventArgs e)
        {
            Form_Yayinevleri form_Yayinevleri = new Form_Yayinevleri();
            form_Yayinevleri.ShowDialog(this);
        }

        private void mi_kitaplar_Click(object sender, EventArgs e)
        {
            Form_Kitaplar form_kitaplar = new Form_Kitaplar();
            form_kitaplar.ShowDialog(this);
        }

        private void mi_yorumekle_Click(object sender, EventArgs e)
        {
            Form_Yorumlar form_Yorumlar = new Form_Yorumlar(LoginFormRef); 
            form_Yorumlar.ShowDialog(this);
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            this.Text = this.Text + "[ " + this.Name + " ]";
        }
    }
}
