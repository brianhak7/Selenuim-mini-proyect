using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tests_Framework;

namespace TwitterTest
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestClass]
    public class Loginerror
    {
        [TestInitialize]
        public void Init()
        {
            Driver.Initialize("");

        }
        



        [TestMethod]
        public void testerror()
        {
            LoginPage loginPage = new LoginPage();
          //  loginPage.GoTo();
         //   LoginPage.LoginAs(Password.UserName).WithPassword("hjklesadadf").Login();
            Assert.IsTrue(Logincheck.IsAt,"Login error");
        }
    }
}
