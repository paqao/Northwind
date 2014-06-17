using NorthwndExplorer.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace NorthwndExplorer
{
    /// <summary>
    /// Interaction logic for EmployeeList.xaml
    /// </summary>
    public partial class EmployeeList : Window
    {
        NORTHWNDEntities1 ctx;
        List<EmployeeViewModel> employees;
        public EmployeeList()
        {
            InitializeComponent();
            ctx = new NORTHWNDEntities1();
            var kol2 = ctx.Employees;
            employees = new List<EmployeeViewModel>();
            foreach(Employee emp in ctx.Employees){
                employees.Add(new EmployeeViewModel( emp));
            }
          
           
            this.Collection.ItemsSource = employees;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            EmployeeViewModel emp = Collection.SelectedItem as EmployeeViewModel;
            
            foreach(var employee in employees)
            {
                if (employee.EmployeeId != emp.EmployeeId && employee.ReportTo == emp.ReportTo)
                    employee.ReportTo = emp.EmployeeId;
            }
            ctx.SaveChanges();
        }
    }
}
