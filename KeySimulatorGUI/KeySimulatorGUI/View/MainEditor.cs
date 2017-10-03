using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
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
        private readonly object _editObject;

        /// <summary>
        /// If u want to create something new
        /// </summary>
        public MainEditor(bool createNewPattern) : this()
        {
            _itsAboutPatern = createNewPattern;
            chkName.Enabled = true;
        
            if (createNewPattern)
            {
                _editObject = new OrderModel();
            }
            else
            {
                _editObject = new PatternModel();
            }
        }

        /// <summary>
        /// Edit the parameter Pattern
        /// </summary>
        /// <param name="p">The Pattern iObjects</param>
        public MainEditor(PatternModel p) : this()
        {
            _itsAboutPatern = true;
            _editObject = p;
        }

        /// <summary>
        ///  Edit the param Order
        /// </summary>
        /// <param name="p"></param>
        /// <param name="o"></param>
        public MainEditor(OrderModel o) : this()
        {
            _itsAboutPatern = false;
            ShowName(o.Title, "Orders does not have Descriptions.");
            _editObject = o;
        }

        private MainEditor()
        {
            InitializeComponent();
            grpPattern.Enabled = _itsAboutPatern;
            grpOrder.Enabled = !_itsAboutPatern;
            ListboxList = GetListboxElements();
            PopulateListbox();
            if (!_itsAboutPatern) return;
            ComboboxList = GetComboboxElements();
            PopulateCombobox();
        }

        private void PopulateListbox()
        {
            lstLog.DataSource = ListboxList.Cast<iObject>().ToList();
            lstLog.DisplayMember = nameof(iObject.Title);
            lstLog.ValueMember = nameof(iObject.Id);
        }

        private void PopulateCombobox()
        {
            cmbOrder.DataSource = ComboboxList.Cast<iObject>().ToList();
            cmbOrder.DisplayMember = nameof(iObject.Title);
            cmbOrder.ValueMember = nameof(iObject.Id);
        }

        private List<object> GetListboxElements()
        {
            if (_itsAboutPatern)
            {
                PatternModel p = (PatternModel) _editObject;
                return p.Orders.Cast<object>().ToList();
            }
            else
            {
                OrderModel o = (OrderModel)_editObject;
                return o.Keys.Cast<object>().ToList();
            }
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
            if (_itsAboutPatern)
            {
                MainEditor me = new MainEditor(ListboxList.Cast<OrderModel>().ElementAt(lstLog.SelectedIndex));
                me.Show();
            }
            else
            {
                me = new MainEditor();
                  
            }

        }

        private Type GetTypeOfListboxElements()
        {
            return _itsAboutPatern ? typeof(PatternModel) : typeof(OrderModel);
        }

        private void cmbOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            grpSelectedOrderOptions.Enabled = true;
        }

        private void btnMoveUp_Click(object sender, EventArgs e)
        {
            MoveSelectedItem(true);
        }

        private void MoveSelectedItem(bool b)
        {
            int index = lstLog.SelectedIndex;
            var element = ListboxList.ElementAt(lstLog.SelectedIndex);
            index = b ? +1 : -1;
            ListboxList.Insert(index, element);
            ListboxList.Remove(element);
            PopulateListbox();
        }
    }
}
