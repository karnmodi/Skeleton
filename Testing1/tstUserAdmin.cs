using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class tstUserAdmin
    {

        [TestMethod]
        public void InstanceOK()
        {
            clsUserAdmin AnAdmin = new clsUserAdmin();
            Assert.IsNotNull(AnAdmin);
        }


        [TestMethod]    
        public void AdminIDPropertyOK()
        {
            clsUserAdmin AnAdmin = new clsUserAdmin();
            Int32 TestData = 1;
            AnAdmin.AdminID = TestData;
            Assert.AreEqual(AnAdmin.AdminID, TestData);
        }
        
        
        [TestMethod]    
        public void UsernamePropertyOK()
        {
            clsUserAdmin AnAdmin = new clsUserAdmin();
            string TestData = "xyz";
            AnAdmin.Username = TestData;
            Assert.AreEqual(AnAdmin.Username, TestData);
        }
        
        
        [TestMethod]    
        public void PasswordPropertyOK()
        {
            clsUserAdmin AnAdmin = new clsUserAdmin();
            string TestData = "xxx xxx";
            AnAdmin.Password = TestData;
            Assert.AreEqual(AnAdmin.Password, TestData);
        }
        
        
        
        [TestMethod]    
        public void DepartmentPropertyOK()
        {
            clsUserAdmin AnAdmin = new clsUserAdmin();
            string TestData = "Users Department";

            AnAdmin.Department = TestData;
            Assert.AreEqual(AnAdmin.Department, TestData);
        }

        [TestMethod]

        public void FindAdminMethodOK()
        {
            clsUserAdmin AnAdmin = new clsUserAdmin();
            Boolean Found = false;
            string Username = "Samar Hayat";
            string Password = "Samar";
            Found = AnAdmin.FindAdmin(Username, Password);
            Assert.IsTrue(Found);
        }

        [TestMethod]

        public void TestUsernamePWFound()
        {
            clsUserAdmin AnAdmin = new clsUserAdmin();
            Boolean Found = false;
            Boolean Ok = true;
            string Username = "Samar Hayat";
            string Password = "Samar";
            Found = AnAdmin.FindAdmin(Username, Password);
            
            if(AnAdmin.Username != Username && AnAdmin.Password != Password)
            {
                Ok = false;
            }
            Assert.IsTrue(Ok);
        }

    }
}
