using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwndExplorer.ViewModels
{
    public class ProductViewModel : INotifyPropertyChanged
    {
        public ProductViewModel(Product pr)
        {
            this.innerObject = pr;
        }

        private void RaisePropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
        public event PropertyChangedEventHandler PropertyChanged;

        private Product innerObject;
        public Product InnerObject
        {
            get
            {
                return innerObject;
            }
            set
            {
                innerObject = value;
            }
        }
        public string Name
        {
            get
            {
                return innerObject.ProductName;
            }
            set
            {
                innerObject.ProductName = value;
                RaisePropertyChanged("Name");
            }
        }

        public short? Quantity
        {
            get
            {
                return innerObject.UnitsInStock;
            }
            set
            {
                innerObject.UnitsInStock = value;
                RaisePropertyChanged("Quantity");
            }
        }
    }
}
