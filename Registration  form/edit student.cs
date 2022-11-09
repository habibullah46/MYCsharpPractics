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
using helperspace;
namespace Registration__form
{
    public partial class edit_student : Form
    {
        public edit_student()
        {
            InitializeComponent();
        }

        private void edit_student_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mySQLworkDataSet1.lbl_table' table. You can move, or remove it, as needed.
            //this.lbl_tableTableAdapter.Fill(this.mySQLworkDataSet1.lbl_table);

        }

        private void cbm_RegisterID_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Querry = "SELECT * lbl_table WHERE RegistrationID='"+cbm_RegisterID+"'";
            SqlConnection con = new SqlConnection(helper.Constring);
            con.Open();
            SqlCommand cmd = new SqlCommand(Querry, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if(dr.Read())
            {
                txt_name.Text = dr["name"].ToString();
                txt_fathername.Text = dr["FatherName"].ToString();
                txt_rollNO.Text = dr["RollNo"].ToString();
                txt_Email.Text = dr["Email"].ToString();
                txt_Address.Text = dr["Address"].ToString();
            }

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
          DialogResult result= MessageBox.Show("Are u sure u want to delete " + txt_name.Text + "Record"," Confirmation Message ",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string Query = "DELETE FROM tbl_student WHERE + cbm_RegisterID + \"'";
                SqlConnection con = new SqlConnection(helper.Constring);
                con.Open();
                SqlCommand cmd = new SqlCommand(Query, con);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
