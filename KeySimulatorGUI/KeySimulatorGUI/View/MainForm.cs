using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using KeySimulatorGUI.Controller;
using KeySimulatorGUI.Models;

namespace KeySimulatorGUI.View
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            //NameOfButtoNew = btnNew.Name;
        }
        public string NameOfButtoNew { get; private set; }
        public Button ResultButton { get; private set; }
        public List<PatternModel> ListOfPattern { get; set; }
        private void btn_Click(object sender, EventArgs e)
        {
            ResultButton = (Button) sender;
            this.Close();
        }
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string gitHubLink = "https://github.com/keahnignen/KeySimulatorGUI";

            string messageContent =
                "Theres nothing interesting." + "\n\n" +
                "But, there is the Github link to this Project: " + "\n" +
                gitHubLink + "\n\n\n" +
                "Unfortunately, WindowsMessageBoxes are not clickable, wanna get redirected?";

            string messsageTitle = "About";

            if (MessageBox.Show(messageContent, messsageTitle, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start(gitHubLink);
            }
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateNewPattern();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            ListOfPattern = new List<PatternModel>();
            RefreshDeleteOptions();
            ShowAllPatterns();
        }
        private void ShowAllPatterns()
        {
       
            using (var db = new PatternContext())
            {
                StringBuilder sb = new StringBuilder();
                foreach (var pattern in db.Patterns)
                {
                    ListOfPattern.Add(pattern);
                    sb.Append(pattern.Title);
                }
                lstPatternSelector.Text = sb.ToString();
            }
        }
        private void chkEnableDelete_CheckedChanged(object sender, EventArgs e)
        {
            RefreshDeleteOptions();
        }
        private void RefreshDeleteOptions()
        {
            grpDelete.Enabled = chkEnableDelete.Checked;
            btnDelete.Enabled = chkEnableDelete.Checked;
            btnDeletePatterns.Enabled = chkEnableSuperDelete.Checked;
            btnDeleteAll.Enabled = chkEnableSuperDelete.Checked;
        }
        private void lstPatternSelector_SelectedValueChanged(object sender, EventArgs e)
        {
            ListBox lb = (ListBox) sender;
            grpPatternOption.Enabled = true;
            ShowPatternProperties(GetSelectedPattern());
        }
        private void ShowPatternProperties(PatternModel pm)
        {
            StringBuilder sb = new StringBuilder();
            foreach (PropertyInfo prop in typeof(PatternModel).GetProperties())
            {
                sb.Append(prop.Name + ": " + prop.GetValue(pm, null) + Environment.NewLine);
            }
            rtxPatternProperties.Text = sb.ToString();
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            CreateNewPattern();
        }
        private void CreateNewPattern()
        {
            MainEditor me = new MainEditor();
            me.Show();
        }
        private void btnDeletePattern_Click(object sender, EventArgs e)
        {
            string msg = "Are you sure to delete all Patterns? \n" +
                         "There is no undo! \n";
            if (MessageBox.Show(msg, "Delete Pattern", MessageBoxButtons.OKCancel) == DialogResult.Cancel) return;
            if (!YouAreSure()) return;
            using (var db = new PatternContext())
            {
                db.Database.Delete();
            }
        }

        private bool YouAreSure()
        {
            return (MessageBox.Show("Are you really sure?", "Last Attempt", MessageBoxButtons.OKCancel) == DialogResult.OK);
        }

        private void chkEnableToDelteAll_CheckedChanged(object sender, EventArgs e)
        {
            RefreshDeleteOptions();
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {/* 

            FIX THAT

            string msg = "Are you sure to delete ALL? \n" +
                 "There is no undo! \n";
            if (MessageBox.Show(msg, "Delete All", MessageBoxButtons.OKCancel) == DialogResult.Cancel) return;
            if (!YouAreSure()) return;
            using (var db = new DbContext())
            {
                Database.Delete();
            }
            */
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            MainEditor me = new MainEditor(GetSelectedPattern());
            me.Show();
        }

        private PatternModel GetSelectedPattern()
        {
            return ListOfPattern.ElementAt(lstPatternSelector.SelectedIndex + 1);
        }

    }
}
