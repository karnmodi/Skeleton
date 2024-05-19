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
    }
}
