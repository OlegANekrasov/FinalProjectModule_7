using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectModule_7.DeliveryСlasses
{
    // доставка в пункт выдачи. Здесь будет храниться какая-то ещё логика,
    // необходимая для процесса доставки в пункт выдачи, например, хранение компании и точки выдачи,
    // а также какой-то ещё информации.
    class PickPointDelivery : Delivery
    {
        private DateTime finishDateDelivery;
        public DateTime FinishDateDelivery 
        { 
            get { return finishDateDelivery; } 
            set { finishDateDelivery = value; }
        }

        // В пункт выдачи товар будет доставлен через 7 дней после даты заказа
        public override DateTime DateDelivery
        {
            get { return dateDelivery; }
            set 
            { 
                if(value > DateTime.Now)
                    dateDelivery = value.AddDays(7); 
                else
                    dateDelivery = DateTime.Now.AddDays(7);
            }
        }

        public PickPointDelivery(string address, DateTime dateOrder)
        {
            DateDelivery = dateOrder;
            FinishDateDelivery = dateOrder.AddDays(21);
            Address = address;
        }
    }
}
