using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwndExplorer.ViewModels
{
    class ShipperViewModel
	{
        private Shipper InnerObject;

        public ShipperViewModel(Shipper innerObject)
        {
            this.InnerObject = innerObject;
        }

        public int ShipperId
        {
            get
            {
                return InnerObject.ShipperID;
            }
            private set
            {
                InnerObject.ShipperID = value;

            }
        }

        public string CompanyName
        {
            get
            {
                return InnerObject.CompanyName;
            }
            set
            {
                InnerObject.CompanyName = value;

            }
        }

        public string Phone
        {
            get
            {
                return InnerObject.Phone;
            }
            set
            {
                InnerObject.Phone = value;

            }
        }
	}

}

