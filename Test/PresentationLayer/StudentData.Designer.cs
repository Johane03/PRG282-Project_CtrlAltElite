namespace Test
{
    partial class StudentData
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
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDOB = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.rtxModules = new System.Windows.Forms.RichTextBox();
            this.rtxAddress = new System.Windows.Forms.RichTextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.picbxStudent = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_BackStudent = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbxStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(580, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 59);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Data";
            // 
            // dgvStudents
            // 
            this.dgvStudents.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(99)))), ((int)(((byte)(255)))));
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.GridColor = System.Drawing.Color.White;
            this.dgvStudents.Location = new System.Drawing.Point(26, 135);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.RowHeadersWidth = 51;
            this.dgvStudents.RowTemplate.Height = 24;
            this.dgvStudents.Size = new System.Drawing.Size(1349, 322);
            this.dgvStudents.TabIndex = 2;
            this.dgvStudents.SelectionChanged += new System.EventHandler(this.dgvStudents_SelectionChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 530);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 33);
            this.label3.TabIndex = 3;
            this.label3.Text = "Student Number: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 648);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 33);
            this.label4.TabIndex = 4;
            this.label4.Text = "Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(576, 648);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 33);
            this.label5.TabIndex = 5;
            this.label5.Text = "Surname:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(68, 775);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 33);
            this.label6.TabIndex = 6;
            this.label6.Text = "Date of Birth:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(592, 775);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 33);
            this.label7.TabIndex = 7;
            this.label7.Text = "Gender:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 912);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 33);
            this.label2.TabIndex = 8;
            this.label2.Text = "Phone:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(582, 912);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 33);
            this.label8.TabIndex = 9;
            this.label8.Text = "Address:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(68, 1044);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 33);
            this.label9.TabIndex = 10;
            this.label9.Text = "Modules:";
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Location = new System.Drawing.Point(143, 645);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(326, 39);
            this.txtName.TabIndex = 11;
            // 
            // txtDOB
            // 
            this.txtDOB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDOB.Location = new System.Drawing.Point(213, 769);
            this.txtDOB.Name = "txtDOB";
            this.txtDOB.Size = new System.Drawing.Size(256, 39);
            this.txtDOB.TabIndex = 12;
            // 
            // txtPhone
            // 
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhone.Location = new System.Drawing.Point(148, 910);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(321, 39);
            this.txtPhone.TabIndex = 13;
            // 
            // txtGender
            // 
            this.txtGender.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGender.Location = new System.Drawing.Point(679, 769);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(256, 39);
            this.txtGender.TabIndex = 14;
            // 
            // txtSurname
            // 
            this.txtSurname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSurname.Location = new System.Drawing.Point(679, 645);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(256, 39);
            this.txtSurname.TabIndex = 15;
            // 
            // rtxModules
            // 
            this.rtxModules.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtxModules.Location = new System.Drawing.Point(168, 1044);
            this.rtxModules.Name = "rtxModules";
            this.rtxModules.Size = new System.Drawing.Size(301, 146);
            this.rtxModules.TabIndex = 16;
            this.rtxModules.Text = "";
            // 
            // rtxAddress
            // 
            this.rtxAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtxAddress.Location = new System.Drawing.Point(679, 893);
            this.rtxAddress.Name = "rtxAddress";
            this.rtxAddress.Size = new System.Drawing.Size(256, 127);
            this.rtxAddress.TabIndex = 17;
            this.rtxAddress.Text = "";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(99)))), ((int)(((byte)(255)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Showcard Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(743, 1177);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(115, 40);
            this.btnUpdate.TabIndex = 18;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(99)))), ((int)(((byte)(255)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Showcard Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(921, 1177);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(115, 40);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(99)))), ((int)(((byte)(255)))));
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Showcard Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.ForeColor = System.Drawing.Color.White;
            this.btnCreate.Location = new System.Drawing.Point(1097, 1177);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(115, 40);
            this.btnCreate.TabIndex = 20;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnStudentCreate_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(99)))), ((int)(((byte)(255)))));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Showcard Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(260, 1234);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(115, 40);
            this.btnClear.TabIndex = 21;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button5.FlatAppearance.BorderSize = 3;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(1045, 490);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(253, 238);
            this.button5.TabIndex = 23;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // txtStudentID
            // 
            this.txtStudentID.Location = new System.Drawing.Point(248, 528);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(487, 39);
            this.txtStudentID.TabIndex = 25;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = global::Test.Properties.Resources.Screenshot_2023_11_02_174907;
            this.pictureBox3.Location = new System.Drawing.Point(679, 530);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(44, 25);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 26;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // picbxStudent
            // 
            this.picbxStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picbxStudent.Image = global::Test.Properties.Resources.Screenshot_2023_11_02_174631;
            this.picbxStudent.Location = new System.Drawing.Point(1060, 499);
            this.picbxStudent.Name = "picbxStudent";
            this.picbxStudent.Size = new System.Drawing.Size(224, 218);
            this.picbxStudent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbxStudent.TabIndex = 24;
            this.picbxStudent.TabStop = false;
            this.picbxStudent.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Test.Properties.Resources.undraw_education_f8ru2;
            this.pictureBox1.InitialImage = global::Test.Properties.Resources.undraw_education_f8ru;
            this.pictureBox1.Location = new System.Drawing.Point(941, 769);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(475, 350);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // btn_BackStudent
            // 
            this.btn_BackStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(99)))), ((int)(((byte)(255)))));
            this.btn_BackStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_BackStudent.Font = new System.Drawing.Font("Showcard Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BackStudent.ForeColor = System.Drawing.Color.White;
            this.btn_BackStudent.Location = new System.Drawing.Point(12, 12);
            this.btn_BackStudent.Name = "btn_BackStudent";
            this.btn_BackStudent.Size = new System.Drawing.Size(115, 40);
            this.btn_BackStudent.TabIndex = 42;
            this.btn_BackStudent.Text = "<< Back";
            this.btn_BackStudent.UseVisualStyleBackColor = false;
            this.btn_BackStudent.Click += new System.EventHandler(this.btn_BackStudent_Click);
            // 
            // StudentData
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1510, 1100);
            this.Controls.Add(this.btn_BackStudent);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.txtStudentID);
            this.Controls.Add(this.picbxStudent);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.rtxAddress);
            this.Controls.Add(this.rtxModules);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtGender);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtDOB);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvStudents);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Rockwell Condensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MaximumSize = new System.Drawing.Size(2426, 3426);
            this.MinimumSize = new System.Drawing.Size(1426, 1018);
            this.Name = "StudentData";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.StudentData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbxStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDOB;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.RichTextBox rtxModules;
        private System.Windows.Forms.RichTextBox rtxAddress;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.PictureBox picbxStudent;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btn_BackStudent;
    }
}