using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeySimulatorGUI.Models
{
    public class KeyModel : iObject
    {
        public int Id { get; set; }
        public int Keycode { get; set; }
        public int Presstime { get; set; }
        public int Delay { get; set; }
        public string Title { get; set; }
    }
}
