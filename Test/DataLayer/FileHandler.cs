using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Test.BusinessLogicLayer; //Imported layer to use 'Login' class

namespace Test.DataLayer
{
    internal class FileHandler
    {
        //Create a list of Login class to compare textfile with verified login info with entered Username & Password on Login Form
        public List<Login> GetLogins()
        {
            string filePath = "LoginData.txt";
            List<Login> loginList = new List<Login>();
            string[] lines = File.ReadAllLines(filePath);


            foreach (string line in lines)
            {
                string[] items = line.Split(',');
                if (items.Length == 2)
                {
                    foreach (string item in items)
                    {
                        loginList.Add(new Login(items[0], items[1]));
                    }
                }
            }

            return loginList;
        }
    }
}
