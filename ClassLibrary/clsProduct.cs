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



        public bool Find(int productID)
        {
            mProductID = 5;
            mTitle = "ProductName";
            mDescription = "Description1234";
            mPrice = 5.50;
            mCondition = "Good";
            mAvailability = true;
            mDateListed = Convert.ToDateTime("24/08/2024");
            return true;
        }
    }
}
