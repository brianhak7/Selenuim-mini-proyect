﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tests_Framework;

namespace TwitterTest
{
    [TestClass]
    public class Logout
    {
        [TestMethod]
        public void TestMethod1()
        {
            LoginPage loginPage = new LoginPage();
            LoginCommand.logout();
            Assert.IsTrue(Driver.Instance.Url.Contains("logout"), "LoginOut no fue exitoso");
        }
    }
}
