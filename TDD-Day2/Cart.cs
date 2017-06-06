using System;
using System.Collections.Generic;

namespace TDD_Day2
{
    internal class Cart
    {
        private Dictionary<int, double> rules;

        public Cart(Dictionary<int, double> rules)
        {
            this.rules = rules;
        }

        internal object Checkout(List<Book> shoppingItems, Func<object, object> p)
        {
            throw new NotImplementedException();
        }
    }
}