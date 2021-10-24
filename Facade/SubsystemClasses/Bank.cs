using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facade.SubsystemClasses
{
    class Bank
    {
        public bool HasSufficientSavings(Customer c, int amount)
        {
            MessageBox.Show("Check bank for " + c.Name);
            return true;
        }
    }
}
