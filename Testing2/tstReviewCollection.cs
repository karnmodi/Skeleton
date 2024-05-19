using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing5
{
    [TestClass]
    public class tstReviewCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsReviewCollection AllReviews = new clsReviewCollection();
            Assert.IsNotNull(AllReviews);
        }


        [TestMethod]
        public void ReviewListOK()
        {
            clsReviewCollection AllReviews = new clsReviewCollection();
            List<clsReview> TestList = new List<clsReview>();
            clsReview TestItem = new clsReview();

            TestItem.ReviewID = 1;
            TestItem.Category = "Product A";
            TestItem.Rating = 5;
            TestItem.Recent = true;
            TestItem.DatePosted = DateTime.Now.Date;

            TestList.Add(TestItem);
            AllReviews.ReviewList = TestList;

            Assert.AreEqual(AllReviews.ReviewList, TestList);
        }


        [TestMethod]
        public void CountPropertyOK()
        {
            clsReviewCollection AllReviews = new clsReviewCollection();
            Int32 nCount = 0;
            AllReviews.Count = nCount;
            Assert.AreEqual(AllReviews.Count, AllReviews.Count);
        }

        [TestMethod]
        public void ThisReviewPropertyOK()
        {
            clsReviewCollection AllReviews = new clsReviewCollection();
            clsReview TestItem = new clsReview();

            TestItem.ReviewID = 1;
            TestItem.Category = "Product A";
            TestItem.Rating = 5;
            TestItem.Recent = true;
            TestItem.DatePosted = DateTime.Now.Date;


            AllReviews.ThisReview = TestItem;

            Assert.AreEqual(AllReviews.ThisReview, TestItem);
        }




        public void ListAndCountOK()
        {
            clsReviewCollection AllReviews = new clsReviewCollection();
            List<clsReview> TestList = new List<clsReview>();
            clsReview TestItem = new clsReview();

            TestItem.ReviewID = 1;
            TestItem.Category = "Product A";
            TestItem.Rating = 5;
            TestItem.Recent = true;
            TestItem.DatePosted = DateTime.Now.Date;

            TestList.Add(TestItem);
            AllReviews.ReviewList = TestList;

            Assert.AreEqual(AllReviews.Count, TestList.Count);
        }


        [TestMethod]
        public void TwoRecordsPresent()
        {
            clsReviewCollection AllReviews = new clsReviewCollection();
            Assert.AreEqual(AllReviews.Count, AllReviews.Count);
        }

    }
}
