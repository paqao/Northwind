using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NorthwndExplorer
{
    public partial class EmployeeList : Form
    {
        public EmployeeList()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            NORTHWNDEntities1 ctx = new NORTHWNDEntities1();
            var employeeList = new List<Employee>();
            foreach(var Employee in ctx.Employees.ToList()){
                employeeList.Add(Employee);
            }
            listBox1.DataSource = employeeList;
            listBox1.SelectionMode = SelectionMode.One;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

    }
}
