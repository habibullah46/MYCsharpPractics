namespace Registration__form
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_registrationID = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.txt_fathername = new System.Windows.Forms.TextBox();
            this.lbl_fathername = new System.Windows.Forms.Label();
            this.txt_rollNO = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Address = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.gv_student = new System.Windows.Forms.DataGridView();
            this.registrationIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fatherNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rollNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbltableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mySQLworkDataSet = new Registration__form.mySQLworkDataSet();
            this.lbl_tableTableAdapter = new Registration__form.mySQLworkDataSetTableAdapters.lbl_tableTableAdapter();
            this.btn_record = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gv_student)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbltableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mySQLworkDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registration ID:";
            // 
            // txt_registrationID
            // 
            this.txt_registrationID.Location = new System.Drawing.Point(186, 108);
            this.txt_registrationID.Name = "txt_registrationID";
            this.txt_registrationID.Size = new System.Drawing.Size(171, 26);
            this.txt_registrationID.TabIndex = 1;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(186, 175);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(171, 26);
            this.txt_name.TabIndex = 3;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(61, 171);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(55, 20);
            this.lbl_name.TabIndex = 2;
            this.lbl_name.Text = "Name:";
            // 
            // txt_fathername
            // 
            this.txt_fathername.Location = new System.Drawing.Point(186, 242);
            this.txt_fathername.Name = "txt_fathername";
            this.txt_fathername.Size = new System.Drawing.Size(171, 26);
            this.txt_fathername.TabIndex = 5;
            // 
            // lbl_fathername
            // 
            this.lbl_fathername.AutoSize = true;
            this.lbl_fathername.Location = new System.Drawing.Point(54, 239);
            this.lbl_fathername.Name = "lbl_fathername";
            this.lbl_fathername.Size = new System.Drawing.Size(69, 20);
            this.lbl_fathername.TabIndex = 4;
            this.lbl_fathername.Text = "F.Name:";
            // 
            // txt_rollNO
            // 
            this.txt_rollNO.Location = new System.Drawing.Point(186, 309);
            this.txt_rollNO.Name = "txt_rollNO";
            this.txt_rollNO.Size = new System.Drawing.Size(171, 26);
            this.txt_rollNO.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "RollNo:";
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(186, 376);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(171, 26);
            this.txt_Email.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(62, 375);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Email:";
            // 
            // txt_Address
            // 
            this.txt_Address.Location = new System.Drawing.Point(159, 443);
            this.txt_Address.Multiline = true;
            this.txt_Address.Name = "txt_Address";
            this.txt_Address.Size = new System.Drawing.Size(252, 120);
            this.txt_Address.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 443);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Address:";
            // 
            // btn_save
            // 
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_save.Location = new System.Drawing.Point(159, 596);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(134, 39);
            this.btn_save.TabIndex = 12;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Engravers MT", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(285, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(454, 47);
            this.label2.TabIndex = 13;
            this.label2.Text = "Student Form";
            // 
            // gv_student
            // 
            this.gv_student.AutoGenerateColumns = false;
            this.gv_student.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_student.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.registrationIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.fatherNameDataGridViewTextBoxColumn,
            this.rollNoDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn});
            this.gv_student.DataSource = this.lbltableBindingSource;
            this.gv_student.Location = new System.Drawing.Point(438, 79);
            this.gv_student.Name = "gv_student";
            this.gv_student.RowHeadersWidth = 62;
            this.gv_student.RowTemplate.Height = 28;
            this.gv_student.Size = new System.Drawing.Size(966, 535);
            this.gv_student.TabIndex = 14;
            this.gv_student.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_student_CellContentClick);
            // 
            // registrationIDDataGridViewTextBoxColumn
            // 
            this.registrationIDDataGridViewTextBoxColumn.DataPropertyName = "RegistrationID";
            this.registrationIDDataGridViewTextBoxColumn.HeaderText = "RegistrationID";
            this.registrationIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.registrationIDDataGridViewTextBoxColumn.Name = "registrationIDDataGridViewTextBoxColumn";
            this.registrationIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 150;
            // 
            // fatherNameDataGridViewTextBoxColumn
            // 
            this.fatherNameDataGridViewTextBoxColumn.DataPropertyName = "FatherName";
            this.fatherNameDataGridViewTextBoxColumn.HeaderText = "FatherName";
            this.fatherNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.fatherNameDataGridViewTextBoxColumn.Name = "fatherNameDataGridViewTextBoxColumn";
            this.fatherNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // rollNoDataGridViewTextBoxColumn
            // 
            this.rollNoDataGridViewTextBoxColumn.DataPropertyName = "RollNo";
            this.rollNoDataGridViewTextBoxColumn.HeaderText = "RollNo";
            this.rollNoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.rollNoDataGridViewTextBoxColumn.Name = "rollNoDataGridViewTextBoxColumn";
            this.rollNoDataGridViewTextBoxColumn.Width = 150;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 150;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.Width = 150;
            // 
            // lbltableBindingSource
            // 
            this.lbltableBindingSource.DataMember = "lbl_table";
            this.lbltableBindingSource.DataSource = this.mySQLworkDataSet;
            // 
            // mySQLworkDataSet
            // 
            this.mySQLworkDataSet.DataSetName = "mySQLworkDataSet";
            this.mySQLworkDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lbl_tableTableAdapter
            // 
            this.lbl_tableTableAdapter.ClearBeforeFill = true;
            // 
            // btn_record
            // 
            this.btn_record.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_record.Location = new System.Drawing.Point(1141, 620);
            this.btn_record.Name = "btn_record";
            this.btn_record.Size = new System.Drawing.Size(213, 39);
            this.btn_record.TabIndex = 15;
            this.btn_record.Text = "Edit student Record";
            this.btn_record.UseVisualStyleBackColor = true;
            this.btn_record.Click += new System.EventHandler(this.btn_record_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1425, 679);
            this.Controls.Add(this.btn_record);
            this.Controls.Add(this.gv_student);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_save);
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
            this.Controls.Add(this.txt_registrationID);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gv_student)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbltableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mySQLworkDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_registrationID;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.TextBox txt_fathername;
        private System.Windows.Forms.Label lbl_fathername;
        private System.Windows.Forms.TextBox txt_rollNO;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Address;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView gv_student;
        private mySQLworkDataSet mySQLworkDataSet;
        private System.Windows.Forms.BindingSource lbltableBindingSource;
        private mySQLworkDataSetTableAdapters.lbl_tableTableAdapter lbl_tableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn registrationIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fatherNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rollNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_record;
    }
}

