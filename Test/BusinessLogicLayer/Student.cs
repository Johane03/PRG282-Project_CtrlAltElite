using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.BusinessLogicLayer
{
    internal class Student
    {
        public int StudentID { get; set; }
        public string FirstName {  get; set; }
        public string LastName { get; set; }
        public DateTime DOB { get; set; }
        public string Gender { get; set; }
        public string Phone { get; set; }
        public string Campus { get; set; }
        public Image StudentImage { get; set; }

        public Student(int ID, string name, string surname, DateTime birthDate, string gender, string phone, Image studentImg, int studentID, string firstName, string lastName, DateTime dOB, string campus, Image studentImage)
        {
            this.StudentID = ID;
            this.FirstName = name;
            this.LastName = surname;
            this.DOB = birthDate;
            this.Gender = gender;
            this.Phone = phone;
            this.Campus = campus;
            this.StudentImage = studentImg;
        }
    }
}
