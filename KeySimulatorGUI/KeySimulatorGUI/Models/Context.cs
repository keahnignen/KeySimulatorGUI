using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KeySimulatorGUI.Controller;

namespace KeySimulatorGUI.Models
{
    class Context : DbContext
    {
        public DbSet<PatternModel> Patterns { get; set; }

        public DbSet<OrderModel> Orders { get; set; }
    }
}
