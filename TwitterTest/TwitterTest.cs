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
            // LoginCommand.Posttw(num);
            var file = Driver.Instance.FindElements(By.CssSelector("a.u-textInheritColor.js-nav"))[0].Text;
         Assert.AreEqual(file , "pila cola",false, "Login no fue exitoso");
           
            
            // Console.Write(Driver.Instance.FindElements(By.CssSelector("a.u-textInheritColor.js-nav"))[0].TagName);
           // LoginCommand.Search();
           // LoginCommand.tendencia();
           //  LoginCommand.logout();
        }
    }
}
