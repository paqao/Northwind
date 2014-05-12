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
    /// Interaction logic for OrderFullDetailsView.xaml
    /// </summary>
    public partial class OrderFullDetailsView : Window
    {
        private Order order;
        public OrderFullDetailsView(Order order)
        {
            InitializeComponent();
            this.order = order;
        }
    }
}
