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
    public partial class Navigation : Form
    {


        public Navigation()
        {
            InitializeComponent();
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {

        }

        private void btnNavStudents_Click(object sender, EventArgs e)
        {
            StudentData studentData = new StudentData();
            studentData.Show();
        }

        private void btnNavModules_Click(object sender, EventArgs e)
        {
            ModuleData moduleData = new ModuleData();
            moduleData.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
          Environment.Exit(0);
        }

        private void Navigation_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void Navigation_Load(object sender, EventArgs e)
        {
            Login1 login1 = new Login1();
            login1.EnableButtons += EnableButtonsHandler;
            login1.Show();
            
        }


        public void EnableButtonsHandler(object sender, EventArgs e)
        {
            btnNavStudents.Enabled = true;
            btnNavModules.Enabled = true;
        }
    }
}
