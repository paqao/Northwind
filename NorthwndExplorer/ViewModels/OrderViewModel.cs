using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwndExplorer.ViewModels
{
    class OrderViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private Order InnerObject;
        public OrderViewModel(Order innerObject)
        {
            this.InnerObject = innerObject;
        }

        public int OrderId
        {
            get
            {
                return InnerObject.OrderID;
            }
            private set
            {
                InnerObject.OrderID = value;
                NotifyPropertyChanged("OrderId");
            }
        }

        public DateTime OrderDate
        {
            get
            {
                return InnerObject.OrderDate.Value;
            }
            private set
            {
                InnerObject.OrderDate = value;
                NotifyPropertyChanged("OrderDate");
            }
        }

        public Decimal OverallBill
        {
            get
            {
                Decimal result = 0.0M;
                foreach (var product in InnerObject.Order_Details)
                {
                    result += product.UnitPrice * product.Quantity;
                }
                return result;
            }
        }

        private void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChangedEventArgs args = new PropertyChangedEventArgs(propertyName);
                PropertyChanged(this, args);
            }
        }
    }
}
