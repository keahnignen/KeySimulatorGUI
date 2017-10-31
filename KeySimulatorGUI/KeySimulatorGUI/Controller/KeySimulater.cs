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

        private readonly List<KeyModel>.Enumerator keys;

        public KeySimulater(List<KeyModel>.Enumerator lkme)
        {
            keys = lkme;
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
                if (keys.Current?.Keycode != null) PressKey((VirtualKeyCode) keys.Current.Keycode);
            }

        }
    }
}
