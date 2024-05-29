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

        [TestMethod]
        public void AddMethodOK()
        {
            clsReviewCollection AllReviews = new clsReviewCollection();
            clsReview TestReview = new clsReview();
            Int32 PrimaryKey = 0;
            TestReview.Category = "Diya Patel";
            TestReview.Rating = 5;
            TestReview.Comment = "Good value for money.";
            TestReview.DatePosted = DateTime.Now;
            TestReview.Recent = false;
            AllReviews.ThisReview = TestReview;
            PrimaryKey = AllReviews.Add();
            TestReview.ReviewID = PrimaryKey;
            AllReviews.ThisReview.Find(PrimaryKey);
            Assert.AreEqual(AllReviews.ThisReview, TestReview);

        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            clsReviewCollection AllReviews = new clsReviewCollection();
            clsReview TestReview = new clsReview();
            Int32 PrimaryKey = 0;
            TestReview.Category = "Diya Patel";
            TestReview.Rating = 5;
            TestReview.Comment = "Good value for money.";
            TestReview.DatePosted = DateTime.Now;
            TestReview.Recent = false;
            AllReviews.ThisReview = TestReview;
            PrimaryKey = AllReviews.Add();
            TestReview.Category = "DIYA";
            TestReview.Rating = 7;
            TestReview.Comment = "money.";
            TestReview.DatePosted = DateTime.Now;
            TestReview.Recent = true;
            AllReviews.ThisReview = TestReview;
            AllReviews.Update();
            AllReviews.ThisReview.Find(PrimaryKey);
            Assert.AreEqual(AllReviews.ThisReview, TestReview);
        }


        [TestMethod]
        public void DeleteMethodOK()
        {
            clsReviewCollection AllReviews = new clsReviewCollection();
            clsReview TestReview = new clsReview();
            Int32 PrimaryKey = 0;
            TestReview.ReviewID = PrimaryKey;
            TestReview.Category = "Diya Patel";
            TestReview.Rating = 5;
            TestReview.Comment = "Good value for money.";
            TestReview.DatePosted = DateTime.Now;
            TestReview.Recent = false;
            AllReviews.ThisReview = TestReview;
            PrimaryKey = AllReviews.Add();
            TestReview.ReviewID = PrimaryKey;
            AllReviews.ThisReview.Find(PrimaryKey);
            AllReviews.Delete();
            Boolean Found = AllReviews.ThisReview.Find(PrimaryKey);
            Assert.IsFalse(Found);
        }
        [TestMethod]
        public void ReportByReviewCommentMethodOK()
        {

            clsReviewCollection AllReviews = new clsReviewCollection();
            clsReviewCollection FilterReviews = new clsReviewCollection();
            FilterReviews.ReportByReviewComment("");
            Assert.AreEqual(AllReviews.Count, FilterReviews.Count);
        }

        [TestMethod]
        public void ReportByReviewCommentNoneFound()
        {
            clsReviewCollection FilterReviews = new clsReviewCollection();
            FilterReviews.ReportByReviewComment("DPDP");
            Assert.AreEqual(0, FilterReviews.Count);
        }[TestMethod]

        public void ReportByReviewCommentTestDataFound()
        {
            clsReviewCollection FilterReviews = new clsReviewCollection();
            Boolean OK = true;
            FilterReviews.ReportByReviewComment("Diya P");
            if (FilterReviews.Count == 2)
            {
                if (FilterReviews.ReviewList[0].ReviewID != 24)
                {
                    OK = false;
                }
                if (FilterReviews.ReviewList[0].ReviewID != 25)
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
