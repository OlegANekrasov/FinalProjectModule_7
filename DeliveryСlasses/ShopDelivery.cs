using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectModule_7.DeliveryСlasses
{
    // доставка в розничный магазин. Эта доставка может выполняться внутренними средствами компании
    // и совсем не требует работы с «внешними&raquo; элементами.
    class ShopDelivery : Delivery
    {
        // В розничный магазин товар будет доставлен через 5 дней после даты заказа
        public override DateTime DateDelivery
        {
            get { return dateDelivery; }
            set
            {
                if (value > DateTime.Now)
                    dateDelivery = value.AddDays(5);
                else
                    dateDelivery = DateTime.Now.AddDays(5);
            }
        }

        public ShopDelivery(string address, DateTime dateOrder)
        {
            DateDelivery = dateOrder;
            Address = address;
        }
    }
}
