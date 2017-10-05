using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KeySimulatorGUI.Models;

namespace KeySimulatorGUI.Controller
{
    public class OrderModel : ListboxItem
    {
        public int EndDelay { get; set; }
        public List<KeyModel> Keys { get; set; }
    }
}
