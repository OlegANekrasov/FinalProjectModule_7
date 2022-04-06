using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FinalProjectModule_7.DeliveryСlasses;
using FinalProjectModule_7.ProductClasses;

namespace FinalProjectModule_7.OrderСlasses
{
    class Order<TDelivery> where TDelivery : Delivery
    {
        internal TDelivery Delivery;
        private ProductCollection ProductCollection;
        private int Number;
        private string Description;
        public static int Count = 0;

        // Использование перегруженных операторов
        public static int operator +(Order<TDelivery> order, int num)
        {
            return Count + num;
        }

        public Order(TDelivery delivery, ProductCollection productCollection, int number, string description)
        {
            Delivery = delivery;
            ProductCollection = productCollection;      // Агрегация
            Number = number;
            Description = description;
        }

        public double Amount()
        {
            double amount = 0.0;
            for (int i = 0; i < ProductCollection.Length; ++i)
            {
                if (ProductCollection[i] is BaseProduct<string> productS)
                    amount += productS.Cost;

                if (ProductCollection[i] is BaseProduct<long> productL)
                    amount += productL.Cost;
            }
            return amount;
        }
        public void DisplayAddress() => Console.WriteLine(Delivery.Address);
        public static void DisplayCount() => Console.WriteLine($"Всего оформлено заказов : {Count}\n");
        public void DisplayTypeDelivery()
        {
            if (Delivery is HomeDelivery нomeDelivery)
            {
                if (нomeDelivery.DeliveryType == HomeDeliveryType.Courier)
                    Console.WriteLine("Доставка курьером");
                else
                    Console.WriteLine("Доставка курьерской компанией");
            }
            else if (Delivery is PickPointDelivery)
            {
                Console.WriteLine("Доставка в пункт выдачи");
            }
            else
            {
                Console.WriteLine("Доставка в розничный магазин");
            }
        }
        public void ShowOrder()
        {
            Console.WriteLine("Информация о заказе:");
            Console.WriteLine($"Номер: {Number}");
            Console.WriteLine($"Описание: {Description}");
            Console.WriteLine($"Стоимость: {Amount()}");
            Console.Write("Тип доставки: ");

            DisplayTypeDelivery();

            if (Delivery is PickPointDelivery pickPointDelivery)
            {
                Console.WriteLine($"Дата начала выдачи: {pickPointDelivery.DateDelivery}");
                Console.WriteLine($"Дата окончания выдачи: {pickPointDelivery.FinishDateDelivery}"); 
            }
            else
            {
                Console.WriteLine($"Дата доставки: {Delivery.DateDelivery}");
            }

            Console.WriteLine("Заказано товаров: \n");
            for (int i = 0; i < ProductCollection.Length; ++i)
            {
                if (ProductCollection[i] is BaseProduct<string> productS)
                    productS.ShowProduct();

                if (ProductCollection[i] is BaseProduct<long> productL)
                    productL.ShowProduct();
            }
        }

    }
}
