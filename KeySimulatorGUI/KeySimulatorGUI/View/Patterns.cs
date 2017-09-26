using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeySimulatorGUI
{
    public partial class Patterns : Form
    {

        public Patterns()
        {
            InitializeComponent();
        }

        private DataGridView dgv;


        private void Patterns_Load(object sender, EventArgs e)
        {
            SetDataGridView(sender);
            foreach (var VARIABLE in COLLECTION)
            {
                
            }
        }

        private void SetDataGridView(object s)
        {
            Form form = (Form)s;
            dgv = form.Controls.OfType<DataGridView>().First();
        }
    }
}
