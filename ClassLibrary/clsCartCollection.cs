using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsCartCollection
    {
        List<clsCart> mCartList = new List<clsCart>();
        clsCart mThisCart = new clsCart();


        public  clsCartCollection()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("stpr_AllCarts");
            PopulateArray(DB);

        }


        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount;
            
            RecordCount = DB.Count;
            mCartList = new List<clsCart>();
            while (Index < RecordCount)
            {
                clsCart ACart = new clsCart();
                ACart.CartID = Convert.ToInt32(DB.DataTable.Rows[Index]["CartID"]);
                ACart.TotalPrice = Convert.ToInt32(DB.DataTable.Rows[Index]["TotalPrice"]);
                ACart.CartDiscription = Convert.ToString(DB.DataTable.Rows[Index]["CartDiscription"]);
                ACart.Quantity = Convert.ToInt32(DB.DataTable.Rows[Index]["Quantity"]);
                ACart.Active = Convert.ToBoolean(DB.DataTable.Rows[Index]["Active"]);
                ACart.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateAdded"]);
                mCartList.Add(ACart);
                Index++;
            }
        }


        public List<clsCart> CartList
        {
            get
            {
                return mCartList;
            }
            set
            {
                mCartList = value;
            }
        }

        public int Count
        {
            get
            {
                return mCartList.Count;
            }
            set { }
        }
        public clsCart ThisCart
        {
            get
            {
                return mThisCart;
            }

            set
            {
                mThisCart = value;
            }
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CartDiscription", mThisCart.CartDiscription);
            DB.AddParameter("@TotalPrice", mThisCart.TotalPrice);
            DB.AddParameter("@Quantity", mThisCart.Quantity);
            DB.AddParameter("@DateAdded", mThisCart.DateAdded);
            DB.AddParameter("@Active", mThisCart.Active);
            return DB.Execute("stpr_tblCart_Insert");
        }

        public void Delete()
        {
            

            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CartID", mThisCart.CartID);
            DB.Execute("stpr_tblCart_Delete");
        }

        public void ReportByCartDescription(string CartDescription)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CartDescription", CartDescription);
            DB.Execute("stpr_tblCart_FilterByCartDescription");
            PopulateArray(DB);
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CartID", mThisCart.CartID);
            DB.AddParameter("@CartDiscription", mThisCart.CartDiscription);
            DB.AddParameter("@TotalPrice", mThisCart.TotalPrice);
            DB.AddParameter("@Quantity", mThisCart.Quantity);
            DB.AddParameter("@DateAdded", mThisCart.DateAdded);
            DB.AddParameter("@Active", mThisCart.Active);
            DB.Execute("stpr_tblCart_Update");
        }
    }
}