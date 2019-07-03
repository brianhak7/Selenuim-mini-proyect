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
          Driver.Initialize();

        }
        [TestMethod]
        public void TestMethod1()
        {

            LoginPage loginPage = new LoginPage();
            loginPage.GoTo("https://twitter.com/", "js-username-field email-input js-initial-focus");
            LoginPage.LoginAs(Password.UserNamefb).WithPassword(Password.Passw0rdfb).Login("js-username-field", "js-password-field", "submit","tw");
        }
    }
}
