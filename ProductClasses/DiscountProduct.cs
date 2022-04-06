using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectModule_7.ProductClasses
{
    class DiscountProduct<TCode> : BaseProduct<TCode>
    {
        private int discount;
        public int Discount
        {
            get {return discount;}
            private set 
            {
                if(value >= 1 && value <= 50)
                {
                    discount = value;
                }
                else
                {
                    Console.WriteLine("Скидка может быть от 1% до 50%\n");
                    discount = 0;
                }
            }
        }

        public DiscountProduct(string name, TCode code, int quantity, double cost, int discount) : base(name, code, quantity, cost) 
        {
            Discount = discount;
        }

        public override void ShowProduct()
        {
            base.ShowProduct();

            double discountCost = Cost;
            if (Discount > 0)
                discountCost = Discount * Cost / 100;

            Console.WriteLine($"Скидка: {Discount}");
            Console.WriteLine($"Стоимость товара: {Cost}; Стоимость товара с учетом скидки: {discountCost}\n");
        }
    }
}
