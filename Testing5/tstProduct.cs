using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tstProduct
    {



        /***** Test Data *******/

        String Title = "SmartPhone";
        String Description = "Brand new smartphone with advanced features.";
        String Price = "299.99";
        String Condition = "New";
        String DateListed = DateTime.Now.ToShortDateString();
        String Availabilily = Convert.ToString(true);


        /******************** Validation OK Tests *********************/

        [TestMethod]
        public void ValidMethodOK()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            Error = AProduct.Valid(Title, Description, Price, Condition,Availabilily, DateListed);
            Assert.AreEqual(Error, "");
         }

        /********************** Title Validation ************************/

        [TestMethod]
        public void TitleMinLessOne()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            String Title = "";
            Error = AProduct.Valid(Title, Description, Price, Condition, Availabilily, DateListed);
            Assert.AreEqual(Error, "");
        }
        
        
        [TestMethod]
        public void TitleMin()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            String Title = "a";
            Error = AProduct.Valid(Title, Description, Price, Condition, Availabilily, DateListed);
            Assert.AreEqual(Error, "");
        }
        
        
        [TestMethod]
        public void TitleMinPlusOne()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            String Title = "aa";
            Error = AProduct.Valid(Title, Description, Price, Condition, Availabilily, DateListed);
            Assert.AreEqual(Error, "");
        }
        
        
        [TestMethod]
        public void TitleMaxLessOne()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            String Title = "";
            Title = Title.PadRight(29, 'a');
            Error = AProduct.Valid(Title, Description, Price, Condition, Availabilily, DateListed);
            Assert.AreEqual(Error, "");
        }
        
        
        [TestMethod]
        public void TitleMax()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            String Title = "";
            Title = Title.PadRight(30, 'a');
            Error = AProduct.Valid(Title, Description, Price, Condition, Availabilily, DateListed);
            Assert.AreEqual(Error, "");
        }
        
        
        [TestMethod]
        public void TitleMaxPlusOne()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            String Title = "";
            Title = Title.PadRight(31, 'a');
            Error = AProduct.Valid(Title, Description, Price, Condition, Availabilily, DateListed);
            Assert.AreEqual(Error, "");
        }
        
        
        [TestMethod]
        public void TitleMid()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            String Title = "";
            Title = Title.PadRight(15, 'a');
            Error = AProduct.Valid(Title, Description, Price, Condition, Availabilily, DateListed);
            Assert.AreEqual(Error, "");
        }

        
        [TestMethod]
        public void TitleExtremeMax()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            String Title = "";
            Title = Title.PadRight(300, 'a');
            Error = AProduct.Valid(Title, Description, Price, Condition, Availabilily, DateListed);
            Assert.AreEqual(Error, "");
        }


         /********************** Description Validation ************************/

        [TestMethod]
        public void DescriptionMinLessOne()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            String Description = "";
            Error = AProduct.Valid(Title, Description, Price, Condition, Availabilily, DateListed);
            Assert.AreEqual(Error, "");
        }
        
        
        [TestMethod]
        public void DescriptionMin()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            String Description = "d";
            Error = AProduct.Valid(Title, Description, Price, Condition, Availabilily, DateListed);
            Assert.AreEqual(Error, "");
        }
        
        
        [TestMethod]
        public void DescriptionMinPlusOne()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            String Description = "dd";
            Error = AProduct.Valid(Title, Description, Price, Condition, Availabilily, DateListed);
            Assert.AreEqual(Error, "");
        }
        
        
        [TestMethod]
        public void DescriptionMaxLessOne()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            String Description = "";
            Description = Description.PadRight(499, 'd');
            Error = AProduct.Valid(Title, Description, Price, Condition, Availabilily, DateListed);
            Assert.AreEqual(Error, "");
        }
        
        
        [TestMethod]
        public void DescriptionMax()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            String Description = "";
            Description = Description.PadRight(500, 'd');
            Error = AProduct.Valid(Title, Description, Price, Condition, Availabilily, DateListed);
            Assert.AreEqual(Error, "");
        }
        
        
        [TestMethod]
        public void DescriptionMaxPlusOne()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            string Description = "";
            Description = Description.PadRight(501, 'd');
            Error = AProduct.Valid(Title, Description, Price, Condition, Availabilily, DateListed);
            Assert.AreEqual(Error, "");
        }
        
        
        [TestMethod]
        public void DescriptionMid()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            string Description = "";
            Description = Description.PadRight(250, 'd');
            Error = AProduct.Valid(Title, Description, Price, Condition, Availabilily, DateListed);
            Assert.AreEqual(Error, "");
        }

        
        [TestMethod]
        public void DescriptionExtremeMax()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            string Description = "";
            Description = Description.PadRight(5000, 'd');
            Error = AProduct.Valid(Title, Description, Price, Condition, Availabilily, DateListed);
            Assert.AreEqual(Error, "");
        }

        /********************** Price Validation ************************/

        [TestMethod]
        public void PriceExtremeMin()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            Double TestPrice = -500.00;
            String Price = TestPrice.ToString();
            Error = AProduct.Valid(Title, Description, Price, Condition, Availabilily, DateListed);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMinLessOne()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            Double TestPrice = 0;
            String Price = TestPrice.ToString();
            Error = AProduct.Valid(Title, Description, Price, Condition, Availabilily, DateListed);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMin()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            Double TestPrice = 1;
            String Price = TestPrice.ToString();
            Error = AProduct.Valid(Title, Description, Price, Condition, Availabilily, DateListed);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMinPlusOne()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            Double TestPrice = 2;
            String Price = TestPrice.ToString();
            Error = AProduct.Valid(Title, Description, Price, Condition, Availabilily, DateListed);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMaxLessOne()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            Double TestPrice = 4998.99;
            String Price = TestPrice.ToString();
            Error = AProduct.Valid(Title, Description, Price, Condition, Availabilily, DateListed);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMax()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            Double TestPrice = 4999.99;
            String Price = TestPrice.ToString();
            Error = AProduct.Valid(Title, Description, Price, Condition, Availabilily, DateListed);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMaxPlusOne()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            Double TestPrice = 5000.99;
            String Price = TestPrice.ToString();
            Error = AProduct.Valid(Title, Description, Price, Condition, Availabilily, DateListed);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMid()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            Double TestPrice = 2499.98;
            String Price = TestPrice.ToString();
            Error = AProduct.Valid(Title, Description, Price, Condition, Availabilily, DateListed);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceExtremeMax()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            Double TestPrice = 10000;
            String Price = TestPrice.ToString();
            Error = AProduct.Valid(Title, Description, Price, Condition, Availabilily, DateListed);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceInvalidData()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            
            String Price = "This is Not a Double.";
            Error = AProduct.Valid(Title, Description, Price, Condition, Availabilily, DateListed);
            Assert.AreEqual(Error, "");
        }



        /********************** Condition Validation ************************/

        [TestMethod]
        public void ConditionMinLessOne()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            String Condition = "";
            Error = AProduct.Valid(Title, Description, Price, Condition, Availabilily, DateListed);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void ConditionMin()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            String Condition = "C";
            Error = AProduct.Valid(Title, Description, Price, Condition, Availabilily, DateListed);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void ConditionMinPlusOne()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            String Condition = "Cc";
            Error = AProduct.Valid(Title, Description, Price, Condition, Availabilily, DateListed);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void ConditionMaxLessOne()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            String Condition = "";
            Condition = Condition.PadRight(19, 'C');
            Error = AProduct.Valid(Title, Description, Price, Condition, Availabilily, DateListed);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void ConditionMax()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            String Condition = "";
            Condition = Condition.PadRight(20, 'C');
            Error = AProduct.Valid(Title, Description, Price, Condition, Availabilily, DateListed);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void ConditionMaxPlusOne()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            String Condition = "";
            Condition = Condition.PadRight(21, 'C');
            Error = AProduct.Valid(Title, Description, Price, Condition, Availabilily, DateListed);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void ConditionMid()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            String Condition = "";
            Condition = Condition.PadRight(10, 'C');
            Error = AProduct.Valid(Title, Description, Price, Condition, Availabilily, DateListed);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void ConditionExtremeMax()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            String Condition = "";
            Condition = Condition.PadRight(500, 'C');
            Error = AProduct.Valid(Title, Description, Price, Condition, Availabilily, DateListed);
            Assert.AreEqual(Error, "");
        }




        /********************** DateListed Validation ************************/

        [TestMethod]
        public void DateListedExtremeMinimum()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            DateTime TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);

            string DateListed = TestDate.ToString();
            Error = AProduct.Valid(Title, Description, Price, Condition, Availabilily, DateListed);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void DateListedMinLessOne()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            DateTime TestDate = DateTime.Now.Date;
            TestDate  = TestDate.AddDays(-1);

            string DateListed = TestDate.ToString();
            Error = AProduct.Valid(Title, Description, Price, Condition, Availabilily, DateListed);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void DateListedMin()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            DateTime TestDate = DateTime.Now.Date;

            string DateListed = TestDate.ToString();
            Error = AProduct.Valid(Title, Description, Price, Condition, Availabilily, DateListed);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void DateListedMinPlusOne()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            DateTime TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(1);

            string DateListed = TestDate.ToString();
            Error = AProduct.Valid(Title, Description, Price, Condition, Availabilily, DateListed);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void DateListedExtremeMaximum()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            DateTime TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(100);

            string DateListed = TestDate.ToString();
            Error = AProduct.Valid(Title, Description, Price, Condition, Availabilily, DateListed);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void DateListedInvalidDataType()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";


            string DateListed = "This is not a Valid Date Data Type.";
            Error = AProduct.Valid(Title, Description, Price, Condition, Availabilily, DateListed);
            Assert.AreEqual(Error, "");
        }



        /****************** Instance of the class Test *********************/

        [TestMethod]
        public void InstanceOK()
        {
            clsProduct AProduct = new clsProduct();
            Assert.IsNotNull(AProduct);
        }

        /************************* Property OK Tests ************************/

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
            if(AProduct.Price == 5239.99)
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
