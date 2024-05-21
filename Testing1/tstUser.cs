using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class tstUser
    {

        string Username = "Username";
        string Email = "ab@gmail.com";
        string Password = "12345ABSC";
        string Address = "Gateway House, Leicester, LE1 9BH";
        string PhoneNumber = "1234567890";
        string DateAdded = DateTime.Now.Date.ToString();
        bool Active = false;

        [TestMethod]
        public void InstanceOK()
        {
            clsUser AUser = new clsUser();
            Assert.IsNotNull(AUser);
        }



        [TestMethod]
        public void ValidMethodOK()
        {
            clsUser AUser = new clsUser();
            String Error = "";
            Error = AUser.Valid(Username, Email, Password, Address, PhoneNumber, DateAdded);
            Assert.AreEqual(Error, "");
        }



        [TestMethod]
        public void UsernameMinLessOne()
        {
            clsUser AUser = new clsUser();
            String Error = "";
            String Username = "";
             Error = AUser.Valid(Username, Email, Password, Address, PhoneNumber, DateAdded);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void UsernameMin()
        {
            clsUser AUser = new clsUser();
            String Error = "";
            String Username = "u";
             Error = AUser.Valid(Username, Email, Password, Address, PhoneNumber, DateAdded);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void UsernameMinPlusOne()
        {
            clsUser AUser = new clsUser();
            String Error = "";
            String Username = "uu";
             Error = AUser.Valid(Username, Email, Password, Address, PhoneNumber, DateAdded);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void UsernameMaxLessOne()
        {
            clsUser AUser = new clsUser();
            String Error = "";
            String Username = "";
            Username = Username.PadRight(49, 'U');
             Error = AUser.Valid(Username, Email, Password, Address, PhoneNumber, DateAdded);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void UsernameMax()
        {
            clsUser AUser = new clsUser();
            String Error = "";
            String Username = "";
            Username = Username.PadRight(50, 'U');
             Error = AUser.Valid(Username, Email, Password, Address, PhoneNumber, DateAdded);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void UsernameMaxPlusOne()
        {
            clsUser AUser = new clsUser();
            String Error = "";
            String Username = "";
            Username = Username.PadRight(51, 'U');
             Error = AUser.Valid(Username, Email, Password, Address, PhoneNumber, DateAdded);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void UsernameMid()
        {
            clsUser AUser = new clsUser();
            String Error = "";
            String Username = "";
            Username = Username.PadRight(25, 'C');
             Error = AUser.Valid(Username, Email, Password, Address, PhoneNumber, DateAdded);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void UsernameExtremeMAX()
        {
            clsUser AUser = new clsUser();
            String Error = "";
            String Username = "";
            Username = Username.PadRight(500, 'C');
             Error = AUser.Valid(Username, Email, Password, Address, PhoneNumber, DateAdded);
            Assert.AreEqual(Error, "");
        }




        [TestMethod]
        public void PhoneNumberMinLessOne()
        {
            clsUser AUser = new clsUser();
            String Error = "";
            string PhoneNumber = "12345";
             Error = AUser.Valid(Username, Email, Password, Address, PhoneNumber, DateAdded);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void PhoneNumberMin()
        {
            clsUser AUser = new clsUser();
            String Error = "";
            string PhoneNumber = "123456";
             Error = AUser.Valid(Username, Email, Password, Address, PhoneNumber, DateAdded);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void PhoneNumberMinPlusOne()
        {
            clsUser AUser = new clsUser();
            String Error = "";
            string PhoneNumber = "1234567";
             Error = AUser.Valid(Username, Email, Password, Address, PhoneNumber, DateAdded);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void PhoneNumberMaxLessOne()
        {
            clsUser AUser = new clsUser();
            String Error = "";
            string PhoneNumber = "12345678912345";
             Error = AUser.Valid(Username, Email, Password, Address, PhoneNumber, DateAdded);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNumberMax()
        {
            clsUser AUser = new clsUser();
            String Error = "";
            string PhoneNumber = "123456789123456";
             Error = AUser.Valid(Username, Email, Password, Address, PhoneNumber, DateAdded);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void PhoneNumberMaxPlusOne()
        {
            clsUser AUser = new clsUser();
            String Error = "";
            string PhoneNumber = "1234567891234567";
             Error = AUser.Valid(Username, Email, Password, Address, PhoneNumber, DateAdded);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNumberMid()
        {
            clsUser AUser = new clsUser();
            String Error = "";
            string PhoneNumber = "1234567";
             Error = AUser.Valid(Username, Email, Password, Address, PhoneNumber, DateAdded);
            Assert.AreEqual(Error, "");
        }




        [TestMethod]
        public void DateAddedExtremeMin()
        {
            clsUser AUser = new clsUser();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);
            String DateAdded = TestDate.ToString();
             Error = AUser.Valid(Username, Email, Password, Address, PhoneNumber, DateAdded);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMinLessOne()
        {
            clsUser AUser = new clsUser();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(-1);
            String DateAdded = TestDate.ToString();
             Error = AUser.Valid(Username, Email, Password, Address, PhoneNumber, DateAdded);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void DateAddedMin()
        {
            clsUser AUser = new clsUser();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            String DateAdded = TestDate.ToString();
             Error = AUser.Valid(Username, Email, Password, Address, PhoneNumber, DateAdded);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void DateAddedMinPlusOne()
        {
            clsUser AUser = new clsUser();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(1);
            String DateAdded = TestDate.ToString();
             Error = AUser.Valid(Username, Email, Password, Address, PhoneNumber, DateAdded);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void DateAddedExtremeMAX()
        {
            clsUser AUser = new clsUser();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(100);
            String DateAdded = TestDate.ToString();
             Error = AUser.Valid(Username, Email, Password, Address, PhoneNumber, DateAdded);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void DateAddedInvalidFormat()
        {
            clsUser AUser = new clsUser();
            String Error = "";
            String DateAdded = "This is not a DATE";
             Error = AUser.Valid(Username, Email, Password, Address, PhoneNumber, DateAdded);
            Assert.AreEqual(Error, "");
        }





        [TestMethod]
        public void UserID() 
        { 
            clsUser AUser = new clsUser();
            Int32 TestData = 1;
            AUser.UserID = TestData;
            Assert.AreEqual(AUser.UserID, TestData);
        }


        [TestMethod]

        public void UsernamePropertyOK()
        {
            clsUser AUser = new clsUser();
            String TestData = "Username1";
            AUser.Username = TestData;
            Assert.AreEqual(AUser.Username, TestData);
        }



        [TestMethod]

        public void EmailPropertyOK()
        {
            clsUser AUser = new clsUser();
            String TestData = "a@gmail.com";
            AUser.Email = TestData;
            Assert.AreEqual(AUser.Email, TestData);
        }



        [TestMethod]

        public void PasswordPropertyOK()
        {
            clsUser AUser = new clsUser();
            String TestData = "123456";
            AUser.Password = TestData;
            Assert.AreEqual(AUser.Password, TestData);
        }




        [TestMethod]

        public void AddressPropertyOK()
        {
            clsUser AUser = new clsUser();
            String TestData = "Gateway House, Leicester, LE2 9BH.";
            AUser.Address = TestData;
            Assert.AreEqual(AUser.Address, TestData);
        }



        [TestMethod]

        public void PhonePropertyOK()
        {
            clsUser AUser = new clsUser();
            String TestData = "07776668888";
            AUser.Phone = TestData;
            Assert.AreEqual(AUser.Phone, TestData);
        }


        [TestMethod]

        public void ActivePropertyOK()
        {
            clsUser AUser = new clsUser();
            Boolean TestData = true;
            AUser.Active = TestData;
            Assert.AreEqual(AUser.Active, TestData);
        }


        [TestMethod]
        public void DateAddedPropertyOK()
        {
            clsUser AProduct = new clsUser();
            DateTime TestData = DateTime.Now.Date;
            AProduct.DateAdded = TestData;
            Assert.AreEqual(AProduct.DateAdded, TestData);
        }



        [TestMethod]
        public void FindMethodOK()
        {
            clsUser AUser = new clsUser();
            Boolean Found = false;
            Int32 UserID = 2;
            Found = AUser.Find(UserID);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestUserIDFound()
        {
            clsUser AUser = new clsUser();
            Boolean Found = false;
            Boolean OK = true;
            Int32 UserID = 2;
            
            Found  = AUser.Find(UserID);
            if (AUser.UserID != 2)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestUsernameFound()
        {
            clsUser AUser = new clsUser();
            Boolean Found = false;
            Boolean OK = true;
            Int32 UserID = 2;

            Found = AUser.Find(UserID);
            if (AUser.Username != "Username of the User")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestEmailFound()
        {
            clsUser AUser = new clsUser();
            Boolean Found = false;
            Boolean OK = true;
            Int32 UserID = 2;

            Found = AUser.Find(UserID);
            if (AUser.Email != "Samar@gmail.com")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestPasswordFound()
        {
            clsUser AUser = new clsUser();
            Boolean Found = false;
            Boolean OK = true;
            Int32 UserID = 2;

            Found = AUser.Find(UserID);
            if (AUser.Password != "12345678abc")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestAddressFound()
        {
            clsUser AUser = new clsUser();
            Boolean Found = false;
            Boolean OK = true;
            Int32 UserID = 2;

            Found = AUser.Find(UserID);
            if (AUser.Address != "De Montfort University, LE1 9BH")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestPhoneFound()
        {
            clsUser AUser = new clsUser();
            Boolean Found = false;
            Boolean OK = true;
            Int32 UserID = 2;

            Found = AUser.Find(UserID);
            if (AUser.Phone != "0123456789")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestActiveFound()
        {
            clsUser AUser = new clsUser();
            Boolean Found = false;
            Boolean OK = true;
            Int32 UserID = 2;

            Found = AUser.Find(UserID);
            if (AUser.Active != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestDateAddedFound()
        {
            clsUser AUser = new clsUser();
            Boolean Found = false;
            Boolean OK = true;
            Int32 UserID = 2;

            Found = AUser.Find(UserID);
            if (AUser.DateAdded != DateTime.Now.Date)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
    }
}
