using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace TDD_Day2
{
    [TestClass]
    public class UnitTest_Cart
    {
        public void 第一集買了一本_其他都沒買_價格應為100元()
        {
            //arrange
            var shoppingItems = new List<Book>()
            {
                new Book {Id=1,Price=100,Name="Harry Potter 1" }
            };
            var target = new Cart(rules);



            var expected = 100;
            //act
            var actual = target.Checkout(shoppingItems, a => a.Price);


            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
