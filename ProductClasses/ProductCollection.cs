using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectModule_7.ProductClasses
{
    class ProductCollection
    {
        private Object[] products;
        private int length;
        public int Length
        {
            get => length;
            private set => length = value;
        }
        
        public ProductCollection(Object[] products)
        {
            this.products = products;           // Агрегация
            Length = products.Length;
        }
        
        // индексатор
        public Object this[int index]
        {
            get => products[index];
            //set => products[index] = value;
        }
    }
}
