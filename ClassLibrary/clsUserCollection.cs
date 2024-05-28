using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class clsUserCollection
    {

        List<clsUser> mUserList = new List<clsUser>();
        clsUser mThisUser = new clsUser();


        public clsUserCollection()
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("stpr_AllUser");
            RecordCount = DB.Count;

            while (Index < RecordCount)
            {
                clsUser AUser = new clsUser();

                AUser.UserID = Convert.ToInt32(DB.DataTable.Rows[Index]["UserID"]);
                AUser.Username = Convert.ToString(DB.DataTable.Rows[Index]["Username"]);
                AUser.Email = Convert.ToString(DB.DataTable.Rows[Index]["Email"]);
                AUser.Password = Convert.ToString(DB.DataTable.Rows[Index]["Password"]);
                AUser.Address = Convert.ToString(DB.DataTable.Rows[Index]["Address"]);
                AUser.Phone = Convert.ToString(DB.DataTable.Rows[Index]["PhoneNumber"]);
                AUser.Active = Convert.ToBoolean(DB.DataTable.Rows[Index]["Active"]);
                AUser.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateAdded"]);

                mUserList.Add(AUser);
                Index++;
            }
        }

        public List<clsUser> UserList
        {
            get
            {
                return mUserList;
            }
            set
            {
                mUserList = value;
            }
        }
        public int Count
        {
            get
            {
                return mUserList.Count;
            }
            set
            {

            }
        }
        public clsUser ThisUser
        {
            get
            {
                return mThisUser;
            }
            set
            {
                mThisUser = value;
            }
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@Username", mThisUser.Username);
            DB.AddParameter("@Email", mThisUser.Email);
            DB.AddParameter("@Password", mThisUser.Password);
            DB.AddParameter("@Address", mThisUser.Address);
            DB.AddParameter("@PhoneNumber", mThisUser.Phone);
            DB.AddParameter("@Active", mThisUser.Active);
            DB.AddParameter("@DateAdded", mThisUser.DateAdded);

            return DB.Execute("stpr_tblUser_Insert");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@UserID", mThisUser.UserID);
            DB.Execute("stpr_tblUser_Delete");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@UserID", mThisUser.UserID);
            DB.AddParameter("@Username", mThisUser.Username);
            DB.AddParameter("@Email", mThisUser.Email);
            DB.AddParameter("@Password", mThisUser.Password);
            DB.AddParameter("@Address", mThisUser.Address);
            DB.AddParameter("@PhoneNumber", mThisUser.Phone);
            DB.AddParameter("@Active", mThisUser.Active);
            DB.AddParameter("@DateAdded", mThisUser.DateAdded);

            DB.Execute("stpr_tblUser_Update");
        }
    }
}
