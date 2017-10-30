using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using KeySimulatorGUI.View;

namespace KeySimulatorGUI.Controller
{
    class MainController
    {

       
        public MainController()
        {
            MainForm mainForm = new MainForm();
            Application.Run(mainForm);
            if (mainForm.ResultButton == null) return;
        }
        
    }
}
