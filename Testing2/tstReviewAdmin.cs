using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing5
{
    [TestClass]
    public class tstReviewAdmin
    {

        [TestMethod]
        public void InstanceOK()
        {
            clsReviewAdmin AnAdmin = new clsReviewAdmin();
            Assert.IsNotNull(AnAdmin);
        }


        [TestMethod]
        public void AdminIDPropertyOK()
        {
            clsReviewAdmin AnAdmin = new clsReviewAdmin();
            Int32 TestData = 5;
            AnAdmin.AdminID = TestData;
            Assert.AreEqual(AnAdmin.AdminID, TestData);
        }
        [TestMethod]
        public void AdminnamePropertyOK()
        {
            clsReviewAdmin AnAdmin = new clsReviewAdmin();
            string TestData = "";
            AnAdmin.Adminname = TestData;
            Assert.AreEqual(AnAdmin.Adminname, TestData);
        }


        [TestMethod]
        public void PasswordPropertyOK()
        {
            clsReviewAdmin AnAdmin = new clsReviewAdmin();
            string TestData = "-p0o9i8u6";
            AnAdmin.Password = TestData;
            Assert.AreEqual(AnAdmin.Password, TestData);
        }



        [TestMethod]
        public void DepartmentPropertyOK()
        {
            clsReviewAdmin AnAdmin = new clsReviewAdmin();
            string TestData = "Reviews Department";

            AnAdmin.Department = TestData;
            Assert.AreEqual(AnAdmin.Department, TestData);
        }

        [TestMethod]

        public void FindAdminMethodOK()
        {
            clsReviewAdmin AnAdmin = new clsReviewAdmin();
            Boolean Found = false;
            string Adminname = "Diya Patel";
            string Password = "DDDDD";
            Found = AnAdmin.FindAdmin(Adminname, Password);
            Assert.IsTrue(Found);
        }

        [TestMethod]

        public void TestReviewnamePWFound()
        {
            clsReviewAdmin AnAdmin = new clsReviewAdmin();
            Boolean Found = false;
            Boolean Ok = true;
            string Adminname = "Diya Patel";
            string Password = "DDDDD";
            Found = AnAdmin.FindAdmin(Adminname, Password);

            if (AnAdmin.Adminname != Adminname && AnAdmin.Password != Password)
            {
                Ok = false;
            }
            Assert.IsTrue(Ok);
        }
    }

}
