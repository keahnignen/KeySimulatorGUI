using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using KeySimulatorGUI.Controller;
using KeySimulatorGUI.Models;

namespace KeySimulatorGUI.View
{
    public partial class MainEditor : Form
    {

        private List<object> ListboxList;
        private readonly List<OrderModel> ComboboxList;
        private readonly bool _itsAboutPatern;
        private bool _recordStarted = false;
        private readonly object _editObject;

        /// <summary>
        /// If u want to create something new
        /// </summary>
        public MainEditor(bool createNewPattern) : this(createNewPattern, null)
        {
        }

        /// <summary>
        /// Edit the parameter Pattern
        /// </summary>
        /// <param name="p">The Pattern iObjects</param>
        public MainEditor(PatternModel p) : this(true, p) 
        {
            _editObject = p;
        }

        /// <summary>
        ///  Edit the param Order
        /// </summary>
        /// <param name="p"></param>
        /// <param name="o"></param>
        public MainEditor(OrderModel o) : this(false, o)
        {
        }

        private MainEditor(bool itsAboutPattern, object obj)
        {
            _itsAboutPatern = itsAboutPattern;

            if (obj != null) _editObject = obj;
            else
            {
                if (_itsAboutPatern)
                {
                    _editObject = new PatternModel();
     
                }
                else
                {
                    _editObject = new OrderModel();
                }
            }

            InitializeComponent();
            grpPattern.Enabled = _itsAboutPatern;
            grpOrder.Enabled = !_itsAboutPatern;
            ListboxList = GetListboxElements<object>();
            PopulateListbox();
            if (!_itsAboutPatern) return;
            btnTest.Enabled = true;
            ComboboxList = GetComboboxElements();
            PopulateCombobox();
        }

        private const int WM_KEYDOWN = 0x0100;
        private const int WM_SYSKEYDOWN = 0x104;

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (((msg.Msg == WM_KEYDOWN) || (msg.Msg == WM_SYSKEYDOWN)) && ParseKeyData(keyData)) return true; //True stands for key is handeld
            return base.ProcessCmdKey(ref msg, keyData); //Returns the key if its not handeld
        }

        private void PopulateListbox()
        {
            List<ListboxItem> ListboxElements = ListboxList.Cast<ListboxItem>().ToList();
 
        
            lstLog.DataSource = ListboxElements;
            lstLog.DisplayMember = nameof(ListboxItem.Title);
            lstLog.ValueMember = nameof(ListboxItem.Id);

            string swag = "swaf";
            string[] ListOfObjectNames = { "Obj1", "Obj2" };
            Array.IndexOf(ListOfObjectNames, swag);
        }

        private void PopulateCombobox()
        {
            cmbOrder.DataSource = ComboboxList.Cast<ListboxItem>().ToList();
            cmbOrder.DisplayMember = nameof(ListboxItem.Title);
            cmbOrder.ValueMember = nameof(ListboxItem.Id);
        }

        private List<T> GetListboxElements<T>()
        {
            if (_itsAboutPatern)
            {
                PatternModel p = (PatternModel) _editObject;
                if (p?.Orders != null && p.Orders.Any()) return p.Orders.Cast<T>().ToList();
            }
            else
            {
                OrderModel o = (OrderModel)_editObject;
                if (o?.Keys !=  null && o.Keys.Any()) return o.Keys.Cast<T>().ToList();
            }

            return new List<T>();
        }
        
        private List<OrderModel> GetComboboxElements()
        {
            using (var db = new Context())
            {
                return db.Orders.ToList();
            }
        }

        private void ShowName(string name, string description)
        {
            txtName.Text = name;
        }

        private void chkName_CheckedChanged(object sender, EventArgs e)
        {
            RefreshGrpName();
        }

        private void RefreshGrpName()
        {
            grpName.Enabled = chkName.Checked;
        }

        private void MainEditor_Load(object sender, EventArgs e)
        {
            RefreshGrpName();;
        }

        private void btnNewOrder_Click(object sender, EventArgs e)
        {
            MainEditor me = new MainEditor(false);
            me.Show();
        }

        private void btnEditOrder_Click(object sender, EventArgs e)
        {
            MainEditor me = new MainEditor(ComboboxList.ElementAt(cmbOrder.SelectedIndex));
            me.Show();
        }

        private void lstLog_SelectedIndexChanged(object sender, EventArgs e)
        {
            grpOptionSelectedItem.Enabled = true;
        }

        private void btnEditSelectedItem_Click(object sender, EventArgs e)
        {
            Form form;
            if (_itsAboutPatern)
            {
                form = new MainEditor(GetListboxElement<OrderModel>());
            }
            else
            {
                form = new KeyEdit(GetListboxElement<KeyModel>());
            }
            form.Show();
        }

        private T GetListboxElement<T>()
        {
            return ListboxList.Cast<T>().ElementAt(lstLog.SelectedIndex);
        }

        private void cmbOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            grpSelectedOrderOptions.Enabled = true;
        }

        private void btnMoveUp_Click(object sender, EventArgs e)
        {
            MoveSelectedItem(true);
        }

        private void MoveSelectedItem(bool moveUpwards)
        {
            int index = lstLog.SelectedIndex;
            var element = ListboxList.ElementAt(lstLog.SelectedIndex);
            index = moveUpwards ? +1 : -1;
            ListboxList.Insert(index, element);
            ListboxList.Remove(element);
            PopulateListbox();
        }

        private void btnRecord_Click(object sender, EventArgs e)
        {
            _recordStarted = !_recordStarted;
            btnRecord.Text = (_recordStarted) ? "Pause record" : "Start record";
        }

        private void btnMoveDown_Click(object sender, EventArgs e)
        {
            MoveSelectedItem(false);
        }
   
        private bool ParseKeyData(Keys keyData)
        {
            if (!_recordStarted) return false;
            KeyModel km = new KeyModel();
            km.Keycode = keyData;
            keys.Add(km);
            UpdateLog();
            return true;
        }

        private List<KeyModel> keys = new List<KeyModel>();



        private void UpdateLog()
        {
            List<string> listOfKeys = new List<string>();
            foreach (var key in keys)
            {
                listOfKeys.Add(key.Keycode.ToString());
            }

            lstLog.DataSource = listOfKeys;
        }
    }
}
