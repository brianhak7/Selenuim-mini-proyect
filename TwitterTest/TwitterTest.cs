﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tests_Framework;

namespace TwitterTest
{
    [TestClass]
    public class FBLogin
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
           loginPage.GoTo("https://twitter.com/");
           LoginPage.LoginAs(Usernamepasstw.UserNamefb).WithPassword(Usernamepasstw.Passw0rdfb).Login("tw");
            // LoginCommand.posttw();
            //LoginCommand.search();
            LoginCommand.posttw();
          //  LoginCommand.logout();
        }
    }
}
