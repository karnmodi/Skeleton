using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class TestCart
    {
        
        [TestMethod]
        public void InstanceOK()
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


        [TestMethod]
        public void FindMethodOk()
        {
            clsCart Acart = new clsCart();
            Boolean Found = false;
            Int32 CartID = 4;
            Found = Acart.Find(CartID);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestcartIDFound()
        {
            clsCart ACart = new clsCart();
            Boolean found = false;
            Boolean ok = true;
            Int32 CartID = 4;

            found = ACart.Find(CartID);
            if (ACart.CartID != 4) 
            {
                ok= false;
            }
            Assert.IsTrue(ok);
        }

        [TestMethod]
        public void TestTotalPriceFound()
        {
            clsCart ACart = new clsCart();
            Boolean found = false;
            Boolean ok = true;
            Int32 CartID = 4;

            found = ACart.Find(CartID);
            if (ACart.TotalPrice != 220)
            {
                ok = false;
            }
            Assert.IsTrue(ok);
        }

        [TestMethod]
        public void TestCartDiscriptionFound()
        {
            clsCart ACart = new clsCart();
            Boolean found = false;
            Boolean ok = true;
            Int32 CartID = 4;

            found = ACart.Find(CartID);
            if (ACart.CartDiscription != "Last item")
            {
                ok = false;
            }
            Assert.IsTrue(ok);
        }

        [TestMethod]
        public void TestQuantityFound()
        {
            clsCart ACart = new clsCart();
            Boolean found = false;
            Boolean ok = true;
            Int32 CartID = 4;

            found = ACart.Find(CartID);
            if (ACart.Quantity != 1)
            {
                ok = false;
            }
            Assert.IsTrue(ok);
        }

        [TestMethod]
        public void TestDateAddedFound()
        {
            clsCart ACart = new clsCart();
            Boolean found = false;
            Boolean ok = true;
            Int32 CartID = 4;

            found = ACart.Find(CartID);
            if (ACart.DateAdded != Convert.ToDateTime("23-05-2024"))
            {
                ok = false;
            }
            Assert.IsTrue(ok);
        }

        [TestMethod]
        public void TestActiveFound()
        {
            clsCart ACart = new clsCart();
            Boolean found = false;
            Boolean ok = true;
            Int32 CartID = 4;

            found = ACart.Find(CartID);
            if (ACart.Active != true)
            {
                ok = false;
            }
            Assert.IsTrue(ok);
        }


        string CartDescription = "Product A";
        string TotalPrice = "2";
        string Quantity = "2";
        string DateAdded = DateTime.Now.Date.ToString();
        string Active = Convert.ToBoolean(false).ToString();


        [TestMethod]
        public void ValidMethodOK()
        {
            clsCart ACart = new clsCart();
            String Error = "";
            Error = ACart.Valid(CartDescription, TotalPrice, Quantity, DateAdded, Active);
            Assert.AreEqual(Error, "");
        }




        [TestMethod]
        public void CartDescriptionMinLessOne()
        {
            clsCart ACart = new clsCart();
            String Error = "";
            String CartDescription = "";
           Error = ACart.Valid(CartDescription, TotalPrice, Quantity, DateAdded, Active);
            Assert.AreEqual(Error, "Cart Description must not be empty.");
        }


        [TestMethod]
        public void CartDescriptionMin()
        {
            clsCart ACart = new clsCart();
            String Error = "";
            String CartDescription = "D";
           Error = ACart.Valid(CartDescription, TotalPrice, Quantity, DateAdded, Active);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void CartDescriptionMinPlusOne()
        {
            clsCart ACart = new clsCart();
            String Error = "";
            String CartDescription = "DD";
           Error = ACart.Valid(CartDescription, TotalPrice, Quantity, DateAdded, Active);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void CartDescriptionMaxLessOne()
        {
            clsCart ACart = new clsCart();
            String Error = "";
            String CartDescription = "";
            CartDescription = CartDescription.PadRight(99, 'D');
           Error = ACart.Valid(CartDescription, TotalPrice, Quantity, DateAdded, Active);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CartDescriptionMax()
        {
            clsCart ACart = new clsCart();
            String Error = "";
            String CartDescription = "";
            CartDescription = CartDescription.PadRight(100, 'D');
           Error = ACart.Valid(CartDescription, TotalPrice, Quantity, DateAdded, Active);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void CartDescriptionMaxPlusOne()
        {
            clsCart ACart = new clsCart();
            String Error = "";
            String CartDescription = "";
            CartDescription = CartDescription.PadRight(101, 'D');
           Error = ACart.Valid(CartDescription, TotalPrice, Quantity, DateAdded, Active);
            Assert.AreEqual(Error, "Cart Description must be less than 100");
        }

        [TestMethod]
        public void CartDescriptionMid()
        {
            clsCart ACart = new clsCart();
            String Error = "";
            String CartDescription = "";
            CartDescription = CartDescription.PadRight(50, 'D');
           Error = ACart.Valid(CartDescription, TotalPrice, Quantity, DateAdded, Active);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void CartDescriptionExtremeMAX()
        {
            clsCart ACart = new clsCart();
            String Error = "";
            String CartDescription = "";
            CartDescription = CartDescription.PadRight(1000, 'D');
           Error = ACart.Valid(CartDescription, TotalPrice, Quantity, DateAdded, Active);
            Assert.AreEqual(Error, "Cart Description must be less than 100");
        }




        [TestMethod]
        public void QuantityExtremeMin()
        {
            clsCart ACart = new clsCart();
            String Error = "";
            Int32 TestData = -500;
            string Quantity = Convert.ToString(TestData);
            Error = ACart.Valid(CartDescription, TotalPrice, Quantity, DateAdded, Active);
            Assert.AreEqual(Error, "Quantity must not be in negative format.");
        }

        [TestMethod]
        public void QuantityMinLessOne()
        {
            clsCart ACart = new clsCart();
            String Error = "";
            Int32 TestData = 0;
            string Quantity = Convert.ToString(TestData);
            Error = ACart.Valid(CartDescription, TotalPrice, Quantity, DateAdded, Active);
            Assert.AreEqual(Error, "Quantity must not be zero.");
        }


        [TestMethod]
        public void QuantityMin()
        {
            clsCart ACart = new clsCart();
            String Error = "";
            Int32 TestData = 1;
            string Quantity = Convert.ToString(TestData);
            Error = ACart.Valid(CartDescription, TotalPrice, Quantity, DateAdded, Active);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void QuantityMinPlusOne()
        {
            clsCart ACart = new clsCart();
            String Error = "";
            Int32 TestData = 2;
            string Quantity = Convert.ToString(TestData);
            Error = ACart.Valid(CartDescription, TotalPrice, Quantity, DateAdded, Active);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void QuantityMaxLessOne()
        {
            clsCart ACart = new clsCart();
            String Error = "";
            Int32 TestData = 9999;
            string Quantity = Convert.ToString(TestData);
            Error = ACart.Valid(CartDescription, TotalPrice, Quantity, DateAdded, Active);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMax()
        {
            clsCart ACart = new clsCart();
            String Error = "";
            Int32 TestData = 10000;
            string Quantity = Convert.ToString(TestData);
            Error = ACart.Valid(CartDescription, TotalPrice, Quantity, DateAdded, Active);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void QuantityMaxPlusOne()
        {
            clsCart ACart = new clsCart();
            String Error = "";
            Int32 TestData = 10001;
            string Quantity = Convert.ToString(TestData);
            Error = ACart.Valid(CartDescription, TotalPrice, Quantity, DateAdded, Active);
            Assert.AreEqual(Error, "Quantity must not be more than 10000");
        }

        [TestMethod]
        public void QuantityMid()
        {
            clsCart ACart = new clsCart();
            String Error = "";
            Int32 TestData = 5000;
            string Quantity = Convert.ToString(TestData);
            Error = ACart.Valid(CartDescription, TotalPrice, Quantity, DateAdded, Active);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void QuantityExtremeMAX()
        {
            clsCart ACart = new clsCart();
            String Error = "";
            Int32 TestData = 5000000;
            string Quantity = Convert.ToString(TestData);
            Error = ACart.Valid(CartDescription, TotalPrice, Quantity, DateAdded, Active);
            Assert.AreEqual(Error, "Quantity must not be more than 10000");
        }

        [TestMethod]
        public void QuantityInvalidData()
        {
            clsCart ACart = new clsCart();
            string Error = "";
            string Quantity = "Ten";
            Error = ACart.Valid(CartDescription, TotalPrice, Quantity, DateAdded, Active);
            Assert.AreEqual(Error, "Quantity is not in correct format.");
        }


        [TestMethod]
        public void TotalPriceExtremeMin()
        {
            clsCart ACart = new clsCart();
            String Error = "";
            Int32 TestPrice = -500;
            string TotalPrice = Convert.ToString(TestPrice);
            Error = ACart.Valid(CartDescription, TotalPrice, Quantity, DateAdded, Active);
            Assert.AreEqual(Error, "Total Price must not be in negative format.");
        }

        [TestMethod]
        public void TotalPriceMinLessOne()
        {
            clsCart ACart = new clsCart();
            String Error = "";
            Int32 TestPrice = 0;
            string TotalPrice = Convert.ToString(TestPrice);
            Error = ACart.Valid(CartDescription, TotalPrice, Quantity, DateAdded, Active);
            Assert.AreEqual(Error, "Total Price must not be zero.");
        }


        [TestMethod]
        public void TotalPriceMin()
        {
            clsCart ACart = new clsCart();
            String Error = "";
            Int32 TestPrice = 1;
            string TotalPrice = Convert.ToString(TestPrice);
            Error = ACart.Valid(CartDescription, TotalPrice, Quantity, DateAdded, Active);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void TotalPriceMinPlusOne()
        {
            clsCart ACart = new clsCart();
            String Error = "";
            Int32 TestPrice = 2;
            string TotalPrice = Convert.ToString(TestPrice);
            Error = ACart.Valid(CartDescription, TotalPrice, Quantity, DateAdded, Active);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void TotalPriceMaxLessOne()
        {
            clsCart ACart = new clsCart();
            String Error = "";
            Int32 TestPrice = 14999;
            string TotalPrice = Convert.ToString(TestPrice);
            Error = ACart.Valid(CartDescription, TotalPrice, Quantity, DateAdded, Active);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TotalPriceMax()
        {
            clsCart ACart = new clsCart();
            String Error = "";
            Int32 TestPrice = 15000;
            string TotalPrice = Convert.ToString(TestPrice);
            Error = ACart.Valid(CartDescription, TotalPrice, Quantity, DateAdded, Active);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void TotalPriceMaxPlusOne()
        {
            clsCart ACart = new clsCart();
            String Error = "";
            Int32 TestPrice = 15001;
            string TotalPrice = Convert.ToString(TestPrice);
            Error = ACart.Valid(CartDescription, TotalPrice, Quantity, DateAdded, Active);
            Assert.AreEqual(Error, "Total Price must not be more than 15000.");
        }

        [TestMethod]
        public void TotalPriceMid()
        {
            clsCart ACart = new clsCart();
            String Error = "";
            Int32 TestPrice = 7500;
            string TotalPrice = Convert.ToString(TestPrice);
            Error = ACart.Valid(CartDescription, TotalPrice, Quantity, DateAdded, Active);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void TotalPriceExtremeMAX()
        {
            clsCart ACart = new clsCart();
            String Error = "";
            Int32 TestPrice = 100000;
            string TotalPrice = Convert.ToString(TestPrice);
            Error = ACart.Valid(CartDescription, TotalPrice, Quantity, DateAdded, Active);
            Assert.AreEqual(Error, "Total Price must not be more than 15000.");
        }

        [TestMethod]
        public void TotalPriceInvalidData()
        {
            clsCart ACart = new clsCart();
            string Error = "";
            string TotalPrice = "12.52";
            Error = ACart.Valid(CartDescription, TotalPrice, Quantity, DateAdded, Active);
            Assert.AreEqual(Error, "Total Price is not in correct format.");
        }




        [TestMethod]
        public void DateAddedExtremeMin()
        {
            clsCart ACart = new clsCart();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);
            String DateAdded = TestDate.ToString();
            Error = ACart.Valid(CartDescription, TotalPrice, Quantity, DateAdded, Active);
            Assert.AreEqual(Error, "Date must not be in the past.");
        }

        [TestMethod]
        public void DateAddedMinLessOne()
        {
            clsCart ACart = new clsCart();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(-1);
            String DateAdded = TestDate.ToString();
            Error = ACart.Valid(CartDescription, TotalPrice, Quantity, DateAdded, Active);
            Assert.AreEqual(Error, "Date must not be in the past.");
        }


        [TestMethod]
        public void DateAddedMin()
        {
            clsCart ACart = new clsCart();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            String DateAdded = TestDate.ToString();
            Error = ACart.Valid(CartDescription, TotalPrice, Quantity, DateAdded, Active);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void DateAddedMinPlusOne()
        {
            clsCart ACart = new clsCart();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(1);
            String DateAdded = TestDate.ToString();
            Error = ACart.Valid(CartDescription, TotalPrice, Quantity, DateAdded, Active);
            Assert.AreEqual(Error, "Date must not be in the Future.");
        }


        [TestMethod]
        public void DateAddedExtremeMAX()
        {
            clsCart ACart = new clsCart();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(100);
            String DateAdded = TestDate.ToString();
            Error = ACart.Valid(CartDescription, TotalPrice, Quantity, DateAdded, Active);
            Assert.AreEqual(Error, "Date must not be in the Future.");
        }


        [TestMethod]
        public void DateAddedInvalidFormat()
        {
            clsCart ACart = new clsCart();
            String Error = "";
            String DateAdded = "This is not a DATE";
            Error = ACart.Valid(CartDescription, TotalPrice, Quantity, DateAdded, Active);
            Assert.AreEqual(Error, "Added Date is not in the proper format.");
        }
    }
}
