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
    protected void Page_Load(object sender, EventArgs e)
    {
        
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
        Boolean Active = chkActive.Checked;


        string Error = "";
        Error = AUser.Valid(Username, Email, Password, Address, PhoneNumber, DateAdded);
        if (Error == "")
        {
            AUser.Username = Username;
            AUser.Email = Email ;
            AUser.Password= Password;
            AUser.Address= Address;
            AUser.Phone = PhoneNumber;
            AUser.DateAdded = Convert.ToDateTime(DateAdded);
            AUser.Active = Convert.ToBoolean(Active);
            
            clsUserCollection UsersList = new clsUserCollection();
            UsersList.ThisUser = AUser;
            UsersList.Add();
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