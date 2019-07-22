using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using Tests_Framework;

namespace TwitterTest
{
    [TestClass]
    public class Twitter_Login
    {
        [TestInitialize]
        public void Init()
        {
            Driver.Initialize("Chrome");

        }
        [TestMethod]
        public void LoginTW()
        {

            Login();
            Assert.AreEqual(Global_variable.tab_title, "Twitter", "Login no fue exitoso");

        }

        public static void Login()
        {
            LoginPage loginPage = new LoginPage();
            loginPage.GoTo("https://twitter.com/");
            LoginCommand.Login(Usernamepasstw.Passw0rd, Usernamepasstw.UserName);
            Driver.Wait(TimeSpan.FromSeconds(3));
        }
    }
}