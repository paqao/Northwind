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
using NorthwndExplorer.ViewModels;

namespace NorthwndExplorer
{
    /// <summary>
    /// Interaction logic for AddShipperWindow.xaml
    /// </summary>
    public partial class AddShipperWindow : Window
    {
        public AddShipperWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string NameOfCompany = textbox1.Text;
            string PhoneNumber = textbox2.Text;

            Shipper shipper = new Shipper();
            var shipper1 = new ShipperViewModel(shipper);
            shipper1.CompanyName = NameOfCompany;
            shipper1.Phone = PhoneNumber;

            textbox1.Text = String.Empty;
            textbox2.Text = String.Empty;
            
            if(shipper1.CompanyName != null && shipper1.CompanyName != "" )
                return;

            MessageBox.Show("You added a shipper");

            NORTHWNDEntities1 entities = new NORTHWNDEntities1();

            entities.Shippers.Add(shipper);
        }
    }
}
