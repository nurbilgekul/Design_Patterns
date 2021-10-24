using Adapter.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Client
    {
        static void Main(string[] args)
        {
            string[,] employeesArray = new string[4, 3]
            {
                {"1","Nur","10000"},
                {"2","Bilge","20000"},
                {"3","Kadir","30000"},
                {"4","Burak","40000"},

            };

            ITarget target = new EmployeeAdapter();
            target.ProcessCompanySalary(employeesArray);

        }
    }
}
