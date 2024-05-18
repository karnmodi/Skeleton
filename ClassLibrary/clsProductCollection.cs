using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class clsProductCollection
    {

        public clsProductCollection() 
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;
            clsDataConnection  DB = new clsDataConnection();
            DB.Execute("stpr_AllProducts");
            RecordCount = DB.Count;

            while(Index < RecordCount)
            {
                clsProduct AProduct = new clsProduct();

                AProduct.ProductID = Convert.ToInt32(DB.DataTable.Rows[Index]["ProductID"]);
                AProduct.Title = Convert.ToString(DB.DataTable.Rows[Index]["Title"]);
                AProduct.Description = Convert.ToString(DB.DataTable.Rows[Index]["Description"]);
                AProduct.Price = Convert.ToDouble(DB.DataTable.Rows[Index]["Price"]);
                AProduct.Condition = Convert.ToString(DB.DataTable.Rows[Index]["Condition"]);
                AProduct.Availability  = Convert.ToBoolean(DB.DataTable.Rows[Index]["Availability"]);
                AProduct.DateListed = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateListed"]);

                mProductList.Add(AProduct);
                Index++;
            }
        }


        List<clsProduct> mProductList = new List<clsProduct>();
        public List<clsProduct> ProductList 
        { 
            get 
            { 
                return mProductList; 
            }
            set 
            { 
                mProductList = value; 
            }
        }
        public int Count 
        {
            get
            {
                return mProductList.Count;
            }
            set
            {

            }
        }

        public clsProduct ThisProduct { get; set; }
    }
}
