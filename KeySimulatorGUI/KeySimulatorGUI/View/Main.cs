using System;
using System.Windows.Forms;

namespace KeySimulatorGUI.View
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
            NameOfButtoNew = btnNew.Name;
        }

        public string NameOfButtoNew { get; private set; }

        public Button ResultButton { get; private set; }
        
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

        private void btn_Click(object sender, EventArgs e)
        {
            ResultButton = (Button) sender;
            this.Close();
        }


    }
}
