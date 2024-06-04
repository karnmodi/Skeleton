using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class clsCart
    {
        private int mQuantity;
        private DateTime mDateAdded;
        private bool mActive;
        private int mTotalPrice;
        private String mCartDiscription;
        private int mCartID;

        public int Quantity
        {
            get
            {
                return mQuantity;
            }
            set
            {
                mQuantity = value;
            }
        }
        public DateTime DateAdded
        {
            get
            { 
            return mDateAdded;
            }
            set 
            {
            mDateAdded = value;
            }
        }
        public bool Active
        {
            get
            {
                return mActive;
            }
            set
            {  mActive = value; }
        }
        public int TotalPrice
        {
            get
            { return mTotalPrice;
            }
            set
            {
                mTotalPrice = value;
            }
        }
        public string CartDiscription
        {
            get
            {
                return mCartDiscription;
            }
            set
            {
                mCartDiscription = value;
            }
        }
        public int CartID
        {
            get
            {
                return mCartID;
            }
            set
            {
                mCartID = value;
            }
        }

        public bool Find(int CartID)
        {
          clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CartID",CartID);
            DB.Execute("stpr_tblCart_FilterByCartID");
            if (DB.Count == 1)
            {
                mCartID = Convert.ToInt32(DB.DataTable.Rows[0]["CartID"]);
                mTotalPrice = Convert.ToInt32(DB.DataTable.Rows[0]["TotalPrice"]);
                mCartDiscription = Convert.ToString(DB.DataTable.Rows[0]["CartDiscription"]);
                mQuantity = Convert.ToInt32(DB.DataTable.Rows[0]["Quantity"]);
                mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAdded"]);
                mActive = Convert.ToBoolean(DB.DataTable.Rows[0]["Active"]);
                return true;

                
            }
            else
            {
                return false;
            }
                
        }

        public string Valid(string cartDescription, string totalPrice, string quantity, string dateAdded, string active)
        {
            String Error = "";
            Int32 sampleQuantity;
            Int32 samplePrice;
            DateTime sampleDate;
            if (cartDescription.Length == 0)
            {
                Error += "Cart Description must not be empty.";
            }
            if (cartDescription.Length > 100)
            {
                Error += "Cart Description must be less than 100";
            }

            try
            {
                sampleQuantity = Convert.ToInt32(quantity);
                if (sampleQuantity == 0)
                {
                    Error += "Quantity must not be zero.";
                }
                if (sampleQuantity < 0)
                {
                    Error += "Quantity must not be in negative format.";
                }
                if (sampleQuantity > 10000)
                {
                    Error += "Quantity must not be more than 10000";
                }
            }
            catch
            {
                Error += "Quantity is not in correct format.";
            }

            try
            {
                samplePrice = Convert.ToInt32(totalPrice);
                if (samplePrice == 0)
                {
                    Error += "Total Price must not be zero.";
                }
                if (samplePrice < 0)
                {
                    Error += "Total Price must not be in negative format.";
                }
                if (samplePrice > 15000)
                {
                    Error += "Total Price must not be more than 15000.";
                }
            }
            catch
            {
                Error += "Total Price is not in correct format.";
            }


            try
            {
                sampleDate = Convert.ToDateTime(dateAdded);
                
                if (sampleDate < DateTime.Now.Date)
                {
                    Error += "Date must not be in the past.";
                }
                if (sampleDate > DateTime.Now.Date)
                {
                    Error += "Date must not be in the Future.";
                }
            }
            catch
            {
                Error += "Added Date is not in the proper format.";
            }

            return Error;
        }
    }
}
