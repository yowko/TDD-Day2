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
            result = GetAmout(shoppingItems, selector);

            return result;
        }

        private double GetAmout(List<Book> shoppingItems, Func<Book, int> selector)
        {
            double result=0.0;
            double discount = 0.0;
            var distinctItems = shoppingItems.Distinct().ToList();
            if (distinctItems.Count()>1)
            {
                var expectedItems = shoppingItems.ToList();
                foreach (var item in distinctItems)
                {
                    expectedItems.Remove(item);
                }
                if (rules.TryGetValue(distinctItems.Count(), out discount))
                {
                    result = distinctItems.Sum(selector) * (1 - discount);
                }
                result += GetAmout(expectedItems, selector);
            }
            else
                result = distinctItems.Sum(selector);
            
            return result;
        }
    }
}