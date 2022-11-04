using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registration__form
{
    public partial class Form1 : Form
    {
        string Constring = System.Configuration.ConfigurationManager.ConnectionStrings["myConstring"].ToString();
        public Form1()
        {
            InitializeComponent();
        }

        private  void btn_save_Click(object sender, EventArgs e)
        {
            string sqlQuery = "INSERT INTO lbl_table VALUES('" + txt_registrationID.Text + "','" + txt_name.Text + "','" + txt_fathername.Text + "','" + txt_rollNO.Text + "','" + txt_Email.Text + "','" + txt_Address.Text + "' )"; 
          SqlConnection con = new SqlConnection(Constring);
            con.Open();
            SqlCommand cmd = new SqlCommand(sqlQuery, con);
            cmd.ExecuteNonQuery();
            

        }
    }
}
