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
            Int32 SomeCount = 0;
            AllUsers.Count = SomeCount;
            Assert.AreEqual(AllUsers.Count, SomeCount);
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
            Assert.AreEqual(AllUsers.Count,2);
        }


        [TestMethod]
        public void AddMethodOK()
        {
            clsUserCollection AllUsers = new clsUserCollection();
            clsUser TestUser = new clsUser();
            Int32 PrimaryKey = 0;
            TestUser.Username = "Samar Hayat";
            TestUser.Email = "samarhayat@gmail.com";
            TestUser.Password = "abcdas12";
            TestUser.Address = "Le3 46a, United Kingdom";
            TestUser.Phone = "0123456789";
            TestUser.DateAdded = DateTime.Now;
            TestUser.Active = false;
            AllUsers.ThisUser = TestUser;
            PrimaryKey = AllUsers.Add();
            TestUser.UserID = PrimaryKey;
            AllUsers.ThisUser.Find(PrimaryKey);
            Assert.AreEqual(AllUsers.ThisUser, TestUser);

        }

        [TestMethod]
        public void EditMethodOK()
        {
            clsUserCollection AllUsers = new clsUserCollection();
            clsUser TestUser = new clsUser();
            Int32 PrimaryKey = 0;
            TestUser.Username = "Samar Hayat";
            TestUser.Email = "samarhayat@gmail.com";
            TestUser.Password = "abcdas12";

            TestUser.Address = "Le3 46a, United Kingdom";
            TestUser.Phone = "0123456789";
            TestUser.DateAdded = DateTime.Now;
            TestUser.Active = false;

            AllUsers.ThisUser = TestUser;

            PrimaryKey = AllUsers.Add();
            TestUser.UserID = PrimaryKey;
            TestUser.Username = "SAMAR HAYAT";
            TestUser.Email = "sh@gmail.com";
            TestUser.Password = "2521Samar";
            TestUser.Address = "Le3 46a, United Kingdom";

            TestUser.Phone = "0123455589";
            TestUser.DateAdded = DateTime.Now;
            TestUser.Active = true;
            AllUsers.ThisUser = TestUser;
            AllUsers.Update();
            AllUsers.ThisUser.Find(PrimaryKey);
            Assert.AreEqual(AllUsers.ThisUser, TestUser);
        }


        [TestMethod]
        public void DeleteMethodOK()
        {
            clsUserCollection AllUsers = new clsUserCollection();
            clsUser TestUser = new clsUser();

            Int32 PrimaryKey = 0;

            TestUser.UserID = PrimaryKey;
            TestUser.Username = "SAMAR HAYAT";
            TestUser.Email = "sh@gmail.com";
            TestUser.Password = "2521Samar";
            TestUser.Address = "Le3 46a, United Kingdom";

            TestUser.Phone = "0123455589";
            TestUser.DateAdded = DateTime.Now;
            TestUser.Active = true;

            AllUsers.ThisUser = TestUser;
            PrimaryKey = AllUsers.Add();
            TestUser.UserID = PrimaryKey;
            AllUsers.ThisUser.Find(PrimaryKey);

            AllUsers.Delete();
            Boolean Found = AllUsers.ThisUser.Find(PrimaryKey);

            Assert.IsFalse(Found);
        }
    }
}
