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
    public partial class PatternEdit : Form
    {

        private readonly PatternModel _patternModel;

        public PatternEdit(PatternModel p)
        {
            InitializeComponent();
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

        private void btnRemove_Click(object sender, EventArgs e)
        {
            
        }
    }
}
