using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibrary;
using System.Collections.Generic;

namespace Testing4
{
    [TestClass]
    public class TestCartCollection
    {

        [TestMethod]
        public void InstanceOK()
        {
            clsCartCollection AllCarts = new clsCartCollection();
            Assert.IsNotNull(AllCarts);
        }


        [TestMethod]
        public void CartListOK()
        {
            clsCartCollection AllCarts = new clsCartCollection();
            List<clsCart> TestList = new List<clsCart>();
            clsCart TestItem = new clsCart();
            TestItem.CartID = 1;
            TestItem.CartDiscription = "Cart for User 1";
            TestItem.TotalPrice = 500;
            TestItem.Quantity = 20;
            TestItem.Active = true;
            TestItem.DateAdded = DateTime.Now.Date;
            TestList.Add(TestItem);
            AllCarts.CartList = TestList;
            Assert.AreEqual(AllCarts.CartList, TestList);
        }


        [TestMethod]
        public void CountPropertyOK()
        {
            clsCartCollection AllCarts = new clsCartCollection();
            Int32 nCount = 0;
            AllCarts.Count = nCount;
            Assert.AreEqual(AllCarts.Count, nCount);
        }

        [TestMethod]
        public void ThisCartPropertyOK()
        {
            clsCartCollection AllCarts = new clsCartCollection();
            clsCart TestItem = new clsCart();
            TestItem.CartID = 1;
            TestItem.CartDiscription = "Cart for User 1";
            TestItem.TotalPrice = 500;
            TestItem.Quantity = 20;
            TestItem.Active = true;
            TestItem.DateAdded = DateTime.Now.Date;
            AllCarts.ThisCart = TestItem;

            Assert.AreEqual(AllCarts.ThisCart, TestItem);
        }




        public void ListAndCountOK()
        {
            clsCartCollection AllCarts = new clsCartCollection();
            List<clsCart> TestList = new List<clsCart>();
            clsCart TestItem = new clsCart();
            TestItem.CartID = 1;
            TestItem.CartDiscription = "Cart for User 1";
            TestItem.TotalPrice = 500;
            TestItem.Quantity = 20;
            TestItem.Active = true;
            TestItem.DateAdded = DateTime.Now.Date;
            TestList.Add(TestItem);
            AllCarts.CartList = TestList;

            Assert.AreEqual(AllCarts.Count, TestList.Count);
        }


        [TestMethod]
        public void TwoRecordsPresent()
        {
            clsCartCollection AllCarts = new clsCartCollection();
            Assert.AreEqual(AllCarts.Count, AllCarts.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            clsCartCollection AllCarts = new clsCartCollection();
            clsCart TestCart = new clsCart();
            Int32 PrimaryKey = 0;
            TestCart.CartDiscription = "Description based on the cart";
            TestCart.TotalPrice = 500;
            TestCart.Quantity = 5;
            TestCart.DateAdded = DateTime.Now;
            TestCart.Active = false;
            AllCarts.ThisCart = TestCart;
            PrimaryKey = AllCarts.Add();
            TestCart.CartID = PrimaryKey;
            AllCarts.ThisCart.Find(PrimaryKey);
            Assert.AreEqual(AllCarts.ThisCart, TestCart);

        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            clsCartCollection AllCarts = new clsCartCollection();
            clsCart TestCart = new clsCart();
            Int32 PrimaryKey = 0;
            TestCart.CartDiscription = "Description based on the cart";
            TestCart.TotalPrice = 500;
            TestCart.Quantity = 5;
            TestCart.DateAdded = DateTime.Now;
            TestCart.Active = false;
            AllCarts.ThisCart = TestCart;
            PrimaryKey = AllCarts.Add();
            TestCart.CartDiscription = "cart of Bassam";
            TestCart.TotalPrice = 1000;
            TestCart.Quantity = 50;
            TestCart.DateAdded = DateTime.Now;
            TestCart.Active = true;
            AllCarts.ThisCart = TestCart;
            AllCarts.Update();
            AllCarts.ThisCart.Find(PrimaryKey);
            Assert.AreEqual(AllCarts.ThisCart, TestCart);
        }


        [TestMethod]
        public void DeleteMethodOK()
        {
            clsCartCollection AllCarts = new clsCartCollection();
            clsCart TestCart = new clsCart();
            Int32 PrimaryKey;
            TestCart.CartDiscription = "Description based on the cart";
            TestCart.TotalPrice = 500;
            TestCart.Quantity = 5;
            TestCart.DateAdded = DateTime.Now;
            TestCart.Active = false;
            AllCarts.ThisCart = TestCart;
            PrimaryKey = AllCarts.Add();
            TestCart.CartID = PrimaryKey;
            AllCarts.ThisCart.Find(PrimaryKey);
            AllCarts.Delete();
            Boolean Found = AllCarts.ThisCart.Find(PrimaryKey);
            Assert.IsFalse(Found);
        }
        [TestMethod]
        public void ReportByCartDescriptionMethodOK()
        {

            clsCartCollection AllCarts = new clsCartCollection();
            clsCartCollection FilterCarts = new clsCartCollection();
            FilterCarts.ReportByCartDescription("");
            Assert.AreEqual(AllCarts.Count, FilterCarts.Count);
        }

        [TestMethod]
        public void ReportByCartDescriptionNoneFound()
        {
            clsCartCollection FilterCarts = new clsCartCollection();
            FilterCarts.ReportByCartDescription("xxx xxx");
            Assert.AreEqual(0, FilterCarts.Count);
        }
        [TestMethod]

        public void ReportByCartDescriptionTestDataFound()
        {
            clsCartCollection FilterCarts = new clsCartCollection();
            Boolean OK = true;
            FilterCarts.ReportByCartDescription("Last item");
            if (FilterCarts.Count == 2)
            {
                if (FilterCarts.CartList[0].CartID != 24)
                {
                    OK = false;
                }
                if (FilterCarts.CartList[0].CartID != 25)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            Assert.IsFalse(OK);
        }

    }
}
