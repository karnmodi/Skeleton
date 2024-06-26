﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class clsUser
    {
        private string mUsername;
        private string mEmail;
        private string mPassword;
        private string mAddress;
        private string mPhone;
        private Boolean mActive;
        private DateTime mDateAdded;
        private int mUserID;

        public string Username
        {
            get
            {
                return mUsername;
            }
            set
            {
                mUsername = value;
            }
        }

        public string Email 
        {
            get
            {
                return mEmail;
            }
            set 
            { 
                mEmail = value; 
            }
        }

        public string Password 
        { 
            get
            {
                return mPassword;
            }
            set 
            { 
                mPassword = value; 
            }
        }

        public string Address 
        {
            get
            {
                return mAddress;
            }
            set
            {
                mAddress = value;
            }
        }

        public string Phone
        {
            get
            {
                return mPhone;
            }
            set
            {
                mPhone = value;
            }
        }

        public Boolean Active
        {
            get
            {
                return mActive;
            }
            set
            {
                mActive = value;
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


        public int UserID
        {
            get
            {
                return mUserID;
            }
            set
            {
                mUserID = value;
            }
        }

        public bool Find(int UserID)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@UserID", UserID);
            DB.Execute("stpr_tblUser_FilterByUserID");
            if (DB.Count == 1)
            {
                mUserID = Convert.ToInt32(DB.DataTable.Rows[0]["UserID"]);
                mUsername = Convert.ToString(DB.DataTable.Rows[0]["Username"]);
                mEmail = Convert.ToString(DB.DataTable.Rows[0]["Email"]);
                mPassword = Convert.ToString(DB.DataTable.Rows[0]["Password"]);
                mAddress = Convert.ToString(DB.DataTable.Rows[0]["Address"]);
                mPhone = Convert.ToString(DB.DataTable.Rows[0]["PhoneNumber"]);
                mActive = Convert.ToBoolean(DB.DataTable.Rows[0]["Active"]);
                mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAdded"]);

                return true;
            }
            else
            {
                return false;
            }
        }

        public string Valid(string username, string email, string password, string address, string phoneNumber, string dateAdded)
        {
            String Error = "";
            DateTime mDate;

            if(username.Length <= 0)
            {
                Error += "Username cant be empty.";
            }
            if(username.Length >= 51)
            {
                Error += "Username Must be lesser than 50 Characters.";
            }
            if (email.Length <= 0)
            {
                Error += "Email cant be empty.";
            }
            if (email.Length >= 31)
            {
                Error += "Email Must be lesser than 30 Characters.";
            }
            if (password.Length <= 0)
            {
                Error += "Password cant be empty.";
            }
            if (password.Length >= 51)
            {
                Error += "Password Must be lesser than 30 Characters.";
            }
            if (address.Length <= 0)
            {
                Error += "Address cant be empty.";
            }
            if (address.Length >= 251)
            {
                Error += "Address Must be lesser than 250 Characters.";
            }
            if (phoneNumber.Length < 6)
            {
                Error += "Smallest Phone number would be 6 digit Long.";
            }
            if(phoneNumber.Length >= 16)
            {
                Error += "Phone Number must be smaller than or 15 Digits.";
            }

            try
            {
                mDate = Convert.ToDateTime(dateAdded);
                if(mDate > DateTime.Now.Date)
                {
                    Error += "Date cant be in the future.";
                }
                if(mDate < DateTime.Now.Date)
                {
                    Error += "Date cant be in the Past.";
                }
            }
            catch
            {
                Error += "Invalid Data type entered for DAte.";
            }
            return Error;
        }
    }
}
