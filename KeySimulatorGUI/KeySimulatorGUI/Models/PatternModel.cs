using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeySimulatorGUI.Controller
{
    public class PatternModel
    {
        public int Id { get; set; }
        public int InitalDelay { get; set; }
        public int AdditonalBetweenDelay { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public List<OrderModel> Orders { get; set; }
    }
}
