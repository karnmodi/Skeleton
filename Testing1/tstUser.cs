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
            Assert.AreEqual(Error, "Username cant be empty.");
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
            Assert.AreEqual(Error, "Username Must be lesser than 50 Characters.");
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
            Assert.AreEqual(Error, "Username Must be lesser than 50 Characters.");
        }


        [TestMethod]
        public void EmailMinLessOne()
        {
            clsUser AUser = new clsUser();
            String Error = "";
            String Email = "";
              Error = AUser.Valid(Username, Email, Password, Address, PhoneNumber, DateAdded);
            Assert.AreEqual(Error, "Email cant be empty.");
        }


        [TestMethod]
        public void EmailMin()
        {
            clsUser AUser = new clsUser();
            String Error = "";
            String Email = "E";
              Error = AUser.Valid(Username, Email, Password, Address, PhoneNumber, DateAdded);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void EmailMinPlusOne()
        {
            clsUser AUser = new clsUser();
            String Error = "";
            String Email = "EE";
              Error = AUser.Valid(Username, Email, Password, Address, PhoneNumber, DateAdded);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void EmailMaxLessOne()
        {
            clsUser AUser = new clsUser();
            String Error = "";
            String Email = "";
            Email = Email.PadRight(29, 'E');
              Error = AUser.Valid(Username, Email, Password, Address, PhoneNumber, DateAdded);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMax()
        {
            clsUser AUser = new clsUser();
            String Error = "";
            String Email = "";
            Email = Email.PadRight(30, 'E');
              Error = AUser.Valid(Username, Email, Password, Address, PhoneNumber, DateAdded);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void EmailMaxPlusOne()
        {
            clsUser AUser = new clsUser();
            String Error = "";
            String Email = "";
            Email = Email.PadRight(31, 'E');
            Error = AUser.Valid(Username, Email, Password, Address, PhoneNumber, DateAdded);
            Assert.AreEqual(Error, "Email Must be lesser than 30 Characters.");
        }

        [TestMethod]
        public void EmailMid()
        {
            clsUser AUser = new clsUser();
            String Error = "";
            String Email = "";
            Email = Email.PadRight(15, 'C');
              Error = AUser.Valid(Username, Email, Password, Address, PhoneNumber, DateAdded);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void EmailExtremeMAX()
        {
            clsUser AUser = new clsUser();
            String Error = "";
            String Email = "";
            Email = Email.PadRight(300, 'E');
              Error = AUser.Valid(Username, Email, Password, Address, PhoneNumber, DateAdded);
            Assert.AreEqual(Error, "Email Must be lesser than 30 Characters.");
        }



        [TestMethod]
        public void PasswordMinLessOne()
        {
            clsUser AUser = new clsUser();
            String Error = "";
            String Password = "";
            Error = AUser.Valid(Username, Email, Password, Address, PhoneNumber, DateAdded);
            Assert.AreEqual(Error, "Password cant be empty.");
        }


        [TestMethod]
        public void PasswordMin()
        {
            clsUser AUser = new clsUser();
            String Error = "";
            String Password = "P";
            Error = AUser.Valid(Username, Email, Password, Address, PhoneNumber, DateAdded);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void PasswordMinPlusOne()
        {
            clsUser AUser = new clsUser();
            String Error = "";
            String Password = "PP";
            Error = AUser.Valid(Username, Email, Password, Address, PhoneNumber, DateAdded);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void PasswordMaxLessOne()
        {
            clsUser AUser = new clsUser();
            String Error = "";
            String Password = "";
            Password = Password.PadRight(49, 'P');
            Error = AUser.Valid(Username, Email, Password, Address, PhoneNumber, DateAdded);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PasswordMax()
        {
            clsUser AUser = new clsUser();
            String Error = "";
            String Password = "";
            Password = Password.PadRight(50, 'P');
            Error = AUser.Valid(Username, Email, Password, Address, PhoneNumber, DateAdded);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void PasswordMaxPlusOne()
        {
            clsUser AUser = new clsUser();
            String Error = "";
            String Password = "";
            Password = Password.PadRight(51, 'P');
            Error = AUser.Valid(Username, Email, Password, Address, PhoneNumber, DateAdded);
            Assert.AreEqual(Error, "Password Must be lesser than 30 Characters.");
        }

        [TestMethod]
        public void PasswordMid()
        {
            clsUser AUser = new clsUser();
            String Error = "";
            String Password = "";
            Password = Password.PadRight(25, 'P');
            Error = AUser.Valid(Username, Email, Password, Address, PhoneNumber, DateAdded);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void PasswordExtremeMAX()
        {
            clsUser AUser = new clsUser();
            String Error = "";
            String Password = "";
            Password = Password.PadRight(500, 'P');
            Error = AUser.Valid(Username, Email, Password, Address, PhoneNumber, DateAdded);
            Assert.AreEqual(Error, "Password Must be lesser than 30 Characters.");
        }



        [TestMethod]
        public void AddressMinLessOne()
        {
            clsUser AUser = new clsUser();
            String Error = "";
            String Address = "";
            Error = AUser.Valid(Username, Email, Password, Address, PhoneNumber, DateAdded);
            Assert.AreEqual(Error, "Address cant be empty.");
        }


        [TestMethod]
        public void AddressMin()
        {
            clsUser AUser = new clsUser();
            String Error = "";
            String Address = "A";
            Error = AUser.Valid(Username, Email, Password, Address, PhoneNumber, DateAdded);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void AddressMinPlusOne()
        {
            clsUser AUser = new clsUser();
            String Error = "";
            String Address = "AA";
            Error = AUser.Valid(Username, Email, Password, Address, PhoneNumber, DateAdded);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void AddressMaxLessOne()
        {
            clsUser AUser = new clsUser();
            String Error = "";
            String Address = "";
            Address = Address.PadRight(249, 'A');
            Error = AUser.Valid(Username, Email, Password, Address, PhoneNumber, DateAdded);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressMax()
        {
            clsUser AUser = new clsUser();
            String Error = "";
            String Address = "";
            Address = Address.PadRight(250, 'A');
            Error = AUser.Valid(Username, Email, Password, Address, PhoneNumber, DateAdded);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void AddressMaxPlusOne()
        {
            clsUser AUser = new clsUser();
            String Error = "";
            String Address = "";
            Address = Address.PadRight(251, 'A');
            Error = AUser.Valid(Username, Email, Password, Address, PhoneNumber, DateAdded);
            Assert.AreEqual(Error, "Address Must be lesser than 250 Characters.");
        }

        [TestMethod]
        public void AddressMid()
        {
            clsUser AUser = new clsUser();
            String Error = "";
            String Address = "";
            Address = Address.PadRight(125, 'A');
            Error = AUser.Valid(Username, Email, Password, Address, PhoneNumber, DateAdded);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void AddressExtremeMAX()
        {
            clsUser AUser = new clsUser();
            String Error = "";
            String Address = "";
            Address = Address.PadRight(2500, 'A');
            Error = AUser.Valid(Username, Email, Password, Address, PhoneNumber, DateAdded);
            Assert.AreEqual(Error, "Address Must be lesser than 250 Characters.");
        }





        [TestMethod]
        public void PhoneNumberMinLessOne()
        {
            clsUser AUser = new clsUser();
            String Error = "";
            string PhoneNumber = "12345";
             Error = AUser.Valid(Username, Email, Password, Address, PhoneNumber, DateAdded);
            Assert.AreEqual(Error, "Smallest Phone number would be 6 digit Long.");
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
            Assert.AreEqual(Error, "Phone Number must be smaller than or 15 Digits.");
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
            Assert.AreEqual(Error, "Date cant be in the Past.");
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
            Assert.AreEqual(Error, "Date cant be in the Past.");
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
            Assert.AreEqual(Error, "Date cant be in the future.");
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
            Assert.AreEqual(Error, "Date cant be in the future.");
        }


        [TestMethod]
        public void DateAddedInvalidFormat()
        {
            clsUser AUser = new clsUser();
            String Error = "";
            String DateAdded = "This is not a DATE";
             Error = AUser.Valid(Username, Email, Password, Address, PhoneNumber, DateAdded);
            Assert.AreEqual(Error, "Invalid Data type entered for DAte.");
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
            if (AUser.Username != "user2")
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
            if (AUser.Email != "user2@email.com")
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
            if (AUser.Password != "þÜº˜vT2\u0010")
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
            if (AUser.Address != "456 Elm St")
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
            if (AUser.Phone != "987-654-3210")
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
            if (AUser.DateAdded != Convert.ToDateTime("19-05-2024"))
            {
                OK = true;
            }
            Assert.IsTrue(OK);
        }
    }
}
