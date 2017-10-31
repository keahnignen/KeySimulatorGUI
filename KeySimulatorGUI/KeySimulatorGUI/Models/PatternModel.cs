using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KeySimulatorGUI.Models;

namespace KeySimulatorGUI.Controller
{
    public class PatternModel 
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int InitalDelay { get; set; }
        public List<KeyModel> Keys { get; set; }
    }
}