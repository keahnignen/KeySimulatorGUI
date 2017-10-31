using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using KeySimulatorGUI.Controller;
using KeySimulatorGUI.Globals;

namespace KeySimulatorGUI.View
{
    public partial class PatternEdit : Form
    {

        private readonly PatternModel _patternModelOriginal;

        private KeySimulater g;
        private Thread t;

        private bool threadIsRuning = false;

        private readonly PatternModel _patternModel;

        public PatternEdit(PatternModel p)
        {
            InitializeComponent();
            RefreshbtnUse();
            _patternModel = p;
            if (_patternModel.Title == null)
                RenamePattern();
            RefreshName();
        }

        public PatternEdit() : this(new PatternModel())
        {

        }

        private void RefreshName()
        {
            lblPattername.Text = _patternModel.Title;
        }

        private void RenamePattern()
        {
            _patternModel.Title = NamerController.GetName();
        }

        private void btnChangeName_Click(object sender, EventArgs e)
        {
            RenamePattern();
            RefreshName();
        }

        private void lstKeys_SelectedIndexChanged(object sender, EventArgs e)
        {
            grpSelectedItem.Enabled = true;
        }

        private void RefreshListbox()
        {
            lstKeys.DataSource = _patternModel.Keys.ToList();
            lstKeys.DisplayMember = nameof(_patternModel.Title);
            lstKeys.ValueMember = nameof(_patternModel.Id);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            _patternModel.Keys.RemoveAt(lstKeys.SelectedIndex); 
        }

        private void RefreshbtnUse()
        {
            btnUse.Text = threadIsRuning ? "Stop" : "Use";

        }


        private void PressButton()
        {
            if (_patternModel.Keys == null) return;
            if (threadIsRuning)
            {
                g.IsTerminate = true;
                t.Join();
            }
            else
            {
                g = new KeySimulater(_patternModel.Keys.GetEnumerator());
                t = new Thread(g.PressKey);
                t.Start();
            }
        }

        private void btnUse_Click(object sender, EventArgs e)
        {
            PressButton();
            threadIsRuning = !threadIsRuning;
            RefreshbtnUse();
        }
    }
}
