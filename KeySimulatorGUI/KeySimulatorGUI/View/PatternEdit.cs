using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using WindowsInput.Native;
using KeySimulatorGUI.Controller;
using KeySimulatorGUI.Globals;
using KeySimulatorGUI.Models;

namespace KeySimulatorGUI.View
{
    public partial class PatternEdit : Form
    {
        private static readonly int WM_SYSKEYDOWN = 0x0104;
        private static readonly int WM_KEYDOWN = 0x0100;

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if ((msg.Msg == WM_KEYDOWN) || (msg.Msg == WM_SYSKEYDOWN))
            {
                if (!recordKeyInput) return base.ProcessCmdKey(ref msg, keyData);
                SaveKey(keyData);
            }
            return true;
        }

        private readonly PatternModel _patternModelOriginal;

        private KeySimulater g;
        private Thread t;

        private bool threadIsRuning = false;
        private bool recordKeyInput = false;

        private readonly PatternModel _patternModel;




        public PatternEdit(PatternModel p)
        {
            InitializeComponent();
            RefreshbtnUse();
            _patternModel = p;
            if (_patternModel.Title == null)
                RenamePattern();
            RefreshName();
            btnRecord_Rename();
        }

        public PatternEdit() : this(new PatternModel())
        { 
        }

        private Dictionary<string, List<Keys>> kkkk = new Dictionary<string, List<Keys>>();
        private List<Keys> tempList = new List<Keys>();
        private int Devider = 100;
        private Stopwatch sp = new Stopwatch();

        private void SaveKey(Keys k)
        {
                
        }

        private void SaveKeyStroke(IEnumerable<VirtualKeyCode> k, IEnumerable<VirtualKeyCode> i)
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
                g = new KeySimulater(_patternModel);
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

        private void btnRecord_Click(object sender, EventArgs e)
        {
            recordKeyInput = !recordKeyInput;
            btnRecord_Rename();
            sp.Start();

        }

        private void btnRecord_Rename()
        {
            btnRecord.Text = (recordKeyInput) ? "Stop" : "Record";
        }
    }
}
