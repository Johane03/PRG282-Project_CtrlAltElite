using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.BusinessLogicLayer
{
    internal class StudentAddress
    {
        public int StudentID { get; set; }
        public string Street { get; set;}
        public string City { get; set; }
        public string Province { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }

        public StudentAddress(int StudentID,string street,string city,string province,string country,string postalCode) 
        {
            this.StudentID = StudentID;
            this.Street = street;
            this.City = city;
            this.Province = province;
            this.Country = country;
            this.PostalCode = postalCode;
        }
    }
}
