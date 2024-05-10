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
            clsUser AUser = new clsUser;
            Assert.IsNotNull(AUser);
        }


        [TestMethod]

        public void ActivePropertyOK()
        {
            clsUser AUser = new clsUser();
            Boolean TestData = true;
            AUser.Active = TestData;
            Assert.AreEqual(AUser.Active, TestData);
        }
    }
}
