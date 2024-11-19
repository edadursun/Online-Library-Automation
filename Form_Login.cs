using KitapProje.DataContext.Entities;
using Npgsql.Internal.TypeHandlers.LTreeHandlers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KitapProje
{
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();
            KitapProje.DataContext.SharedThings.ConnectDB();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (Form_Login.DoValidations(this) == false) return;

            try
            {
                KitapProje.DataContext.SharedThings.DoLogon(this.txt_email.Value.ToString(), this.txt_password.Value.ToString());  
                this.Hide();
                MainPage mainPage = new MainPage(this);
                mainPage.Show(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form_Login_Load(object sender, EventArgs e)
        {
            this.Text = this.Text + "[ " + this.Name + " ]";
        }

        public static bool DoValidations(Form pForm)
        {
            string pMessage;
            var myControl = KitapProje.DataContext.SharedThings.DoValitationControls(pForm, out pMessage);
            if (myControl != null)
            {
                myControl.Focus();
                MessageBox.Show(pMessage);
                return false;
            }
            return true;
        }

        public static bool ConfirmForDeletion()
        {
            DialogResult result = MessageBox.Show("Bu kaydı silmek istediğinize emin misiniz?",
            "Kayıt Silme", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                return true;
            }
            return false;
        }

        public string ReturnMail => this.txt_email.Value.ToString();
    }
}
