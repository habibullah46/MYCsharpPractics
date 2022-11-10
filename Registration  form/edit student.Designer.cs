namespace Registration__form
{
    partial class edit_student
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txt_Address = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_rollNO = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_fathername = new System.Windows.Forms.TextBox();
            this.lbl_fathername = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.cbm_RegisterID = new System.Windows.Forms.ComboBox();
            this.lbltableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mySQLworkDataSet1 = new Registration__form.mySQLworkDataSet1();
            this.lbl_tableTableAdapter = new Registration__form.mySQLworkDataSet1TableAdapters.lbl_tableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.lbltableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mySQLworkDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Address
            // 
            this.txt_Address.Location = new System.Drawing.Point(228, 472);
            this.txt_Address.Multiline = true;
            this.txt_Address.Name = "txt_Address";
            this.txt_Address.Size = new System.Drawing.Size(252, 120);
            this.txt_Address.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(121, 472);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 20);
            this.label6.TabIndex = 22;
            this.label6.Text = "Address:";
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(255, 405);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(171, 26);
            this.txt_Email.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(131, 404);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "Email:";
            // 
            // txt_rollNO
            // 
            this.txt_rollNO.Location = new System.Drawing.Point(255, 338);
            this.txt_rollNO.Name = "txt_rollNO";
            this.txt_rollNO.Size = new System.Drawing.Size(171, 26);
            this.txt_rollNO.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(127, 336);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "RollNo:";
            // 
            // txt_fathername
            // 
            this.txt_fathername.Location = new System.Drawing.Point(255, 271);
            this.txt_fathername.Name = "txt_fathername";
            this.txt_fathername.Size = new System.Drawing.Size(171, 26);
            this.txt_fathername.TabIndex = 17;
            // 
            // lbl_fathername
            // 
            this.lbl_fathername.AutoSize = true;
            this.lbl_fathername.Location = new System.Drawing.Point(123, 268);
            this.lbl_fathername.Name = "lbl_fathername";
            this.lbl_fathername.Size = new System.Drawing.Size(69, 20);
            this.lbl_fathername.TabIndex = 16;
            this.lbl_fathername.Text = "F.Name:";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(255, 204);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(171, 26);
            this.txt_name.TabIndex = 15;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(130, 200);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(55, 20);
            this.lbl_name.TabIndex = 14;
            this.lbl_name.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Registration ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(146, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(389, 41);
            this.label2.TabIndex = 24;
            this.label2.Text = "Edit Student Details";
            // 
            // btn_update
            // 
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_update.Location = new System.Drawing.Point(228, 598);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(94, 36);
            this.btn_update.TabIndex = 25;
            this.btn_update.Text = " Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_delete.Location = new System.Drawing.Point(386, 598);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(94, 36);
            this.btn_delete.TabIndex = 26;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // cbm_RegisterID
            // 
            this.cbm_RegisterID.DataSource = this.lbltableBindingSource;
            this.cbm_RegisterID.DisplayMember = "RegistrationID";
            this.cbm_RegisterID.FormattingEnabled = true;
            this.cbm_RegisterID.Location = new System.Drawing.Point(255, 124);
            this.cbm_RegisterID.Name = "cbm_RegisterID";
            this.cbm_RegisterID.Size = new System.Drawing.Size(171, 28);
            this.cbm_RegisterID.TabIndex = 27;
            this.cbm_RegisterID.ValueMember = "RegistrationID";
            this.cbm_RegisterID.SelectedIndexChanged += new System.EventHandler(this.cbm_RegisterID_SelectedIndexChanged);
            // 
            // lbltableBindingSource
            // 
            this.lbltableBindingSource.DataMember = "lbl_table";
            this.lbltableBindingSource.DataSource = this.mySQLworkDataSet1;
            // 
            // mySQLworkDataSet1
            // 
            this.mySQLworkDataSet1.DataSetName = "mySQLworkDataSet1";
            this.mySQLworkDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lbl_tableTableAdapter
            // 
            this.lbl_tableTableAdapter.ClearBeforeFill = true;
            // 
            // edit_student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 715);
            this.Controls.Add(this.cbm_RegisterID);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Address);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_rollNO);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_fathername);
            this.Controls.Add(this.lbl_fathername);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.label1);
            this.Name = "edit_student";
            this.Text = "edit_student";
            this.Load += new System.EventHandler(this.edit_student_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lbltableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mySQLworkDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Address;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_rollNO;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_fathername;
        private System.Windows.Forms.Label lbl_fathername;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.ComboBox cbm_RegisterID;
        private mySQLworkDataSet1 mySQLworkDataSet1;
        private System.Windows.Forms.BindingSource lbltableBindingSource;
        private mySQLworkDataSet1TableAdapters.lbl_tableTableAdapter lbl_tableTableAdapter;
    }
}