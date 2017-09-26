using System;
using System.Linq;
using System.Windows.Forms;

namespace KeySimulatorGUI.View
{
    public partial class Patterns : Form
    {

        public Patterns()
        {
            InitializeComponent();
            ItsTimeToStop = false;
        }

        private void WaitUntilSomethingHappens()
        {
            while (!ItsTimeToStop)
            {
                Console.WriteLine("");
            }
        }

        private bool ItsTimeToStop { get; set; }

        public void StartShow()
        {
            this.Show();
            WaitUntilSomethingHappens();
        }

        private DataGridView dgv;

        private void Patterns_Load(object sender, EventArgs e)
        {
            SetDataGridView(sender);
            /*
            foreach (var VARIABLE in COLLECTION)
            {
                
            }
            */
        }

        private void SetDataGridView(object s)
        {
            Form form = (Form)s;
            dgv = form.Controls.OfType<DataGridView>().First();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            ItsTimeToStop = true;
            this.Close();
        }
    }
}
