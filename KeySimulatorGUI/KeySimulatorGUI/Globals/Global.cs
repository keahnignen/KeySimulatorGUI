using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsInput;
using WindowsInput.Native;

namespace KeySimulatorGUI.Globals
{
    public static class Global
    {
        private static readonly InputSimulator InputSimulatorField = new InputSimulator();

        public static void PressKey(VirtualKeyCode vkc)
        {
            InputSimulatorField.Keyboard.KeyDown(vkc);
        }

    }
}
