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
    public partial class StudentAdded : Form
    {
        public StudentAdded()
        {
            InitializeComponent();
        }

        private void tmr_Student_Tick(object sender, EventArgs e)
        {
            this.Close();
            tmr_Student.Stop();
        }

        private void StudentAdded_Load(object sender, EventArgs e)
        {
            tmr_Student.Start();
        }
    }
}
