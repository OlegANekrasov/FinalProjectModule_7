using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectModule_7.ProductClasses
{
    abstract class BaseProduct <TCode>
    {
        private string Name;     // Наименование
        private TCode Code;      // Код продукта
        private int Quantity;    // Количество
        internal double Cost;     // Стоимость

        public BaseProduct(string name, TCode code, int quantity, double cost)
        {
            Name = name;
            Code = code;
            Quantity = quantity;
            Cost = cost;
        }

        public virtual void ShowProduct() 
        {
            Console.WriteLine($"Товар: \"{Name}\"");
            Console.WriteLine($"Код продукта: {Code}");
            Console.WriteLine($"Количество: {Quantity}");
        }
    }
}
