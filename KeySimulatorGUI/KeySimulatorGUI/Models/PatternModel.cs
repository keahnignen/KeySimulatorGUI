using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsInput.Native;
using KeySimulatorGUI.Models;

namespace KeySimulatorGUI.Controller
{
    public class PatternModel 
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int InitalDelay { get; set; }
        public Dictionary<string, IEnumerable<VirtualKeyCode>[]>  Keys { get; set; }
    }
}