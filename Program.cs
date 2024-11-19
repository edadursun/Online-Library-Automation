using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KitapProje
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(GlobalHataYakalayici);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form_Login());
        }

        static void GlobalHataYakalayici(object sender, UnhandledExceptionEventArgs e)
        {
            // Global hata işleme kodu
            Exception ex = (Exception)e.ExceptionObject;
            MessageBox.Show("GLOBAL HATA : " + ex.Message);
            //Console.WriteLine("Global Hata: " + ex.Message);
            // Hata kaydı
            //LogHata(ex);
        }
    }
}
