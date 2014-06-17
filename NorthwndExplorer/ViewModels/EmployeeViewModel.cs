using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwndExplorer.ViewModels
{
    public class EmployeeViewModel
    {
        public int? ReportTo { get { return innerObject.ReportsTo; } set { innerObject.ReportsTo = value; } }

        public int EmployeeId { get{ return innerObject.EmployeeID ;}}

        public string Name { get { return innerObject.FirstName + " " + innerObject.LastName; } }

        private Employee innerObject;
        public EmployeeViewModel(Employee employee)
        {
            this.innerObject = employee;
        }
    }
}
