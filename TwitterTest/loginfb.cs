using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tests_Framework;

namespace TwitterTest
{
    [TestClass]
    public class loginfb
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
            loginPage.GoTo("https://www.facebook.com/");
            LoginPage.LoginAs(Usernamepasstw.UserNamefb).WithPassword(Usernamepasstw.Passw0rdfb).Login("fb");
        }
    }
}
