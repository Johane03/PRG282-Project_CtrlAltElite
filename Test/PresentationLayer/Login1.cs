using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void lblRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register register = new Register();
            register.EnableButtons += btnLogin_Click;
            register.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            EnableButtons?.Invoke(this, e);
            this.Close();
        }



        private void btnLoginDetails_MouseHover(object sender, EventArgs e)
        {
        }

        private void Login1_Load(object sender, EventArgs e)
        {
            
        }

       
    }
}
