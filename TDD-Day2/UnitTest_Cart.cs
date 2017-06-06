using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace TDD_Day2
{
    [TestClass]
    public class UnitTest_Cart
    {
        private static Dictionary<int, double> rules;

        [ClassInitialize]
        public static void Init(TestContext testcontext)
        {
            rules = new Dictionary<int, double>
            {
                { 2,0.05 },
                { 3,0.10 },
                { 4,0.20 },
                { 5,0.25 }
            };
        }

        [TestMethod]
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
        [TestMethod]
        public void 第一集買了一本_第二集也買了一本_價格應為190()
        {
            //arrange
            var shoppingItems = new List<Book>()
            {
                new Book {Id=1,Price=100,Name="Harry Potter 1" },
                new Book {Id=2,Price=100,Name="Harry Potter 2" }
            };
            var target = new Cart(rules);



            var expected = 190;
            //act
            var actual = target.Checkout(shoppingItems, a => a.Price);


            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void 一二三集各買了一本_價格應為270()
        {
            //arrange
            var shoppingItems = new List<Book>()
            {
                new Book {Id=1,Price=100,Name="Harry Potter 1" },
                new Book {Id=2,Price=100,Name="Harry Potter 2" },
                new Book {Id=3,Price=100,Name="Harry Potter 3" }
            };
            var target = new Cart(rules);



            var expected = 270;
            //act
            var actual = target.Checkout(shoppingItems, a => a.Price);


            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void 一二三四集各買了一本_價格應為320()
        {
            //arrange
            var shoppingItems = new List<Book>()
            {
                new Book {Id=1,Price=100,Name="Harry Potter 1" },
                new Book {Id=2,Price=100,Name="Harry Potter 2" },
                new Book {Id=3,Price=100,Name="Harry Potter 3" },
                new Book {Id=4,Price=100,Name="Harry Potter 4" }
            };
            var target = new Cart(rules);



            var expected = 320;
            //act
            var actual = target.Checkout(shoppingItems, a => a.Price);


            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void 一次買了整套_一二三四五集各買了一本_價格應為375()
        {
            //arrange
            var shoppingItems = new List<Book>()
            {
                new Book {Id=1,Price=100,Name="Harry Potter 1" },
                new Book {Id=2,Price=100,Name="Harry Potter 2" },
                new Book {Id=3,Price=100,Name="Harry Potter 3" },
                new Book {Id=4,Price=100,Name="Harry Potter 4" },
                new Book {Id=5,Price=100,Name="Harry Potter 5" }
            };
            var target = new Cart(rules);



            var expected = 375;
            //act
            var actual = target.Checkout(shoppingItems, a => a.Price);


            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void 一二集各買了一本_第三集買了兩本_價格應為370()
        {
            //arrange
            var shoppingItems = new List<Book>()
            {
                new Book {Id=1,Price=100,Name="Harry Potter 1" },
                new Book {Id=2,Price=100,Name="Harry Potter 2" },
                new Book {Id=3,Price=100,Name="Harry Potter 3" },
                new Book {Id=3,Price=100,Name="Harry Potter 3" }
            };
            var target = new Cart(rules);



            var expected = 370;
            //act
            var actual = target.Checkout(shoppingItems, a => a.Price);


            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void 第一集買了一本_第二三集各買了兩本_價格應為460()
        {
            //arrange
            var shoppingItems = new List<Book>()
            {
                new Book {Id=1,Price=100,Name="Harry Potter 1" },
                new Book {Id=2,Price=100,Name="Harry Potter 2" },
                new Book {Id=2,Price=100,Name="Harry Potter 2" },
                new Book {Id=3,Price=100,Name="Harry Potter 3" },
                new Book {Id=3,Price=100,Name="Harry Potter 3" }
            };
            var target = new Cart(rules);



            var expected = 460;
            //act
            var actual = target.Checkout(shoppingItems, a => a.Price);


            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
