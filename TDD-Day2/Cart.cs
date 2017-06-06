using System;
using System.Collections.Generic;
using System.Linq;

namespace TDD_Day2
{
    internal class Cart
    {
        private Dictionary<int, double> rules;

        public Cart(Dictionary<int, double> rules)
        {
            this.rules = rules;
        }

        internal double Checkout(List<Book> shoppingItems, Func<Book, int> selector)
        {
            double result = 0.0;
            double discount = 0.0;
            if (rules.TryGetValue(shoppingItems.Count(), out discount))
            {
                result = shoppingItems.Sum(selector) * (1 - discount);
            }
            else
                result = shoppingItems.Sum(selector);

            return result;
        }
    }
}