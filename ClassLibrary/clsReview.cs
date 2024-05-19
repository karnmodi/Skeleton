using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class clsReview
    {

        private int mReviewID;
        private String mCategory;
        private Int32 mRating;
        private String mComment;
        private DateTime mDatePosted;
        private Boolean mRecent;

        public int ReviewID
        {
            get
            {
                return mReviewID;
            }
            set
            {
                mReviewID = value;
            }
        }

        public string Category
        {
            get
            {
                return mCategory;
            }
            set
            {
                mCategory = value;
            }
        }
        public int Rating
        {
            get
            {
                return mRating;
            }
            set
            {
                mRating = value;
            }
        }

        public string Comment
        {
            get
            {
                return mComment;
            }
            set
            {
                mComment = value;
            }
        }

        public DateTime DatePosted
        {
            get
            {
                return mDatePosted;
            }
            set
            {
                mDatePosted = value;
            }
        }

        public bool Recent
        {
            get
            {
                return mRecent;
            }
            set
            {
                mRecent = value;
            }
        }

        public bool Find(int ReviewID)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ReviewID", ReviewID);
            DB.Execute("stpr_tblReview_FilterByReviewID");
            if (DB.Count == 1)
            {
                mReviewID = Convert.ToInt32(DB.DataTable.Rows[0]["ReviewID"]);
                mComment = Convert.ToString(DB.DataTable.Rows[0]["Comment"]);
                mCategory = Convert.ToString(DB.DataTable.Rows[0]["Category"]);
                mRating = Convert.ToInt32(DB.DataTable.Rows[0]["Rating"]);
                mDatePosted = Convert.ToDateTime(DB.DataTable.Rows[0]["DatePosted"]);
                mRecent = Convert.ToBoolean(DB.DataTable.Rows[0]["Recent"]);


                return true;
            }
            else
            {
                return false;
            }
        }

        public string Valid(string category, string rating, string comment, string dateAdded, bool recent)
        {
            String Error = "";
            Int32 CheckRating = 0;
            DateTime CheckDate;

            if(category.Length == 0)
            {
                Error = Error + "Category cant be empty.";
            }
            if(category.Length >= 51)
            {
                Error = Error + "Category Cant be More than 50";
            }

            try
            {
                CheckRating = Convert.ToInt32(rating);
                if (CheckRating <= 0)
                {
                    Error = Error + "Rating should neither be negative nor zero.";
                }
                if (CheckRating >= 11)
                {
                    Error = Error + "Rating should be less than 10 or equal to 10.";
                }
            }
            catch
            {
                Error = Error + "Rating is not in the proper format; it must be an integer.";
            }

            try
            {
                CheckDate = Convert.ToDateTime(dateAdded);
                if (CheckDate < DateTime.Now.Date)
                {
                    Error = Error + "Date must not be in the past.";
                }
                if (CheckDate > DateTime.Now.Date)
                {
                    Error = Error + "Date must not be in the Future.";
                }
            }
            catch
            {
                Error = Error + "DatePosted is not in the proper format; it must be a DATE (DD/MM/YYYY).";
            }
            return Error;

        }
    }
}
