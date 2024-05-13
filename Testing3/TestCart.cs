using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace Testing3
{
    public class TestCart
    {
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
            boolean TestData = true;
            ACart.Active = TestData;
            Assert.AreEqual(ACart.Active, TestData);
        }

        [TestMethod]
        public void CartIDPropertyNotOk()
        {
            ClsCart ACart = new ClsCart();
            int TestData = 1;
            ACart.CartID = TestData;
            Assert.AreEqual(ACart.CartID, TestData);
        }

        [TestMethod]
        public void UserIDPropertyNotOK()
        {
            clsCart ACart = newclsCart();
            int TestData = 3;
            ACart.UserID = TestData;
            Assert.AreEqual(ACart.UserID, TestData);
        }

        [TestMethod]
        public void ProductIDPropertyNotOK()
        {
            clsCart ACart = newclsCart();
            int TestData = 4;
            ACart.ProductID = TestData;
            Assert.AreEqual(ACart.ProductID, TestData);
        }

        [TestMethod]
        public void QuantityPropertyNotOK()
        {
            clsCart ACart = newclsCart();
            int TestData = 7;
            ACart.Quantity = TestData;
            Assert.AreEqual(ACart.Quantity, TestData);
        }

        [TestMethod]
        public void DateAddedPropertyNotOK()
        {
            clsCart ACart = newclsCart();
            DateTime TestData = DateTime.Now.Date;
            ACart.DateAdded = TestData;
            Assert.AreEqual(ACart.DateAdded, TestData);
        }
    }
}





