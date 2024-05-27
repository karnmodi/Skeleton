using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tstProductAdmin
    {

        /****************** Instance of the class Test *********************/


        [TestMethod]
        public void InstanceOK()
        {
            clsProductAdmin AnAdmin = new clsProductAdmin();
            Assert.IsNotNull(AnAdmin);
        }


        /************************* Property OK Tests ************************/

        [TestMethod]    
        public void AdminIDPropertyOK()
        {
            clsProductAdmin AnAdmin = new clsProductAdmin();
            Int32 TestData = 1;

            AnAdmin.AdminID = TestData;
            Assert.AreEqual(AnAdmin.AdminID, TestData);
        }
        
        
        [TestMethod]    
        public void AdminNamePropertyOK()
        {
            clsProductAdmin AnAdmin = new clsProductAdmin();
            string TestData = "Admin abc";

            AnAdmin.AdminName = TestData;
            Assert.AreEqual(AnAdmin.AdminName, TestData);
        }
        
        
        [TestMethod]    
        public void PasswordPropertyOK()
        {
            clsProductAdmin AnAdmin = new clsProductAdmin();
            string TestData = "as12345abc";

            AnAdmin.Password = TestData;
            Assert.AreEqual(AnAdmin.Password, TestData);
        }
        
        
        
        [TestMethod]    
        public void DepartmentPropertyOK()
        {
            clsProductAdmin AnAdmin = new clsProductAdmin();
            string TestData = "Products";

            AnAdmin.Department = TestData;
            Assert.AreEqual(AnAdmin.Department, TestData);
        }


        /************************* Find Admin Method ************************/

        [TestMethod]

        public void FindAdminMethodOK()
        {
            clsProductAdmin AnAdmin = new clsProductAdmin();

            Boolean Found = false;

            string AdminName = "Karan Modi";
            string Password = "123456";

            Found = AnAdmin.FindAdmin(AdminName, Password);
            Assert.IsTrue(Found);
        }



        [TestMethod]

        public void TestAdminNamePWFound()
        {
            clsProductAdmin AnAdmin = new clsProductAdmin();

            Boolean Found = false;
            Boolean Ok = true;

            string AdminName = "Karan Modi";
            string Password = "123456";

            Found = AnAdmin.FindAdmin(AdminName, Password);
            if(AnAdmin.AdminName != AdminName && AnAdmin.Password != Password)
            {
                Ok = false;
            }
            Assert.IsTrue(Ok);
        }

    }
}
