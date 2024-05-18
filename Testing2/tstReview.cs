using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibrary;

namespace Testing5
{
    [TestClass]
    public class tstReview
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsReview AReview = new clsReview();
            Assert.IsNotNull(AReview);
        }


        [TestMethod]
        public void ReviewIDOK()
        {
            clsReview AReview = new clsReview();
            Int32 TestData = 1;
            AReview.ReviewID = TestData;
            Assert.AreEqual(AReview.ReviewID, TestData);
        }


        [TestMethod]

        public void CategoryPropertyOK()
        {
            clsReview AReview = new clsReview();
            String TestData = "Username1";
            AReview.Category = TestData;
            Assert.AreEqual(AReview.Category, TestData);
        }



        [TestMethod]

        public void RatingPropertyOK()
        {
            clsReview AReview = new clsReview();
            Int32 TestData = 5;
            AReview.Rating = TestData;
            Assert.AreEqual(AReview.Rating, TestData);
        }



        [TestMethod]

        public void CommentPropertyOK()
        {
            clsReview AReview = new clsReview();
            String TestData = "Comments can be longer.";
            AReview.Comment = TestData;
            Assert.AreEqual(AReview.Comment, TestData);
        }




        [TestMethod]

        public void DatePostedPropertyOK()
        {
            clsReview AReview = new clsReview();
            DateTime TestData = DateTime.Now.Date;
            AReview.DatePosted = TestData;
            Assert.AreEqual(AReview.DatePosted, TestData);
        }



        [TestMethod]

        public void RecentPropertyOK()
        {
            clsReview AReview = new clsReview();
            Boolean TestData = true;
            AReview.Recent = TestData;
            Assert.AreEqual(AReview.Recent, TestData);
        }

    }
}
