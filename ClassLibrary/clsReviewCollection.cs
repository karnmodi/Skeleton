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
        public clsReview ThisReview { get; set; }


        public clsReviewCollection()
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("stpr_AllReviews");
            RecordCount = DB.Count;

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
    }
}
