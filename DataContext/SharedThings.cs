using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.XPath;
using CustomControls.MyControls;

namespace KitapProje.DataContext
{

    public static class SharedThings
    {
        private static DataDBContext myDBContextOBJ;

        public static void ConnectDB()
        {
            myDBContextOBJ = new DataDBContext();
        }
        
        public static DataDBContext getConnOBJ()
        {
            return myDBContextOBJ;
        }

        public static Control DoValitationControls(Control pControl,out string pMessage)
        {
            pMessage = string.Empty;
            if (pControl == null) return null;
            //Control x = pControl;

            foreach (Control x in pControl.Controls)
            {
                //pMessage = "Bu alan boş bırakılamaz";
                if (x is TextBox)
                {
                    //((TextBox)x).Text = String.Empty;
                    if (((TextBox)x).Tag == "required" && ((TextBox)x).Text == string.Empty)
                    {
                        pMessage = "Bu alan boş bırakılamaz";
                        return x;
                    }
                } 
                else if (x is StringControl)
                {
                    if (((StringControl)x).Required && ((StringControl)x).Value is null)
                    {
                        pMessage = "'" + ((StringControl)x).Label + "' Alanı boş bırakılamaz";
                        return x;
                    }
                } 
                else if (x is ComboControl)
                {
                    if (((ComboControl)x).Required && ((ComboControl)x).Value is null)
                    {
                        pMessage = "'" + ((StringControl)x).Label + "' Alanı boş bırakılamaz";
                        return x;
                    }
                } 
                else if (x is DateControl)
                {
                    if (((DateControl)x).Required && ((DateControl)x).Value is null)
                    {
                        pMessage = "'" + ((StringControl)x).Label + "' Alanı boş bırakılamaz";
                        return x;
                    }
                }
                else
                {
                    if (x.HasChildren)
                    {
                        var arg = DoValitationControls(x, out pMessage);
                        if (arg != null) return arg;
                    }
                }

            }
            return null;
        }

        public static void DoLogon(string pEmail, string pSifre)
        {
            object[] parameters = { pEmail, pSifre};
            var result = myDBContextOBJ.Database.SqlQuery<int>("select public.fn_logon({0},{1})",parameters).ToList();
            if (result is null || result[0] == 0)
            {
                throw new Exception("Kullanıcı ve/veya şifre hatalı");
            }
        }
    }
}
