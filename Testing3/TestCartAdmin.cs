using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class TestCartAdmin
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsCartAdmin AnAdmin = new clsCartAdmin();
            Assert.IsNotNull(AnAdmin);
        }


        [TestMethod]
        public void AdminIDPropertyOK()
        {
            clsCartAdmin AnAdmin = new clsCartAdmin();
            Int32 TestData = 1;
            AnAdmin.AdminID = TestData;
            Assert.AreEqual(AnAdmin.AdminID, TestData);
        }


        [TestMethod]
        public void UsernamePropertyOK()
        {
            clsCartAdmin AnAdmin = new clsCartAdmin();
            string TestData = "Bassam";
            AnAdmin.Username = TestData;
            Assert.AreEqual(AnAdmin.Username, TestData);
        }


        [TestMethod]
        public void PasswordPropertyOK()
        {
            clsCartAdmin AnAdmin = new clsCartAdmin();
            string TestData = "khan123";
            AnAdmin.Password = TestData;
            Assert.AreEqual(AnAdmin.Password, TestData);
        }



        [TestMethod]
        public void DepartmentPropertyOK()
        {
            clsCartAdmin AnAdmin = new clsCartAdmin();
            string TestData = "Users Department";

            AnAdmin.Department = TestData;
            Assert.AreEqual(AnAdmin.Department, TestData);
        }

        [TestMethod]

        public void FindAdminMethodOK()
        {
            clsCartAdmin AnAdmin = new clsCartAdmin();
            Boolean Found = false;
            string Username = "Bassam Khan";
            string Password = "1234";
            Found = AnAdmin.FindAdmin(Username, Password);
            Assert.IsTrue(Found);
        }

        [TestMethod]

        public void TestUsernamePWFound()
        {
            clsCartAdmin AnAdmin = new clsCartAdmin();
            Boolean Found = false;
            Boolean Ok = true;
            string Username = "Bassam Khan";
            string Password = "1234";
            Found = AnAdmin.FindAdmin(Username, Password);

            if (AnAdmin.Username != Username && AnAdmin.Password != Password)
            {
                Ok = false;
            }
            Assert.IsTrue(Ok);
        }
    }
}
