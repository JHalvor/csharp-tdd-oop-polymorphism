using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_polymorphism.CSharp.Main
{
    public class Basket
    {
        private List<IProduct> _products = new List<IProduct>();

        public void add(IProduct product)
        {
            _products.Add(product);
        }

        public int getTotal() 
        {
            return _products.Sum(x => x.Price);
        }

        public bool isInBasket(String name)
        {
            return _products.Any(x => x.Name == name);
        }
    }
}
