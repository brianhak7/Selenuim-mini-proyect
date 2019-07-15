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
            LoginCommand.Posttw(num);
            Assert.AreEqual(Driver.Instance.FindElements(By.CssSelector("p.TweetTextSize.js-tweet-text.tweet-text"))[0].Text, "post " + num, false, "Post no fue exitoso");
        }
    }
}
