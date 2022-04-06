using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectModule_7.ProductClasses
{
    class Product<TCode> : BaseProduct<TCode>
    {
        public Product(string name, TCode code, int quantity, double cost) : base(name, code, quantity, cost) { }
        public override void ShowProduct() 
        {
            base.ShowProduct();
            Console.WriteLine($"Стоимость товара: {Cost}\n");
        }
    }
}
