using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{

    Int32 UserID;
    protected void Page_Load(object sender, EventArgs e)
    {
        UserID = Convert.ToInt32(Session["UserID"]);
        if(IsPostBack == false)
        {
            if(UserID != -1)
            {
                DisplayUser();
            }
        }
    }

    void DisplayUser()
    {
        clsUserCollection UsersAll = new clsUserCollection();
        UsersAll.ThisUser.Find(UserID);

        txtUserID.Text = UsersAll.ThisUser.UserID.ToString();
        txtUsername.Text = UsersAll.ThisUser.Username.ToString();
        txtEmail.Text = UsersAll.ThisUser.Email.ToString();
        txtPassword.Text = UsersAll.ThisUser.Password.ToString();
        txtAddress.Text = UsersAll.ThisUser.Address.ToString();
        txtPhone.Text = UsersAll.ThisUser.Phone.ToString();
        txtDateAdded.Text = UsersAll.ThisUser.DateAdded.ToString();
        chkActive.Checked = UsersAll.ThisUser.Active;
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsUser AUser = new clsUser();
        

        string Username = txtUsername.Text;
        string Email = txtEmail.Text;
        string Password = txtPassword.Text;
        string Address = txtAddress.Text;
        string PhoneNumber = txtPhone.Text;
        string DateAdded = txtDateAdded.Text;
        string Active = Convert.ToString(chkActive.Checked);


        string Error = "";
        Error = AUser.Valid(Username, Email, Password, Address, PhoneNumber, DateAdded);
        if (Error == "")
        {
            AUser.UserID = UserID;
            AUser.Username = Username;
            AUser.Email = Email ;
            AUser.Password= Password;
            AUser.Address= Address;
            AUser.Phone = PhoneNumber;
            AUser.DateAdded = Convert.ToDateTime(DateAdded);
            AUser.Active = Convert.ToBoolean(Active);

            clsUserCollection UserList = new clsUserCollection();

            if (UserID == -1)
            {
                UserList.ThisUser = AUser;
                UserList.Add();
            }
            else
            {
                UserList.ThisUser.Find(UserID);
                UserList.ThisUser = AUser;
                UserList.Update();
            }

                Response.Redirect("UsersList.aspx");
        }
        else
        {
            lblError.Text = Error;
        }
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsUser AUser = new clsUser();
        Int32 UserID;
        Boolean Found = false;

        UserID = Convert.ToInt32(txtUserID.Text);
        Found = AUser.Find(UserID);

        if(Found == true)
        {
            txtUsername.Text = AUser.Username;
            txtEmail.Text = AUser.Email;
            txtPassword.Text = AUser.Password;
            txtAddress.Text = AUser.Address;
            txtPhone.Text = AUser.Phone;
            chkActive.Checked = AUser.Active;
            txtDateAdded.Text = AUser.DateAdded.ToString();
        }
    }
}