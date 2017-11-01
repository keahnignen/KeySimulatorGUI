using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsInput;
using WindowsInput.Native;
using KeySimulatorGUI.Controller;
using KeySimulatorGUI.Models;

namespace KeySimulatorGUI.Globals
{
    public class KeySimulater
    {

        private readonly PatternModel keys;

        public KeySimulater(PatternModel p)
        {
            keys = p;
        }

        private readonly InputSimulator _inputSimulatorField = new InputSimulator();

        public volatile bool IsTerminate;

        private void PressKey(VirtualKeyCode vkc)
        {
            _inputSimulatorField.Keyboard.KeyDown(vkc);
        }

        public void PressKey()
        {
            IsTerminate = false;
            while (!IsTerminate)
            {
                if (keys.Current?.KeyCodeNormal == null) continue;
                if (keys.Current?.KeycodeModifier != null)
                {
                    _inputSimulatorField.Keyboard.ModifiedKeyStroke(keys.Current.KeycodeModifier, keys.Current.KeyCodeNormal);
                }
                else
                {
                    _inputSimulatorField.Keyboard.KeyDown((VirtualKeyCode)keys.Current.KeyCodeNormal.First());
                }
            }
        }
    }
}
