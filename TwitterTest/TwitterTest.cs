using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
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
           

            LoginCommand.Search();
           // LoginCommand.tendencia();
           //  LoginCommand.logout();
        }
    }
}
