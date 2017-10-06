using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KeySimulatorGUI.Models;
using KeySimulatorGUI.View;

namespace KeySimulatorGUI.Controller
{
    class MainEditor
    {

        private readonly dynamic _editObject;

        public MainEditor(bool itsAboutAPattern) : this(null, itsAboutAPattern)
        {
            
        }

        public MainEditor(object obj, bool itsAboutPattern)
        {

            if (obj != null)
                _editObject = obj;
            else
            {
                _editObject = (itsAboutPattern) ? new PatternModel() : new OrderModel();

                if (itsAboutPattern)
                {
                    _editObject = new PatternModel();
                }
                else
                {
                    _editObject = new OrderModel();
                }
            }

        }

        //private List<object> ListboxList; //Probaly Useless
        private readonly List<OrderModel> ComboboxList;
        private readonly bool _itsAboutPatern;
        private bool _recordStarted = false;


        private const int WM_KEYDOWN = 0x0100;
        private const int WM_SYSKEYDOWN = 0x104;


        public List<T> GetListboxElements<T>()
        {
            if (_itsAboutPatern)
            {
                if (_editObject?.Orders?.Any()) return _editObject?.Orders.Cast<T>().ToList();
            }
            else
            {
           
                if (_editObject?.Keys?.Any()) return _editObject?.Keys?.Cast<T>().ToList();
            }

            return new List<T>();
        }

        public List<OrderModel> GetComboboxElements()
        {
            using (var db = new Context())
            {
                return db.Orders.ToList();
            }
        }

        private List<KeyModel> keys = new List<KeyModel>();

        private void SyncListboxMembers()
        {

        }
    }
}