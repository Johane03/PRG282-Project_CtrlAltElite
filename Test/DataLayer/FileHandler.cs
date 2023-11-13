using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Test.BusinessLogicLayer; //Imported layer to use 'Login' class
using System.Windows.Forms;

namespace Test.DataLayer
{
    internal class FileHandler
    {
        string filePath = @"C:\\Users\\lieli\\OneDrive - belgiumcampus.ac.za\\_Belgium Campus\\Second Year (2023)\\PRG282\\_Project\\Milestone2/LoginData.txt";

        public void CreateFile()
        {
            //Create Textfile
            try
            {
                File.Create(filePath);

                if (File.Exists(filePath))
                {
                    using (StreamWriter writer = new StreamWriter(filePath))
                    {
                        writer.WriteLine("janitaDeVries, J@N!t@_2003");
                        writer.WriteLine("johaneBadenhorst, jOh@n^2003");
                        writer.WriteLine("walterNienaber, w*!t#R=2003");
                        writer.WriteLine("zeldeneVanVuren, $eL[)eNe<2003");
                    }
                    MessageBox.Show("Written to Textfile successful");
                    Console.ReadLine();
                }
                else
                {
                    MessageBox.Show("Textfile does not exist");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Textfile does not exist");
            }
            Console.ReadLine();
        }

        //Create a list of Login class to compare textfile with verified login info with entered Username & Password on Login Form
        public List<Login> GetLogins()
        {
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
