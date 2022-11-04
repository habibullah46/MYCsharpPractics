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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(193, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registration ID:";
            // 
            // txt_registrationID
            // 
            this.txt_registrationID.Location = new System.Drawing.Point(392, 110);
            this.txt_registrationID.Name = "txt_registrationID";
            this.txt_registrationID.Size = new System.Drawing.Size(162, 26);
            this.txt_registrationID.TabIndex = 1;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(392, 177);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(162, 26);
            this.txt_name.TabIndex = 3;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(226, 181);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(55, 20);
            this.lbl_name.TabIndex = 2;
            this.lbl_name.Text = "Name:";
            // 
            // txt_fathername
            // 
            this.txt_fathername.Location = new System.Drawing.Point(392, 244);
            this.txt_fathername.Name = "txt_fathername";
            this.txt_fathername.Size = new System.Drawing.Size(162, 26);
            this.txt_fathername.TabIndex = 5;
            // 
            // lbl_fathername
            // 
            this.lbl_fathername.AutoSize = true;
            this.lbl_fathername.Location = new System.Drawing.Point(219, 249);
            this.lbl_fathername.Name = "lbl_fathername";
            this.lbl_fathername.Size = new System.Drawing.Size(69, 20);
            this.lbl_fathername.TabIndex = 4;
            this.lbl_fathername.Text = "F.Name:";
            // 
            // txt_rollNO
            // 
            this.txt_rollNO.Location = new System.Drawing.Point(392, 311);
            this.txt_rollNO.Name = "txt_rollNO";
            this.txt_rollNO.Size = new System.Drawing.Size(162, 26);
            this.txt_rollNO.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(223, 317);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "RollNo:";
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(392, 378);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(162, 26);
            this.txt_Email.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(227, 385);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Email:";
            // 
            // txt_Address
            // 
            this.txt_Address.Location = new System.Drawing.Point(365, 445);
            this.txt_Address.Multiline = true;
            this.txt_Address.Name = "txt_Address";
            this.txt_Address.Size = new System.Drawing.Size(243, 120);
            this.txt_Address.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(217, 453);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Address:";
            // 
            // btn_save
            // 
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_save.Location = new System.Drawing.Point(419, 606);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(125, 39);
            this.btn_save.TabIndex = 12;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(258, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 31);
            this.label2.TabIndex = 13;
            this.label2.Text = "Student Register";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 679);
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
    }
}

