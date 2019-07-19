using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tests_Framework;
using OpenQA.Selenium;

namespace TwitterTest
{
    [TestClass]
    public class Post

    {
        public void Init()
        {
            Driver.Initialize("Chrome");

        }
        [TestMethod]
        public void Post_Tweet2()
        {
            Random getrandom = new Random();
            int num = getrandom.Next(0, 5000);
            LoginPage loginPage = new LoginPage();
            Twitter_Login.Login();
            Assert.AreEqual(Global_variable.tab_title, "Twitter", "Login no fue exitoso");
            LoginCommand.Posttw(num);
            Assert.AreEqual(Global_variable.Find_post, "post " + num, false, "Post no fue exitoso");
        }
    }
}
