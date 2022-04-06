using System;

using FinalProjectModule_7.DeliveryСlasses;
using FinalProjectModule_7.ProductClasses;
using FinalProjectModule_7.OrderСlasses;
using FinalProjectModule_7.ExtensionClasses;

namespace FinalProjectModule_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Product<string> product_1 = new Product<string>("Куртка", "AA123123", 1, 5000.00);
            DiscountProduct<long> product_2 = new DiscountProduct<long>("Спортивный костюм", 567893, 1, 12000.00, 50);

            Object[] products = new Object[] { product_1, product_2 };
            ProductCollection productCollection = new ProductCollection(products);
            Console.WriteLine("Выброно товаров: \n");
            for (int i = 0; i < productCollection.Length; ++i)
            {
                if (productCollection[i] is BaseProduct<string> productS)
                    productS.ShowProduct();

                if (productCollection[i] is BaseProduct<long> productL)
                    productL.ShowProduct();
            }

            HomeDelivery homeDelivery = new HomeDelivery(HomeDeliveryType.Courier, "Москва, Ленинский пр-т, д. 25, кв. 10", DateTime.Now);
            Order<HomeDelivery> order = new Order<HomeDelivery>(homeDelivery, productCollection, 1, "...");
            order.ShowOrder();

            Order<HomeDelivery>.Count = order + 1;
            Order<HomeDelivery>.DisplayCount();

            Console.WriteLine($"Число дней до доставки: {order?.Delivery?.DateDelivery.NumberDaysBeforeDelivery()}\n"); 

            /*
            PointIssueOrder[] PickUpPoints = new PointIssueOrder[] { new PointIssueOrder { NamePickupPoint = "Путкт выдачи № 1", Address = "Адрес 1" },
                                                                     new PointIssueOrder { NamePickupPoint = "Путкт выдачи № 2", Address = "Адрес 2" },
                                                                     new PointIssueOrder { NamePickupPoint = "Путкт выдачи № 3", Address = "Адрес 3" },};
            */


            Console.ReadLine();
        }
    }
}
