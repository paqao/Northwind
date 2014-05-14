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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NorthwndExplorer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        NORTHWNDEntities1 ctx = new NORTHWNDEntities1();
        /*public MainWindow()
        {
            InitializeComponent();
            var orderList = new List<OrderViewModel>();
            foreach (var Order in ctx.Orders.ToList())
            {
                orderList.Add(new OrderViewModel(Order));
            }
            this.Orders.ItemsSource = orderList;
        }*/

        private void ConnectButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ShipperButton_Click(object sender, RoutedEventArgs e)
        {
            new AddShipperWindow().Show();     
        }

        private void EmployeeButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
