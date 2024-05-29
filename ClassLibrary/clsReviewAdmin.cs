using System;

namespace ClassLibrary
{
    public class clsReviewAdmin
    {
        private Int32 mAdminID;
        private String mAdminname;
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

        public string Adminname
        {
            get
            {
                return mAdminname;
            }
            set
            {
                mAdminname = value;
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

        public bool FindAdmin(string Adminname, string Password)
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@Adminname", Adminname);



            DB.AddParameter("@Password", Password);

            DB.Execute("stpr_tblAdmin_FindAdminnamePW");

            if (DB.Count == 1)
            {
                mAdminID = Convert.ToInt32(DB.DataTable.Rows[0]["AdminID"]);

                mAdminname = Convert.ToString(DB.DataTable.Rows[0]["AdminName"]);


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