using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tests_Framework;
using OpenQA.Selenium;

namespace TwitterTest
{
    [TestClass]
    public class Search

    {
        [TestInitialize]
        public void Init()
        {
            Driver.Initialize("Chrome");

        }
        [TestMethod]
        public void TestMethod1()
        {
            var user = "Lady Gaga";
            Global_variable.Find_user = user;
            LoginPage loginPage = new LoginPage();
            LoginCommand.Search(Global_variable.Find_user);
            Driver.Wait(TimeSpan.FromSeconds(2));

            Assert.IsTrue(Driver.Instance.FindElements(By.CssSelector("a.ProfileHeaderCard-nameLink.u-textInheritColor.js-nav"))[0].Text.Contains(user), "Cuenta no encontrado");

            //  Driver.Instance.Quit();
        }
    }
}
