using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tstProduct
    {
        /******************Instance of the class Test*********************/

        [TestMethod]
        public void InstanceOK()
        {
            clsProduct AProduct = new clsProduct();
            Assert.IsNotNull(AProduct);
        }

        /*************************Property OK Tests************************/

        [TestMethod]
        public void ProductIDPropertyOK()
        {
            clsProduct AProduct = new clsProduct();
            Int32 TestData = 1;
            AProduct.ProductID = TestData;
            Assert.AreEqual(AProduct.ProductID, TestData);
        }
        
        [TestMethod]
        public void TitlePropertyOK()
        {
            clsProduct AProduct = new clsProduct();
            String TestData = "Product1";
            AProduct.Title = TestData;
            Assert.AreEqual(AProduct.Title, TestData);
        }



        [TestMethod]
        public void DescriptionPropertyOK()
        {
            clsProduct AProduct = new clsProduct();
            String TestData = "Description for the product.";
            AProduct.Description = TestData;
            Assert.AreEqual(AProduct.Description, TestData);
        }



        [TestMethod]
        public void PricePropertyOK()
        {
            clsProduct AProduct = new clsProduct();
            double TestData = 250.50;
            AProduct.Price = TestData;
            Assert.AreEqual(AProduct.Price, TestData);
        }



        [TestMethod]
        public void ConditionPropertyOK()
        {
            clsProduct AProduct = new clsProduct();
            String TestData = "Condition : Good, Bad, Avrage, Worst";
            AProduct.Condition = TestData;
            Assert.AreEqual(AProduct.Condition, TestData);
        }





        [TestMethod]
        public void AvailabilityPropertyOK()
        {
            clsProduct AProduct = new clsProduct();
            Boolean TestData = true;
            AProduct.Availability = TestData;
            Assert.AreEqual(AProduct.Availability, TestData);
        }


        [TestMethod]
        public void DateListedPropertyOK()
        {
            clsProduct AProduct = new clsProduct();
            DateTime TestData = DateTime.Now.Date;
            AProduct.DateListed = TestData;
            Assert.AreEqual(AProduct.DateListed, TestData);
        }



        /**********************FInd MEthod Test***************************/

        [TestMethod]
        public void FindMethodOK()
        {

            clsProduct AProduct = new clsProduct();
            Boolean Found = false;
            Int32 ProductID = 5;
            Found = AProduct.Find(ProductID);
            Assert.IsTrue(Found);

        }


        /***********************Property Data Tests*********************/

        [TestMethod]
        public void TestProductIDFound()
        {
            clsProduct AProduct = new clsProduct();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ProductID = 5;
            Found = AProduct.Find(ProductID);
            if(AProduct.ProductID!= 5)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestTitleFound()
        {
            clsProduct AProduct = new clsProduct();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ProductID = 5;
            Found = AProduct.Find(ProductID);
            if(AProduct.Title!= "Database Management")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestDescriptionFound()
        {
            clsProduct AProduct = new clsProduct();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ProductID = 5;
            Found = AProduct.Find(ProductID);
            if(AProduct.Description != "Comprehensive guide on database management systems.")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestPriceFound()
        {
            clsProduct AProduct = new clsProduct();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ProductID = 5;
            Found = AProduct.Find(ProductID);
            if(AProduct.Price!= 59.99)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        
        
        [TestMethod]
        public void TestConditionFound()
        {
            clsProduct AProduct = new clsProduct();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ProductID = 5;
            Found = AProduct.Find(ProductID);
            if(AProduct.Condition!= "New")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        
        
        [TestMethod]
        public void TestAvailabilityFound()
        {
            clsProduct AProduct = new clsProduct();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ProductID = 5;
            Found = AProduct.Find(ProductID);
            if(AProduct.Availability!= true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        
        [TestMethod]
        public void TestDateListedFound()
        {
            clsProduct AProduct = new clsProduct();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ProductID = 5;
            Found = AProduct.Find(ProductID);
            if(AProduct.DateListed!= Convert.ToDateTime("09/05/2024"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

    }
}
