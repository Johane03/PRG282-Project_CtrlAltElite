using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Test.BusinessLogicLayer;
using Test.DataLayer;

namespace Test
{
    public partial class Register : Form
    {
        public delegate void EnableButtonsDelegate(object sender, EventArgs e);
        public event EnableButtonsDelegate EnableButtons;

        public Register()
        {
            InitializeComponent();
        }

        private void lblLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login1 login = new Login1();
            login.Show();
            this.Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            
            RegistrationComplete registrationComplete = new RegistrationComplete();
            EnableButtons?.Invoke(this, e);
            registrationComplete.Show();
            this.Close();
        }
    }
}
