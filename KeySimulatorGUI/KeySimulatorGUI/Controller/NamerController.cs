using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using KeySimulatorGUI.Globals;
using KeySimulatorGUI.View;

namespace KeySimulatorGUI.Controller
{
    static class NamerController
    {
        public static string GetName()
        {
            Namer namer = new Namer();
            namer.ShowDialog();
            return namer.GetName();
        }
    }
}
