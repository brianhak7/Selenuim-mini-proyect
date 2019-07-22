using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tests_Framework;
using OpenQA.Selenium;

namespace TwitterTest
{
    [TestClass]
    public class Post

    {
        [TestInitialize]
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
            Assert.AreEqual(Driver.Instance.Title, "Home / Twitter", "Login no fue exitoso");
            LoginCommand.Posttw(num);
            Assert.IsTrue(Assert_function.Search_Comment("post " + num), "Post no fue exitoso");
        }
    }
}