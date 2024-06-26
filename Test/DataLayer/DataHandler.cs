﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;
using System.Windows.Forms;
using Test.BusinessLogicLayer;
using System.Runtime.Remoting.Contexts;

namespace Test.DataLayer
{
    internal class DataHandler
    {
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        string con = "Server= .;Initial Catalog= BelgiumCampusDB_PRG282;Integrated Security=SSPI";

        public DataTable getStudents()
        {
            string query = $"SELECT * FROM Students " +
                $"JOIN StudentAddress ON Students.StudentID = StudentAddress.StudentID " +
                $"JOIN Course ON Students.StudentID = Course.StudentID " +
                $"JOIN Modules ON Course.CourseCode = Modules.CourseCode";

            string conn = "Server= .;Initial Catalog= BelgiumCampusDB_PRG282;Integrated Security=SSPI";
            adapter = new SqlDataAdapter(query,conn);
            adapter.Fill(table);
            return table;
        }

        public void UpdateImage(string filePath, int studentID)
        {
            // Read the file into a byte array
            byte[] imageData = File.ReadAllBytes(filePath);

            // Open a connection to the database
            using (SqlConnection conn = new SqlConnection(con))
            {
                try
                {
                    conn.Open();

                    // Create a command to insert the image
                    using (SqlCommand cmd = new SqlCommand("UPDATE Students SET StudentImage = @Image WHERE StudentID = " + studentID, conn))
                    {
                        // Add the image parameter and set its value
                        cmd.Parameters.Add(new SqlParameter("@Image", imageData));

                        // Execute the command
                        cmd.ExecuteNonQuery();
                    }
                } catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    MessageBox.Show("Error connecting to database");
                }finally { conn.Close(); }
            }
        }

        public byte[] GetImageData(int Id)
        {
            byte[] imageData = null;

            // Open a connection to the database
            using (SqlConnection conn = new SqlConnection(con))
            {
                conn.Open();

                // Create a command to get the image
                using (SqlCommand cmd = new SqlCommand("SELECT StudentImage FROM Students WHERE StudentID = @ID", conn))
                {
                    // Add the StudentID parameter and set its value
                    cmd.Parameters.AddWithValue("@id", Id);

                    // Execute the command and get the image data
                    imageData = (byte[])cmd.ExecuteScalar();
                }
            }

            return imageData;
        }

        public void DeleteStudent(int Id)
        {
            using (SqlConnection conn = new SqlConnection(con))
            {
                try
                {
                    conn.Open();

                    // Create a command to insert the image
                    using (SqlCommand cmd = new SqlCommand("DELETE Students WHERE StudentID = " + Id, conn))
                    {
                        // Execute the command
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Student removed successfully");
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    MessageBox.Show("Error connecting to database");
                }
                finally { conn.Close(); }
            }
        }
        public void DeleteModule(int Id)
        {
            using (SqlConnection conn = new SqlConnection(con))
            {
                try
                {
                    conn.Open();

                    // Create a command to insert the image
                    using (SqlCommand cmd = new SqlCommand("DELETE Modules WHERE CourseCode = " + Id, conn))
                    {
                        // Execute the command
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Module removed successfully");
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    MessageBox.Show("Error connecting to database");
                }
                finally { conn.Close(); }
            }
        }
        public void AddStudent(Student student)
        {
            string query = $"INSERT INTO Students (StudentID,FirstName,Surname,DOB,Gender,Phone,StudentImage) VALUES " +
                            $"('@studentID','@name','@surname','@dob','@gender','@phone','@stdImg')";
            
            using (SqlConnection conn = new SqlConnection(con))
            {
                try
                {
                    conn.Open();

                    // Create a command to insert new student
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@studentID", student.StudentID);
                        cmd.Parameters.AddWithValue("@name", student.StudentID);
                        cmd.Parameters.AddWithValue("@surname", student.StudentID);
                        cmd.Parameters.AddWithValue("@dob", student.StudentID);
                        cmd.Parameters.AddWithValue("@gender", student.StudentID);
                        cmd.Parameters.AddWithValue("@phone", student.StudentID);
                        cmd.Parameters.AddWithValue("@stdImg", student.StudentID);
                        // Execute the command
                        cmd.ExecuteNonQuery();
                        
                        MessageBox.Show("Student added successfully");
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    MessageBox.Show("Error connecting to database");
                }
                finally { conn.Close(); }
            }
        }
        
        public void AddCourse(int CodeCourse, int StudentID)
        {
            string query = $"INSERT INTO Course (CourseCode, StudentID) VALUES " +
            $"('@courseCode','@studentID')";

            using (SqlConnection conn = new SqlConnection(con))
            {
                try
                {
                    conn.Open();

                    // Create a command to insert  
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@courseCode", CodeCourse);
                        cmd.Parameters.AddWithValue("@studentID", StudentID);
                        // Execute the command
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    MessageBox.Show("Error connecting to database");
                }
                finally { conn.Close(); }
            }
        }
        public void AddModule(Course Courses)
        {
            string query = $"INSERT INTO Modules (CourseCode, ModuleName, ModuleDescription) VALUES " +
                            $"('@courseCode','@moduleName','@moduleDesc')";

            using (SqlConnection conn = new SqlConnection(con))
            {
                try
                {
                    conn.Open();

                    // Create a command to insert  
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@courseCode", Courses.CourseCode);
                        cmd.Parameters.AddWithValue("@moduleName", Courses.ModuleName);
                        cmd.Parameters.AddWithValue("@moduleDesc", Courses.ModuleDescription);
                        // Execute the command
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    MessageBox.Show("Error connecting to database");
                }
                finally { conn.Close(); }
            }
        }

        /*public void UpdateModulesData(Course course)
        {
            string query = $"UPDATE Modules SET " +
                $"CourseCode = '{course.CourseCode}', " +
                $"ModuleName = '{course.ModuleName}', " +
                $"ModuleDescription = '{course.ModuleDescription}', " +
                $"WHERE CourseCode = '{course.CourseCode}';";
            try
            {
                using (SqlConnection conn = new SqlConnection(con))
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        command.ExecuteNonQuery();
                        conn.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }*/

        public void UpdateModulesData(int moduleID, string newModuleName, string newModuleDescription)
        {
            string query = "UPDATE Modules SET " +
                "ModuleName = @NewModuleName, ModuleDescription = @NewModuleDescription " +
                "WHERE CourseCode = @moduleID";

            using (SqlConnection conn = new SqlConnection(con))
            {
                try
                {
                    conn.Open();

                    // Create a command to update the data in the Modules table
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Add parameters and set their values
                        cmd.Parameters.AddWithValue("@NewModuleName", newModuleName);
                        cmd.Parameters.AddWithValue("@NewModuleDescription", newModuleDescription);
                        cmd.Parameters.AddWithValue("@moduleID", moduleID);

                        // Execute the command
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Modules data updated successfully");
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    MessageBox.Show("Error updating Modules data");
                }
                finally { conn.Close(); }
            }
        }

        public void UpdateStudentsData(int studentID, string newFirstName, string newSurname, DateTime newDOB, string newGender, string newPhone, string newCampus)
        {
            string query = "UPDATE Students SET " +
                "FirstName = @NewFirstName, Surname = @NewSurname, DOB = @NewDOB, " +
                "Gender = @NewGender, Phone = @NewPhone, Campus = @NewCampus " +
                "WHERE StudentID = @studentID";

            using (SqlConnection conn = new SqlConnection(con))
            {
                try
                {
                    conn.Open();

                    // Create a command to update the data in the Students table
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Add parameters and set their values
                        cmd.Parameters.AddWithValue("@NewFirstName", newFirstName);
                        cmd.Parameters.AddWithValue("@NewSurname", newSurname);
                        cmd.Parameters.AddWithValue("@NewDOB", newDOB);
                        cmd.Parameters.AddWithValue("@NewGender", newGender);
                        cmd.Parameters.AddWithValue("@NewPhone", newPhone);
                        cmd.Parameters.AddWithValue("@NewCampus", newCampus);
                        cmd.Parameters.AddWithValue("@studentID", studentID);

                        // Execute the command
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Students data updated successfully");
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    MessageBox.Show("Error updating Students data");
                }
                finally { conn.Close(); }
            }
        }

        public DataTable SearchStudent(int stdID)
        {
            string query = $"SELECT * FROM Students " +
                           $"JOIN StudentAddress ON Students.StudentID = StudentAddress.StudentID " +
                           $"JOIN Course ON Students.StudentID = Course.StudentID " +
                           $"JOIN Modules ON Course.CourseCode = Modules.CourseCode " +
                           $"WHERE Students.StudentID = @stdID";

            string conn = "Server= .;Initial Catalog= BelgiumCampusDB_PRG282;Integrated Security=SSPI";
            adapter = new SqlDataAdapter(query, conn);
            adapter.Fill(table);
            return table;
        }
        public DataTable SearchModule (int courseID)
        {
            string query = $"SELECT * FROM Modules " +
                           $"WHERE CourseID = @courseID";

            string conn = "Server= .;Initial Catalog= BelgiumCampusDB_PRG282;Integrated Security=SSPI";
            adapter = new SqlDataAdapter(query, conn);
            adapter.Fill(table);
            return table;
        }

        public void Register(string username, string password)
        {
            string filePath = @"LoginData.txt";

            try
            {
                if (File.Exists(filePath))
                {
                    using (StreamWriter writer = new StreamWriter(filePath,true)) //True means append
                    {
                        writer.WriteLine(username + "," + password);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Textfile does not exist");
            }
          
        }
    }
}
