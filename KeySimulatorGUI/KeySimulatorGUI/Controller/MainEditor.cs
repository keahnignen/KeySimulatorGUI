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
    class MainEditor<T> where T : new()
    {

        private readonly T _editObject;

        public MainEditor() : this(new T())
        {
            
        }

        public MainEditor(T obj)
        {
            _editObject = obj;
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
                PatternModel p = _editObject as PatternModel;
                if (p?.Orders != null && p.Orders.Any()) return p.Orders.Cast<T>().ToList();
            }
            else
            {
            
                OrderModel o = _editObject as OrderModel;
                if (o?.Keys != null && o.Keys.Any()) return o.Keys.Cast<T>().ToList();
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