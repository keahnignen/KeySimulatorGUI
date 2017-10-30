using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeySimulatorGUI.Models
{
    public class KeyModel
    {
        public int id { get; set; }
        public Keys? Keycode { get; set; }
        public int Presstime { get; set; }
        public int Delay { get; set; }
    }
}
