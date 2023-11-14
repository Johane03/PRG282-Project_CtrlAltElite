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
using System.Xml.Linq;
using Test.BusinessLogicLayer;
using Test.DataLayer;

namespace Test
{
    public partial class ModuleData : Form
    {
        DataHandler handler = new DataHandler();
        public ModuleData()
        {
            InitializeComponent();
        }

        private void btnBackModule_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModuleCreate_Click(object sender, EventArgs e)
        {
            ModuleAdded moduleAdded = new ModuleAdded();
            moduleAdded.Show();
            Course course = new Course(int.Parse(txtModuleCode.Text),txtModuleName.Text,rtxModuledesc.Text);
            handler.AddModule(course);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtModuleCode.Clear();
            txtModuleName.Clear();
            rtxModuledesc.Clear();
            rtxModuleLinks.Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
           handler.UpdateModulesData(int.Parse(txtModuleCode.Text), txtModuleName.Text, rtxModuledesc.Text);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            handler.DeleteModule(int.Parse(txtModuleCode.Text));
        }

        private void picBoxSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
