using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using Tests_Framework;

namespace TwitterTest
{
    [TestClass]
    public class FBLogin
    {
        [TestInitialize]
        public void Init()
        {
            Driver.Initialize("Chrome");

        }
        [TestMethod]
        public void LoginTW1()
        {
            var user = "Lady Gaga";
            Random getrandom = new Random();
            int num = getrandom.Next(0, 5000);
            LoginPage loginPage = new LoginPage();
            loginPage.GoTo("https://twitter.com/");
            LoginCommand.Login(Usernamepasstw.Passw0rd, Usernamepasstw.UserName);
           
            Assert.AreEqual(Global_variable.tab_title, "Twitter", "Login no fue exitoso");
            
        }
    }
}