using System;

namespace ClassLibrary
{
    public class clsCartAdmin
    {

        private int mAdminID;
        private string mUsername;
        private string mPassword;
        private string mDepartment;


        public int AdminID
        {
            get { return mAdminID; }
            set { mAdminID = value; }
        }
        public string Username
        {
            get { return mUsername; }
            set { mUsername = value; }
        }
        public string Password
        {
            get { return mPassword; }
                        set
            {
                mPassword = value;
            }
        }
        public string Department
        {
            get { return mDepartment; }
            set { mDepartment = value; }
        }
        public bool FindAdmin(string username, string password)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@Username", username);
            DB.AddParameter("@Password", password);
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