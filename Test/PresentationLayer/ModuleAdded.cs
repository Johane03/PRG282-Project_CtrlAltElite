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
    public partial class ModuleAdded : Form
    {
        public ModuleAdded()
        {
            InitializeComponent();
        }

        private void tmr_Module_Tick(object sender, EventArgs e)
        {
            this.Close();
            tmr_Module.Stop();
        }

        private void ModuleAdded_Load(object sender, EventArgs e)
        {
            tmr_Module.Start();
        }
    }
}
