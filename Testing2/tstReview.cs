using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibrary;
using System.Diagnostics;

namespace Testing5
{
    [TestClass]
    public class tstReview
    {

        string Category = "Product A";
        string Rating = "2";
        string Comment = "Good value for money.";
        string DateAdded = DateTime.Now.Date.ToString();
        bool Recent = false;



        [TestMethod]
        public void ValidMethodOK()
        {
            clsReview AReview = new clsReview();
            String Error = "";
            Error = AReview.Valid(Category, Rating, Comment, DateAdded, Recent);
            Assert.AreEqual(Error, "");
        }



        [TestMethod]
        public void CategoryMinLessOne()
        {
            clsReview AReview = new clsReview();
            String Error = "";
            String Category = "";
            Error = AReview.Valid(Category, Rating, Comment, DateAdded, Recent);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void CategoryMin()
        {
            clsReview AReview = new clsReview();
            String Error = "";
            String Category = "C";
            Error = AReview.Valid(Category, Rating, Comment, DateAdded, Recent);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void CategoryMinPlusOne()
        {
            clsReview AReview = new clsReview();
            String Error = "";
            String Category = "CC";
            Error = AReview.Valid(Category, Rating, Comment, DateAdded, Recent);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void CategoryMaxLessOne()
        {
            clsReview AReview = new clsReview();
            String Error = "";
            String Category = "";
            Category = Category.PadRight(49 ,'C');
            Error = AReview.Valid(Category, Rating, Comment, DateAdded, Recent);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CategoryMax()
        {
            clsReview AReview = new clsReview();
            String Error = "";
            String Category = "";
            Category = Category.PadRight(50, 'C');
            Error = AReview.Valid(Category, Rating, Comment, DateAdded, Recent);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void CategoryMaxPlusOne()
        {
            clsReview AReview = new clsReview();
            String Error = "";
            String Category = "";
            Category = Category.PadRight(51, 'C');
            Error = AReview.Valid(Category, Rating, Comment, DateAdded, Recent);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CategoryMid()
        {
            clsReview AReview = new clsReview();
            String Error = "";
            String Category = "";
            Category = Category.PadRight(25, 'C');
            Error = AReview.Valid(Category, Rating, Comment, DateAdded, Recent);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void CategoryExtremeMAX()
        {
            clsReview AReview = new clsReview();
            String Error = "";
            String Category = "";
            Category = Category.PadRight(500, 'C');
            Error = AReview.Valid(Category, Rating, Comment, DateAdded, Recent);
            Assert.AreEqual(Error, "");
        }



        [TestMethod]
        public void RatingExtremeMin()
        {
            clsReview AReview = new clsReview();
            String Error = "";
            Int32 value = -500;
            string Rating = Convert.ToString(value);
            Error = AReview.Valid(Category, Rating, Comment, DateAdded, Recent);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void RatingMinLessOne()
        {
            clsReview AReview = new clsReview();
            String Error = "";
            Int32 value = 0;
            string Rating = Convert.ToString(value);
            Error = AReview.Valid(Category, Rating, Comment, DateAdded, Recent);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void RatingMin()
        {
            clsReview AReview = new clsReview();
            String Error = "";
            Int32 value = 1;
            string Rating = Convert.ToString(value);
            Error = AReview.Valid(Category, Rating, Comment, DateAdded, Recent);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void RatingMinPlusOne()
        {
            clsReview AReview = new clsReview();
            String Error = "";
            Int32 value = 2;
            string Rating = Convert.ToString(value);
            Error = AReview.Valid(Category, Rating, Comment, DateAdded, Recent);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void RatingMaxLessOne()
        {
            clsReview AReview = new clsReview();
            String Error = "";
            Int32 value = 9;
            string Rating = Convert.ToString(value);
            Error = AReview.Valid(Category, Rating, Comment, DateAdded, Recent);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void RatingMax()
        {
            clsReview AReview = new clsReview();
            String Error = "";
            Int32 value = 10;
            string Rating = Convert.ToString(value);
            Error = AReview.Valid(Category, Rating, Comment, DateAdded, Recent);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void RatingMaxPlusOne()
        {
            clsReview AReview = new clsReview();
            String Error = "";
            Int32 value = 11;
            string Rating = Convert.ToString(value);
            Error = AReview.Valid(Category, Rating, Comment, DateAdded, Recent);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void RatingMid()
        {
            clsReview AReview = new clsReview();
            String Error = "";
            Int32 value = 5;
            string Rating = Convert.ToString(value);
            Error = AReview.Valid(Category, Rating, Comment, DateAdded, Recent);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void RatingExtremeMAX()
        {
            clsReview AReview = new clsReview();
            String Error = "";
            Int32 value = 500;
            string Rating = Convert.ToString(value);
            Error = AReview.Valid(Category, Rating, Comment, DateAdded, Recent);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void RatingInvalidData()
        {
            clsReview AReview = new clsReview();
            string Error = "";
            string Rating = "5000sd";
            Error = AReview.Valid(Category, Rating, Comment, DateAdded, Recent);
            Assert.AreEqual(Error, "");
        }





        [TestMethod]
        public void DatePostedExtremeMin()
        {
            clsReview AReview = new clsReview();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);
            String DateAdded = TestDate.ToString();
            Error = AReview.Valid(Category, Rating, Comment, DateAdded, Recent);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DatePostedMinLessOne()
        {
            clsReview AReview = new clsReview();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(-1);
            String DateAdded = TestDate.ToString();
            Error = AReview.Valid(Category, Rating, Comment, DateAdded, Recent);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void DatePostedMin()
        {
            clsReview AReview = new clsReview();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            String DateAdded = TestDate.ToString();
            Error = AReview.Valid(Category, Rating, Comment, DateAdded, Recent);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void DatePostedMinPlusOne()
        {
            clsReview AReview = new clsReview();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(1);
            String DateAdded = TestDate.ToString();
            Error = AReview.Valid(Category, Rating, Comment, DateAdded, Recent);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void DatePostedExtremeMAX()
        {
            clsReview AReview = new clsReview();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(100);
            String DateAdded = TestDate.ToString();
            Error = AReview.Valid(Category, Rating, Comment, DateAdded, Recent);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void DatePostedInvalidFormat()
        {
            clsReview AReview = new clsReview();
            String Error = "";
            String DateAdded = "This is not a DATE";
            Error = AReview.Valid(Category, Rating, Comment, DateAdded, Recent);
            Assert.AreEqual(Error, "");
        }





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






        [TestMethod]
        public void FindMethodOK()
        {
            clsReview AReview = new clsReview();
            Boolean Found = false;
            Int32 ReviewID = 2;
            Found = AReview.Find(ReviewID);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestReviewIDFound()
        {
            clsReview AReview = new clsReview();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ReviewID = 2;

            Found = AReview.Find(ReviewID);
            if (AReview.ReviewID != 2)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCategoryFound()
        {
            clsReview AReview = new clsReview();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ReviewID = 2;

            Found = AReview.Find(ReviewID);
            if (AReview.Category != "Product B")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestRatingFound()
        {
            clsReview AReview = new clsReview();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ReviewID = 2;

            Found = AReview.Find(ReviewID);
            if (AReview.Rating != 4)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestCommentFound()
        {
            clsReview AReview = new clsReview();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ReviewID = 2;

            Found = AReview.Find(ReviewID);
            if (AReview.Comment != "Good value for money.")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestDatePostedFound()
        {
            clsReview AReview = new clsReview();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ReviewID = 2;

            Found = AReview.Find(ReviewID);
            if (AReview.DatePosted != DateTime.Now.Date)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestRecentFound()
        {
            clsReview AReview = new clsReview();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ReviewID = 2;

            Found = AReview.Find(ReviewID);
            if (AReview.Recent != false)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

    }
}
