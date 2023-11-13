using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Test.DataLayer;
using Test.BusinessLogicLayer; //Imported layer to use 'Login' class
using System.IO;

namespace Test
{
    public partial class Login1 : Form
    {
        public delegate void EnableButtonsDelegate(object sender, EventArgs e);
        public event EnableButtonsDelegate EnableButtons;

        public Login1()
        {
            InitializeComponent();
        }

        //Create FileHandler Object
        FileHandler fh = new FileHandler();

        private void lblRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register register = new Register();
            register.EnableButtons += btnLogin_Click;
            register.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool found = false;
            string username = txtUsernameLogin.Text;
            string password = txtPasswordLogin.Text;

            List<Login> loginList = fh.GetLogins();

            //Check if Username & Password exists in textfile
            foreach (Login login in loginList)
            {
                if (login.Username == username && login.Password == password)
                {
                    found = true;
                    EnableButtons?.Invoke(this, e);
                    this.Close();
                }
            }

            if (!found)
            {
                MessageBox.Show("Could not log in. \nPlease try again or Register.");
            }
            else
            {
                MessageBox.Show("Login successful!");
                //Hides Login Form & Displays Navigation Form when user is verified
                Navigation navigation = new Navigation();
                navigation.Show();
                this.Hide();
            }
        }



        private void btnLoginDetails_MouseHover(object sender, EventArgs e)
        {
        }

        private void Login1_Load(object sender, EventArgs e)
        {
            //Invoke CreateFile Method from FileHandler class
            fh.CreateFile();
        }
    }
}
