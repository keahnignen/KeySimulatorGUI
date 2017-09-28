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
    public partial class OrderEditor : Form
    {
        /// <summary>
        /// Generate a new Order
        /// </summary>
        public OrderEditor()
        {
            
        }

        /// <summary>
        ///     Edit the parameter Pattern
        /// </summary>
        /// <param name="p">The Pattern p</param>
        public OrderEditor(PatternModel p)
        {
            InitializeComponent();
        }


        /// <summary>
        /// Edit the parameter Order
        /// </summary>
        /// <param name="o">The Order u want to edit</param>
        public OrderEditor(OrderModel o)
        {
            InitializeComponent();
        }
    }
}
