using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalProjectModule_7.DeliveryСlasses;

namespace FinalProjectModule_7.OrderСlasses
{
    class OrderCollection
    {
        private Object[] orders;
        private int length;
        public int Length
        {
            get => length;
            private set => length = value;
        }

        public OrderCollection(int length)
        {
            orders = new Object[length];        // Композиция
            Length = length;
        }

        // индексатор
        public Object this[int index]
        {
            get => orders[index];
            set => orders[index] = value;
        }

    }
}
