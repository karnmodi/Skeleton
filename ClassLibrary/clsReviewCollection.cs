using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class clsReviewCollection
    {
        List<clsReview> mReviewList = new List<clsReview>();
        clsReview mThisReview = new clsReview();
        public List<clsReview> ReviewList
        {
            get
            {
                return mReviewList;
            }
            set
            {
                mReviewList = value;
            }
        }
        public int Count
        {
            get
            {
                return mReviewList.Count;
            }
            set
            {
                
            }
        }
        public clsReview ThisReview
        {
            get
            {
                return mThisReview;
            }
            set
            {
                mThisReview = value;
            }
        }


        public clsReviewCollection()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("stpr_AllReviews");
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount;
            RecordCount = DB.Count;
            mReviewList = new List<clsReview>();
            while (Index < RecordCount)
            {
                clsReview AReview = new clsReview();
                AReview.ReviewID = Convert.ToInt32(DB.DataTable.Rows[Index]["ReviewID"]);
                AReview.Category = Convert.ToString(DB.DataTable.Rows[Index]["Category"]);
                AReview.Rating = Convert.ToInt32(DB.DataTable.Rows[Index]["Rating"]);
                AReview.Comment = Convert.ToString(DB.DataTable.Rows[Index]["Comment"]);
                AReview.Recent = Convert.ToBoolean(DB.DataTable.Rows[Index]["Recent"]);
                AReview.DatePosted = Convert.ToDateTime(DB.DataTable.Rows[Index]["DatePosted"]);
                mReviewList.Add(AReview);
                Index++;
            }
        }

        public void ReportByReviewComment(string ReviewComment)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@Comment", ReviewComment);
            DB.Execute("stpr_tblReview_FilterByReviewComment");
            PopulateArray(DB);
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@Category", mThisReview.Category);
            DB.AddParameter("@Rating", mThisReview.Rating);
            DB.AddParameter("@Comment", mThisReview.Comment);
            DB.AddParameter("@DatePosted", mThisReview.DatePosted);
            DB.AddParameter("@Recent", mThisReview.Recent);

            return DB.Execute("stpr_tblReview_Insert");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ReviewID", mThisReview.ReviewID);
            DB.AddParameter("@Category", mThisReview.Category);
            DB.AddParameter("@Rating", mThisReview.Rating);
            DB.AddParameter("@Comment", mThisReview.Comment);
            DB.AddParameter("@DatePosted", mThisReview.DatePosted);
            DB.AddParameter("@Recent", mThisReview.Recent);

            DB.Execute("stpr_tblReview_Update");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ReviewID", mThisReview.ReviewID);
            DB.Execute("stpr_tblReview_Delete");
        }
    }
}
