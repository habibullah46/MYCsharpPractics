using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using helperspace;


namespace Registration__form
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string sqlQuery = "INSERT INTO lbl_table VALUES('" + txt_registrationID.Text + "','" + txt_name.Text + "','" + txt_fathername.Text + "','" + txt_rollNO.Text.ToString() + "','" + txt_Email.Text + "','" + txt_Address.Text + "' )";
            SqlConnection con = new SqlConnection(helper.Constring);
            con.Open();
            SqlCommand cmd = new SqlCommand(sqlQuery, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record save successfully", "alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            helper.clear(this);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mySQLworkDataSet.lbl_table' table. You can move, or remove it, as needed.
            //this.lbl_tableTableAdapter.Fill(this.mySQLworkDataSet.lbl_table);

        }

        private void gv_student_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_record_Click(object sender, EventArgs e)
        {
            edit_student obj = new edit_student();
            obj.ShowDialog();
        }
        //private void clear()
        //{
        //    txt_Address.Clear();
        //    txt_Email.Clear();
        //    txt_fathername.Clear();
        //    txt_name.Clear();
        //    txt_registrationID.Clear();
        //    txt_rollNO.Clear();

        //}

    }
}