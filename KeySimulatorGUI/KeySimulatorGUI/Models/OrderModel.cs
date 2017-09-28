using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KeySimulatorGUI.Models;

namespace KeySimulatorGUI.Controller
{
    public class OrderModel
    {
        public int Id { get; set; }
        public int EndDelay { get; set; }
        public string Title { get; set; }
        public List<KeyModel> Keys { get; set; }
    }
}
