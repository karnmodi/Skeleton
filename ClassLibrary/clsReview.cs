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
    }
}
