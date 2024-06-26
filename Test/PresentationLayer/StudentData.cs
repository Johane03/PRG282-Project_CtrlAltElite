﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Test.BusinessLogicLayer;
using Test.DataLayer;

namespace Test
{
    public partial class StudentData : Form
    {
        string imagePath = "";
        DataHandler handler = new DataHandler();
        public StudentData()
        {
            InitializeComponent();
        }

        private void btn_BackStudent_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnStudentCreate_Click(object sender, EventArgs e)
        {
            StudentAdded studentAdded = new StudentAdded();
            studentAdded.Show();

            Student student = new Student(int.Parse(txtStudentID.Text),txtName.Text,txtSurname.Text,DateTime.Parse(txtDOB.Text),txtGender.Text,txtPhone.Text,txtCampus.Text,picbxStudent.BackgroundImage);
            handler.AddStudent(student);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                picbxStudent.Image = new Bitmap(openFileDialog.FileName);
                imagePath = openFileDialog.FileName;
            }
        }

        public void LoadImage(int Id)
        {
            DataHandler handler = new DataHandler();
            // Get the image data from the database
            byte[] imageData = handler.GetImageData(Id);

            // Convert the image data into a MemoryStream
            using (MemoryStream ms = new MemoryStream(imageData))
            {
                // Load the image from the MemoryStream into the PictureBox
                picbxStudent.Image = Image.FromStream(ms);
            }
        }

        private void dgvStudents_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvStudents.SelectedRows)
            {
                txtStudentID.Text = row.Cells[0].Value.ToString();
                txtName.Text = row.Cells[1].Value.ToString();
                txtSurname.Text = row.Cells[2].Value.ToString();
                txtDOB.Text = row.Cells[3].Value.ToString();
                txtGender.Text = row.Cells[4].Value.ToString();
                txtPhone.Text = row.Cells[5].Value.ToString();
                txtCampus.Text = row.Cells[6].Value.ToString();
                LoadImage(int.Parse(txtStudentID.Text));
            }
        }

        private void StudentData_Load(object sender, EventArgs e)
        {

            dgvStudents.DataSource =  handler.getStudents();
            foreach(DataGridViewColumn column in dgvStudents.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            DataGridViewImageColumn imageCol = (DataGridViewImageColumn)dgvStudents.Columns[6];
            imageCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
               
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            handler.UpdateStudentsData(int.Parse(txtStudentID.Text), txtName.Text, txtSurname.Text, DateTime.Parse(txtDOB.Text), txtGender.Text, txtPhone.Text, txtCampus.Text);
            if (imagePath == null)
            {
                handler.UpdateImage(imagePath, int.Parse(txtStudentID.Text));
            }
            dgvStudents.DataSource = handler.getStudents();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            handler.DeleteStudent(int.Parse(txtStudentID.Text));
            dgvStudents.DataSource = handler.getStudents();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDOB.Clear();
            txtGender.Clear();
            txtName.Clear();
            txtPhone.Clear();
            txtStudentID.Clear();
            txtSurname.Clear();
            txtCampus.Clear();
            rtxModules.Clear();
            picbxStudent.Image = picbxStudent.InitialImage;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {



        }
    }
}
