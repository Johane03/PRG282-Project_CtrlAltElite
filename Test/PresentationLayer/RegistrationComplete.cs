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

namespace Test
{
    public partial class RegistrationComplete : Form
    {
 

        public RegistrationComplete()
        {
            InitializeComponent();
        }

        private void RegistrationComplete_Load(object sender, EventArgs e)
        {
            tmrRegister.Start();
        }

        private void tmrRegister_Tick(object sender, EventArgs e)
        {
            this.Close();
            tmrRegister.Stop();
        }
    }




}
