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
            //   LoginCommand.Posttw(num);
            //   Comment_variable.comment = "comment " + num;
            ///  LoginCommand.Postcomment(Comment_variable.comment);
             LoginCommand.Deletecommnet();
         
             Assert.IsFalse(Assert_function.Search_Comment(Global_variable.comment),"Commnetario no fue borrado");
            // LoginCommand.Posttw(num);
            // var file = ;
            // LoginCommand.Search();
            Assert.AreEqual(Global_variable.tab_title, "Twitter","Login no fue exitoso");
      //      Assert.AreEqual(Driver, title, "");

            LoginCommand.Search(user);
            Driver.Wait(TimeSpan.FromSeconds(2));

           
            //   LoginCommand.Posttw(num);
            // Driver.Wait(TimeSpan.FromSeconds(3));
            //  LoginCommand.logout();
            //  Driver.Wait(TimeSpan.FromSeconds(4));
            //    Assert.AreEqual(Driver.Instance.Url, "Twitter. It's what's happening.", false, "LoginOut no fue exitoso");
            //  Assert.IsTrue(Driver.Instance.Url.Contains("logout"), "LoginOut no fue exitoso");
            // Console.Write(Driver.Instance.FindElements(By.CssSelector("a.u-textInheritColor.js-nav"))[0].TagName);
            // LoginCommand.Search();
            // LoginCommand.tendencia();
            //  LoginCommand.logout();
        }
    }
}