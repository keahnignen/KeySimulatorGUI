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
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {

            string gitHubLink = "https://github.com/keahnignen/KeySimulatorGUI";

            string messageContent =
                "Theres nothing interesting." + "\n\n" +
                "But, there is the Github link to this Project: " + "\n" +
                gitHubLink + "\n\n\n" +
                "Unfortunately, WindowsMessageBoxes are not clickable, wonne get redirected?";

            string messsageTitle = "About";

            if (MessageBox.Show(messageContent, messsageTitle, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start(gitHubLink);
            }
        }
    }
}
