using Adapter.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class EmployeeAdapter:BillingSystem, ITarget
    {

        public void ProcessCompanySalary(string[,] employeesArray)
        {
            string Id = null;
            string Name = null;
            string Salary = null;
            List<Employee> listEmployee = new List<Employee>();

            foreach (var item in listEmployee)
            {
                listEmployee.Add(new Employee(Convert.ToInt32(Id), Name, Convert.ToDecimal(Salary)));
            }
          
            ProcessSalary(listEmployee);
        }    
    }
}

