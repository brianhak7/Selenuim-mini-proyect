﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tests_Framework;

namespace TwitterTest
{
    [TestClass]
    public class TwitterTest
    {
        [TestInitialize]
        public void Init()
        {
          Driver.Initialize();

        }
        [TestMethod]
        public void TestMethod1()
        {
            LoginPage loginPage = new LoginPage();
           // loginPage.GoTo("https://www.facebook.com/");
        //    LoginPage.LoginAs(Password.UserNamefb).WithPassword(Password.Passw0rdfb).Login();
        }
    }
}
