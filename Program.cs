using System;

using FinalProjectModule_7.DeliveryСlasses;
using FinalProjectModule_7.ProductClasses;
using FinalProjectModule_7.OrderСlasses;
using FinalProjectModule_7.ExtensionClasses;

namespace FinalProjectModule_7
{
    class Program
    {
        public static void ShowCode<TCode>(TCode code) => Console.WriteLine($"Код товара: {code}");

        static void Main(string[] args)
        {
            // Создаем товар
            Product<string> product_1 = new Product<string>("Куртка", "AA123123", 1, 5000.00);
            DiscountProduct<long> product_2 = new DiscountProduct<long>("Спортивный костюм", 567893, 1, 12000.00, 50);
            // Создем массив товаров
            Object[] products_1 = new Object[] { product_1, product_2 };
            ProductCollection productCollection_1 = new ProductCollection(products_1);
            Console.WriteLine("Выброно товаров: \n");
            for (int i = 0; i < productCollection_1.Length; ++i)
            {
                if (productCollection_1[i] is BaseProduct<string> productS)
                    ShowCode(productS.GetCode);

                if (productCollection_1[i] is BaseProduct<long> productL)
                    ShowCode(productL.GetCode);
            }
            // Создаем заказ "Доставка на дом"
            Console.WriteLine("\nЗакзы (Доставка на дом)...\n");
            HomeDelivery homeDelivery = new HomeDelivery(HomeDeliveryType.Courier, "Москва, Ленинский пр-т, д. 25, кв. 10", DateTime.Now);
            Order<HomeDelivery> order_1 = new Order<HomeDelivery>(homeDelivery, productCollection_1, 1, "...");
            order_1.ShowOrder();

            ++Order<HomeDelivery>.Count;
            Order<HomeDelivery>.DisplayCount();

            Console.WriteLine($"Число дней до доставки: {order_1?.Delivery?.DateDelivery.NumberDaysBeforeDelivery()}\n");

            // Создаем товар
            Product<string> product_3 = new Product<string>("Футболка", "BB233423", 2, 1000.00);
            // Создем массив товаров
            Object[] products_2 = new Object[] { product_3 };
            ProductCollection productCollection_2 = new ProductCollection(products_2);
            // Создаем заказ "Доставка на дом"
            homeDelivery = new HomeDelivery(HomeDeliveryType.Courier, "Москва, Ленинский пр-т, д. 25, кв. 10", DateTime.Now);
            Order<HomeDelivery> order_2 = new Order<HomeDelivery>(homeDelivery, productCollection_2, 2, "...");
            order_2.ShowOrder();

            ++Order<HomeDelivery>.Count;
            Order<HomeDelivery>.DisplayCount();

            Console.WriteLine("\nЗакзы (Доставка в пункт выдачи)...\n");
            // Создаем товар
            Product<string> product_4 = new Product<string>("Футболка", "BB933423", 1, 600.00);
            // Создем массив товаров
            Object[] products_3 = new Object[] { product_4 };
            ProductCollection productCollection_3 = new ProductCollection(products_3);
            // Создаем заказ "Доставка в пункт выдачи"
            PickPointDelivery pickPointDelivery = new PickPointDelivery("Москва, Кутузовский пр-т, д. 10", DateTime.Now);
            Order<PickPointDelivery> order_3 = new Order<PickPointDelivery>(pickPointDelivery, productCollection_3, 3, "...");
            order_3.ShowOrder();

            ++Order<PickPointDelivery>.Count;
            Order<PickPointDelivery>.DisplayCount();

            Console.WriteLine("\nЗакзы (Доставка в розничный магазин)...\n");
            // Создаем товар
            Product<string> product_5 = new Product<string>("Рубашка", "FF1933423", 1, 1600.00);
            // Создем массив товаров
            Object[] products_4 = new Object[] { product_5 };
            ProductCollection productCollection_4 = new ProductCollection(products_4);
            // Создаем заказ "Доставка в пункт выдачи"
            ShopDelivery shopDelivery = new ShopDelivery("Москва, Ленинградский пр-т, д. 101", DateTime.Now);
            Order<ShopDelivery> order_4 = new Order<ShopDelivery>(shopDelivery, productCollection_4, 4, "...");
            order_4.ShowOrder();

            ++Order<ShopDelivery>.Count;
            Order<ShopDelivery>.DisplayCount();

            Console.ReadLine();
        }
    }
}
