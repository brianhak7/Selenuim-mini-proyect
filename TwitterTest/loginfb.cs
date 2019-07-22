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
            Driver.Initialize("Chrome");

        }
        [TestMethod]
        public void TestMethod1()
        {
            LoginPage loginPage = new LoginPage();
            loginPage.GoTo("https://www.facebook.com/");
            LoginCommand.Loginfb(Usernamepasstw.Passw0rd, Usernamepasstw.UserName);
            Assert.AreEqual(Driver.Instance.Title, "Facebook", "Login no fue exitoso");
        }
    }
}