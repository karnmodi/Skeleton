using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class tstUser
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsUser AUser = new clsUser();
            Assert.IsNotNull(AUser);
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
