using System;

namespace ClassLibrary
{
    public class clsUserAdmin
    {

        private Int32 mAdminID;
        private String mUsername;
        private String mPassword;
        private String mDepartment;

        public int AdminID
        {
            get
            {
                return mAdminID;
            }
            set
            {
                mAdminID = value;
            }
        }
        
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

        public string Department
        {
            get
            {
                return mDepartment;
            }
            set
            {
                mDepartment = value;
            }
        }

        public bool FindAdmin(string Username, string Password)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@Username", Username);
            DB.AddParameter("@Password", Password);

            DB.Execute("stpr_tblAdmin_FindUsernamePW");

            if (DB.Count == 1)
            {
                mAdminID = Convert.ToInt32(DB.DataTable.Rows[0]["AdminID"]);
                mUsername = Convert.ToString(DB.DataTable.Rows[0]["AdminName"]);
                mPassword = Convert.ToString(DB.DataTable.Rows[0]["Password"]);
                mDepartment = Convert.ToString(DB.DataTable.Rows[0]["Department"]);

                return true;
            }
            else
            {
                return false;
            }
        }
    }
}