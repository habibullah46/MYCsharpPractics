using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace helperspace


{
    public static class helper
    {
       public static string Constring = System.Configuration.ConfigurationManager.ConnectionStrings["myConstring"].ToString();
        public static void clear(Form form)
        {
            foreach (var item in form.Controls)
            {
                if (item is TextBox)
                {
                    TextBox txt = (TextBox)item;
                    txt.Clear();
                }
            }
        }
    }
}
