using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tests_Framework;
using OpenQA.Selenium;

namespace TwitterTest
{
    [TestClass]
    public class Serach

    {
        [TestInitialize]
        public void Init()
        {
            Driver.Initialize("Chrome");

        }
        [TestMethod]
        public void TestMethod1()
        {
            var user = "Danilo Medina";
            LoginPage loginPage = new LoginPage();
            loginPage.GoTo("https://twitter.com/");
            LoginCommand.Login(Usernamepasstw.Passw0rd, Usernamepasstw.UserName);
            LoginCommand.Search(user);
            Assert.IsTrue(Driver.Instance.FindElements(By.CssSelector("h1.SearchNavigation-titleText"))[0].Text.Contains(user ),"Usuario no encontrado") ;

        }
    }
}
