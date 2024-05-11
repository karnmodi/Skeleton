﻿using ClassLibrary;
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

        public void PaymentInfoPropertyOK()
        {
            clsUser AUser = new clsUser();
            String TestData = "Card";
            AUser.PaymentInfo = TestData;
            Assert.AreEqual(AUser.PaymentInfo, TestData);
        }
    }
}
