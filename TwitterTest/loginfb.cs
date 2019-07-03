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
            loginPage.GoTo("https://www.facebook.com/", "inputtext _55r1 inputtext _1kbt inputtext _1kbt");
            LoginPage.LoginAs(Password.UserNamefb).WithPassword(Password.Passw0rdfb).Login("email","pass", "loginbutton","fb");
        }
    }
}
