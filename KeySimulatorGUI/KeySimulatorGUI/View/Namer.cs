using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KeySimulatorGUI.Controller;
using KeySimulatorGUI.Globals;

namespace KeySimulatorGUI.View
{
    public partial class Namer : Form
    {
        public Namer()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public string GetName()
        {
            return tbxName.Text;
        }
    }
}
