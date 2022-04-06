using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectModule_7.DeliveryСlasses
{
    abstract class Delivery
    {
        public string Address;
        internal DateTime dateDelivery;
        public abstract DateTime DateDelivery
        {
            get;
            set;
        }
    }
}
