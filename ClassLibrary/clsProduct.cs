using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class clsProduct
    {
        private int mProductID;
        public int ProductID {

            get
            {
                return mProductID;
            }

            set
            {
                mProductID = value;
            }
                
        }



        private String mTitle;
        public string Title
        {

            get
            {
                return mTitle;
            }

            set
            {
                mTitle = value;
            }

        }


        private String mDescription;
        public string Description
        {

            get
            {
                return mDescription;
            }

            set
            {
                mDescription = value;
            }

        }



        private Double mPrice;
        public Double Price
        {

            get
            {
                return mPrice;
            }

            set
            {
                mPrice = value;
            }

        }



        private String mCondition;
        public string Condition
        {

            get
            {
                return mCondition;
            }

            set
            {
                mCondition = value;
            }

        }



        private bool mAvailability;
        public bool Availability
        {

            get
            {
                return mAvailability;
            }

            set
            {
                mAvailability = value;
            }

        }


        private DateTime mDateListed;
        public DateTime DateListed
        {

            get
            {
                return mDateListed;
            }

            set
            {
                mDateListed = value;
            }

        }



        public bool Find(int ProductID)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ProductID", ProductID);
            DB.Execute("stpr_tblProduct_FilterbyProductID");

            if(DB.Count == 1)
            {
                mProductID = Convert.ToInt32(DB.DataTable.Rows[0]["ProductID"]);
                mTitle = Convert.ToString(DB.DataTable.Rows[0]["Title"]);
                mDescription = Convert.ToString(DB.DataTable.Rows[0]["Description"]);
                mPrice = Convert.ToDouble(DB.DataTable.Rows[0]["Price"]);
                mCondition = Convert.ToString(DB.DataTable.Rows[0]["Condition"]);
                mAvailability = Convert.ToBoolean(DB.DataTable.Rows[0]["Availability"]);
                mDateListed= Convert.ToDateTime(DB.DataTable.Rows[0]["DateListed"]);
                return true;
            
            }

            else
            {
                return false;
            }
        }
    }
}
