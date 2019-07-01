using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tests_Framework;

namespace TwitterTest
{
    [TestClass]
    public class TwitterTest
    {
        [TestInitialize]
        public void Init()
        {
          //  Driver.Initialize();

        }
        [TestMethod]
        public void TestMethod1()
        {
            LoginPage.GoTo();
            LoginPage.LoginAs(Password.UserName).WithPassword(Password.Passw0rd).Login();
        }
    }
}
