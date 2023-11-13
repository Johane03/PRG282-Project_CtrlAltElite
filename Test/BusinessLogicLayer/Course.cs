using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.BusinessLogicLayer
{
    internal class Course
    {
        public int CourseCode { get; set; }
        public string ModuleName { get; set; }
        public string ModuleDescription { get; set; }

        public Course(int courseCode, string moduleName,string moduleDesc) 
        {
            this.CourseCode = courseCode;
            this.ModuleName = moduleName;
            this.ModuleDescription = moduleDesc;
        }
    }
}
