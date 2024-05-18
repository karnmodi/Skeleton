using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class TestCart
    {
        public object TestData { get; private set; }

        [TestMethod]
        public void TestMethod1()
        {
            clsCart ACart = new clsCart();
            Assert.IsNotNull(ACart);
        }
        [TestMethod]
        public void ActivePropertyOk()
        {
            clsCart ACart = new clsCart();
            Boolean TestData = true;
            ACart.Active = TestData;
            Assert.AreEqual(ACart.Active, TestData);
        }

        [TestMethod]
        public void CartIDPropertyOk()
        {
            clsCart ACart = new clsCart();
            int TestData = 1;
            ACart.CartID = TestData;
            Assert.AreEqual(ACart.CartID, TestData);
        }

        [TestMethod]
        public void TotalPricePropertyOK()
        {
            clsCart ACart = new clsCart();
            int TestData = 35;
            ACart.TotalPrice = TestData;
            Assert.AreEqual(ACart.TotalPrice, TestData);
        }

        [TestMethod]
        public void CartDiscriptionPropertyOK()
        {
            clsCart ACart = new clsCart();
            String TestData = "100";
            ACart.CartDiscription = TestData;
            Assert.AreEqual(ACart.CartDiscription, TestData);
        }

        [TestMethod]
        public void QuantityPropertyOK()
        {
            clsCart ACart = new clsCart();
            int TestData = 7;
            ACart.Quantity = TestData;
            Assert.AreEqual(ACart.Quantity, TestData);
        }

        [TestMethod]
        public void DateAddedPropertyOK()
        {
            clsCart ACart = new clsCart();
            DateTime TestData = DateTime.Now.Date;
            ACart.DateAdded = TestData;
            Assert.AreEqual(ACart.DateAdded, TestData);
        }


    }
}
