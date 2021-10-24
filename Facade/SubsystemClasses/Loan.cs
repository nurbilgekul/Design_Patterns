using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facade.SubsystemClasses
{
    class Loan
    {
        public bool HasNoBadLoans(Customer c)
        {
            MessageBox.Show("Check loans for " + c.Name);
            return true;
        }
    }
}
