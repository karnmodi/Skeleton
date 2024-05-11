using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tstProduct
    {

        [TestMethod]
        public void InstanceOK()
        {
            clsProduct AProduct = new clsProduct();
            Assert.IsNotNull(AProduct);
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
            AProduct.Descripiton = TestData;
            Assert.AreEqual(AProduct.Descripiton, TestData);
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

        public void ImageUrlPropertyOK()
        {
            clsProduct AProduct = new clsProduct();
            String TestData = "Image Url will be pasted here.";
            AProduct.ImageURL = TestData;
            Assert.AreEqual(AProduct.ImageURL, TestData);
        }




        [TestMethod]

        public void DateListedPropertyOK()
        {
            clsProduct AProduct = new clsProduct();
            DateTime TestData = DateTime.Now.Date;
            AProduct.DateListed = TestData;
            Assert.AreEqual(AProduct.DateListed, TestData);
        }
    }
}
