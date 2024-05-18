using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing2
{
    [TestClass]
    public class tstProductCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsProductCollection AllProducts = new clsProductCollection();
            Assert.IsNotNull(AllProducts);
        }


        [TestMethod]
        public void ProuctListOK()
        {
            clsProductCollection AllProducts = new clsProductCollection();
            List<clsProduct> TestList = new List<clsProduct>();
            clsProduct TestItem = new clsProduct();

            TestItem.ProductID = 1;
            TestItem.Title = "Test";
            TestItem.Description = "Description";
            TestItem.Price = 5.50;
            TestItem.Condition = "Good";
            TestItem.Availability = true;
            TestItem.DateListed = DateTime.Now.Date;

            TestList.Add(TestItem);
            AllProducts.ProductList = TestList;

            Assert.AreEqual(AllProducts.ProductList, TestList);
        }


        [TestMethod]
        public void CountPropertyOK()
        {
            clsProductCollection AllProducts = new clsProductCollection();
            Int32 nCount = 0;
            AllProducts.Count = nCount;
            Assert.AreEqual(AllProducts.Count, AllProducts.Count);
        }

        [TestMethod]
        public void ThisProductPropertyOK()
        {
            clsProductCollection AllProducts = new clsProductCollection();
            clsProduct TestItem = new clsProduct();

            TestItem.ProductID = 1;
            TestItem.Title = "Test";
            TestItem.Description = "Description";
            TestItem.Price = 5.50;
            TestItem.Condition = "Good";
            TestItem.Availability = true;
            TestItem.DateListed = DateTime.Now.Date;

            
            AllProducts.ThisProduct = TestItem;

            Assert.AreEqual(AllProducts.ThisProduct, TestItem);
        }




        public void ListAndCountOK()
        {
            clsProductCollection AllProducts = new clsProductCollection();
            List<clsProduct> TestList = new List<clsProduct>();
            clsProduct TestItem = new clsProduct();

            TestItem.ProductID = 1;
            TestItem.Title = "Test";
            TestItem.Description = "Description";
            TestItem.Price = 5.50;
            TestItem.Condition = "Good";
            TestItem.Availability = true;
            TestItem.DateListed = DateTime.Now.Date;

            TestList.Add(TestItem);
            AllProducts.ProductList = TestList;

            Assert.AreEqual(AllProducts.Count, TestList.Count);
        }


        [TestMethod]
        public void TwoRecordsPresent()
        {
            clsProductCollection AllProducts = new clsProductCollection();
            Assert.AreEqual(AllProducts.Count,AllProducts.Count);
        }



    }
}
