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

            Random getrandom = new Random();
            int num = getrandom.Next(0, 5000);
            LoginPage loginPage = new LoginPage();
            loginPage.GoTo("https://twitter.com/");
            LoginCommand.Login(Usernamepasstw.Passw0rd, Usernamepasstw.UserName);
            //   LoginCommand.Posttw(num);
            //   Comment_variable.comment = "comment " + num;
            ///  LoginCommand.Postcomment(Comment_variable.comment);
            //  LoginCommand.Deletecommnet();

            //  Assert.IsFalse(Buscar.Search_Comment(Comment_variable.comment ),"Commnetario no fue borrado");
            // LoginCommand.Posttw(num);
            // var file = ;
            // LoginCommand.Search();
             Assert.AreEqual(Driver.Instance.Title, "Twitter",false, "Login no fue exitoso");
            //   LoginCommand.Posttw(num);
            Driver.Wait(TimeSpan.FromSeconds(3));
            LoginCommand.logout();
            Driver.Wait(TimeSpan.FromSeconds(4));
            //    Assert.AreEqual(Driver.Instance.Url, "Twitter. It's what's happening.", false, "LoginOut no fue exitoso");
            Assert.IsTrue(Driver.Instance.Url.Contains("logout"), "LoginOut no fue exitoso");
            // Console.Write(Driver.Instance.FindElements(By.CssSelector("a.u-textInheritColor.js-nav"))[0].TagName);
            // LoginCommand.Search();
            // LoginCommand.tendencia();
            //  LoginCommand.logout();
        }
    }
}