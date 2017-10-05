using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeySimulatorGUI.View
{
    public partial class UtilityWindow : Form
    {
        public object Anwser { get; private set; }

        public const int GetPressKey = 1;

        private readonly int TaskId;

        private readonly string[] TaskStrings = {"Press a Button", "Swag"};

        public UtilityWindow(int i)
        {
            TaskId = i;
            RenameForm();
            InitializeComponent();
        }

        private void RenameForm()
        {
            this.Text = TaskStrings[TaskId - 1];
            lblTask.Text = TaskStrings[TaskId - 1];
        }

        private void UtilityWindow_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (TaskId != GetPressKey) return;
            throw  new Exception();
        }
    }
}
