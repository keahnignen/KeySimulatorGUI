using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KeySimulatorGUI.Controller;

namespace KeySimulatorGUI.View
{
    public partial class PatternEditor : Form
    {
        public PatternEditor()
        {
            InitializeComponent();
        }

        public PatternEditor(PatternModel p)
        {
            InitializeComponent();
        }
    }
}
