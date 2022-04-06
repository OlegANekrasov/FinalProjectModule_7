using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectModule_7.DeliveryСlasses
{
    // доставка на дом. Этот тип будет подразумевать наличие курьера или передачу курьерской компании,
    // в нем будет располагаться своя, отдельная от прочих типов доставки логика
    class HomeDelivery : Delivery
    {
        public HomeDeliveryType DeliveryType = HomeDeliveryType.Courier;

        // В пункт выдачи товар будет доставлен курьером через 3 дня
        // курьерской компанией через 4 дня после даты заказа
        public override DateTime DateDelivery
        {
            get { return dateDelivery; }
            set
            {
                DateTime dateTimeNow = DateTime.Now;
                if (value > dateTimeNow)
                {
                    if (DeliveryType == HomeDeliveryType.Courier)
                        dateDelivery = value.AddDays(3);
                    else
                        dateDelivery = value.AddDays(4);
                }
                else
                {
                    if (DeliveryType == HomeDeliveryType.Courier)
                        dateDelivery = dateTimeNow.AddDays(3);
                    else
                        dateDelivery = dateTimeNow.AddDays(4);
                }
            }
        }
        public HomeDelivery(HomeDeliveryType deliveryType, string address, DateTime dateDelivery)
        {
            DeliveryType = deliveryType;
            Address = address;
            DateDelivery = dateDelivery;
        }
    }

    enum HomeDeliveryType
    {
        Courier,
        CourierCompany
    }
}
