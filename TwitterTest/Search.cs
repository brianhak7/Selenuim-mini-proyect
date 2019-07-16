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
            LoginPage loginPage = new LoginPage();
            LoginCommand.Go_to_Profile();
            Driver.Wait(TimeSpan.FromSeconds(2));
            Assert.IsTrue(Driver.Instance.FindElements(By.CssSelector("a.ProfileHeaderCard-nameLink.u-textInheritColor.js-nav"))[0].Text.Contains(user), "Cuenta no encontrado");

            //  Driver.Instance.Quit();
        }
    }
}
