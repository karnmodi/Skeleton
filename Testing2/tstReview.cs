using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibrary;
using System.Diagnostics;
using System.Net;

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
            Assert.AreEqual(Error, "Category cant be empty.");
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
            Assert.AreEqual(Error, "Category Cant be More than 50");
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
            Category = Category.PadRight(50000, 'C');
            Error = AReview.Valid(Category, Rating, Comment, DateAdded, Recent);
            Assert.AreEqual(Error, "Category Cant be More than 50");
        }



        [TestMethod]
        public void CommentMinLessOne()
        {
            clsReview AReview = new clsReview();
            String Error = "";
            String Comment = "";
            Error = AReview.Valid(Category, Rating, Comment, DateAdded, Recent);
            Assert.AreEqual(Error, "Comment cant be empty.");
        }


        [TestMethod]
        public void CommentMin()
        {
            clsReview AReview = new clsReview();
            String Error = "";
            String Comment = "C";
             Error = AReview.Valid(Category, Rating, Comment, DateAdded, Recent);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void CommentMinPlusOne()
        {
            clsReview AReview = new clsReview();
            String Error = "";
            String Comment = "CC";
             Error = AReview.Valid(Category, Rating, Comment, DateAdded, Recent);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void CommentMaxLessOne()
        {
            clsReview AReview = new clsReview();
            String Error = "";
            String Comment = "";
            Comment = Comment.PadRight(199, 'C');
             Error = AReview.Valid(Category, Rating, Comment, DateAdded, Recent);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CommentMax()
        {
            clsReview AReview = new clsReview();
            String Error = "";
            String Comment = "";
            Comment = Comment.PadRight(200, 'C');
             Error = AReview.Valid(Category, Rating, Comment, DateAdded, Recent);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void CommentMaxPlusOne()
        {
            clsReview AReview = new clsReview();
            String Error = "";
            String Comment = "";
            Comment = Comment.PadRight(201, 'C');
             Error = AReview.Valid(Category, Rating, Comment, DateAdded, Recent);
            Assert.AreEqual(Error, "Comment Cant be More than 200");
        }

        [TestMethod]
        public void CommentMid()
        {
            clsReview AReview = new clsReview();
            String Error = "";
            String Comment = "";
            Comment = Comment.PadRight(100, 'C');
             Error = AReview.Valid(Category, Rating, Comment, DateAdded, Recent);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void CommentExtremeMAX()
        {
            clsReview AReview = new clsReview();
            String Error = "";
            String Comment = "";
            Comment = Comment.PadRight(50000, 'C');
             Error = AReview.Valid(Category, Rating, Comment, DateAdded, Recent);
            Assert.AreEqual(Error, "Comment Cant be More than 200");
        }


        [TestMethod]
        public void RatingExtremeMin()
        {
            clsReview AReview = new clsReview();
            String Error = "";
            Int32 value = -500;
            string Rating = Convert.ToString(value);
            Error = AReview.Valid(Category, Rating, Comment, DateAdded, Recent);
            Assert.AreEqual(Error, "Rating should neither be negative nor zero.");
        }

        [TestMethod]
        public void RatingMinLessOne()
        {
            clsReview AReview = new clsReview();
            String Error = "";
            Int32 value = 0;
            string Rating = Convert.ToString(value);
            Error = AReview.Valid(Category, Rating, Comment, DateAdded, Recent);
            Assert.AreEqual(Error, "Rating should neither be negative nor zero.");
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
            Assert.AreEqual(Error, "Rating should be less than 10 or equal to 10.");
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
            Assert.AreEqual(Error, "Rating should be less than 10 or equal to 10.");
        }

        [TestMethod]
        public void RatingInvalidData()
        {
            clsReview AReview = new clsReview();
            string Error = "";
            string Rating = "Ten";
            Error = AReview.Valid(Category, Rating, Comment, DateAdded, Recent);
            Assert.AreEqual(Error, "Rating is not in the proper format; it must be an integer.");
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
            Assert.AreEqual(Error, "Date must not be in the past.");
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
            Assert.AreEqual(Error, "Date must not be in the past.");
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
            Assert.AreEqual(Error, "Date must not be in the Future.");
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
            Assert.AreEqual(Error, "Date must not be in the Future.");
        }


        [TestMethod]
        public void DatePostedInvalidFormat()
        {
            clsReview AReview = new clsReview();
            String Error = "";
            String DateAdded = "This is not a DATE";
            Error = AReview.Valid(Category, Rating, Comment, DateAdded, Recent);
            Assert.AreEqual(Error, "DatePosted is not in the proper format; it must be a DATE (DD/MM/YYYY).");
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
            String TestData = "name1";
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
            if (AReview.DatePosted != Convert.ToDateTime("19-05-2024"))
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
