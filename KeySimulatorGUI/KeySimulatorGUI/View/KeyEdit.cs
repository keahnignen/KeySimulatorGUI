using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KeySimulatorGUI.Models;

namespace KeySimulatorGUI.View
{
    public partial class KeyEdit : Form
    {
        private readonly KeyModel _keyModel;

        public KeyEdit(KeyModel km)
        {
            InitializeComponent();
            if (km.KeyCodeNormal != null && km.KeycodeModifier != null) 
                _keyModel = km;
        }

        private void btnChangeKey_Click(object sender, EventArgs e)
        {
        }
    }
}
