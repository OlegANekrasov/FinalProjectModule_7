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
        public PointIssueOrder PointIssueOrder;

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

        private DateTime FinishDateDelivery;

        public PickPointDelivery(DateTime dateOrder, PointIssueOrder pointIssueOrder)
        {
            DateDelivery = dateOrder;
            FinishDateDelivery = dateOrder.AddDays(21);
            PointIssueOrder = pointIssueOrder;
        }
    }

    struct PointIssueOrder
    {
        private string namePickupPoint;
        public string NamePickupPoint
        {
            get { return namePickupPoint; }
            set { namePickupPoint = value; }
        }

        private string address;
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
    }

}
