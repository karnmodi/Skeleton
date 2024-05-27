using System;

namespace ClassLibrary
{
    public class clsProductAdmin
    {

        private Int32 mAdminID;
        private String mAdminName;
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
        
        public string AdminName
        {
            get
            {
                return mAdminName;
            }
            set
            {
                mAdminName = value;
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

        public bool FindAdmin(string adminName, string password)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@AdminName", adminName);
            DB.AddParameter("password", password);

            DB.Execute("stpr_tblAdmin_FindAdminNamePW");

            if (DB.Count == 1)
            {
                mAdminID = Convert.ToInt32(DB.DataTable.Rows[0]["AdminID"]);
                mAdminName = Convert.ToString(DB.DataTable.Rows[0]["AdminName"]);
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