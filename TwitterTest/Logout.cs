using System;
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
            Twitter_Login.Login();
            Assert.AreEqual(Global_variable.tab_title, "Twitter", "Login no fue exitoso");
            LoginCommand.logout();
            Assert.IsTrue(Assert_function.Look_for_logout("logout"), "LoginOut no fue exitoso");
        }
    }
}
