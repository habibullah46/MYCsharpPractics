using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            this.lbl_tableTableAdapter.Fill(this.mySQLworkDataSet1.lbl_table);

        }

        private void cbm_RegisterID_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Querry = "SELECT * lbl_table WHERE RegistrationID='"+cbm_RegisterID+"'";
        }
    }
}
