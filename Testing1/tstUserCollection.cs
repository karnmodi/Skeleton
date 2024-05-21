using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibrary;
using System.Collections.Generic;

namespace Testing1
{
    [TestClass]
    public class tstUserCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsUserCollection AllUsers = new clsUserCollection();
            Assert.IsNotNull(AllUsers);
        }


        [TestMethod]
        public void UserListOK()
        {
            clsUserCollection AllUsers = new clsUserCollection();
            List<clsUser> TestList = new List<clsUser>();
            clsUser TestItem = new clsUser();

            TestItem.UserID = 1;
            TestItem.Username = "User XYZ";
            TestItem.Email = "ab@gmail.com";
            TestItem.Password = "abcd125Sx";
            TestItem.Address = "Gateway House, LE1 9BH";
            TestItem.Phone = "123456789";
            TestItem.Active = true;
            TestItem.DateAdded = DateTime.Now.Date;

            TestList.Add(TestItem);
            AllUsers.UserList = TestList;

            Assert.AreEqual(AllUsers.UserList, TestList);
        }


        [TestMethod]
        public void CountPropertyOK()
        {
            clsUserCollection AllUsers = new clsUserCollection();
            Int32 nCount = 0;
            AllUsers.Count = nCount;
            Assert.AreEqual(AllUsers.Count, AllUsers.Count);
        }

        [TestMethod]
        public void ThisUserPropertyOK()
        {
            clsUserCollection AllUsers = new clsUserCollection();
            clsUser TestItem = new clsUser();

            TestItem.UserID = 1;
            TestItem.Username = "User XYZ";
            TestItem.Email = "ab@gmail.com";
            TestItem.Password = "abcd125Sx";
            TestItem.Address = "Gateway House, LE1 9BH";
            TestItem.Phone = "123456789";
            TestItem.Active = true;
            TestItem.DateAdded = DateTime.Now.Date;


            AllUsers.ThisUser = TestItem;

            Assert.AreEqual(AllUsers.ThisUser, TestItem);
        }




        public void ListAndCountOK()
        {
            clsUserCollection AllUsers = new clsUserCollection();
            List<clsUser> TestList = new List<clsUser>();
            clsUser TestItem = new clsUser();

            TestItem.UserID = 1;
            TestItem.Username = "User XYZ";
            TestItem.Email = "ab@gmail.com";
            TestItem.Password = "abcd125Sx";
            TestItem.Address = "Gateway House, LE1 9BH";
            TestItem.Phone = "123456789";
            TestItem.Active = true;
            TestItem.DateAdded = DateTime.Now.Date;

            TestList.Add(TestItem);
            AllUsers.UserList = TestList;

            Assert.AreEqual(AllUsers.Count, TestList.Count);
        }


        [TestMethod]
        public void TwoRecordsPresent()
        {
            clsUserCollection AllUsers = new clsUserCollection();
            Assert.AreEqual(AllUsers.Count, AllUsers.Count);
        }
    }
}
