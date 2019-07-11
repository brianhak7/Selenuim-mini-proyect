using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tests_Framework;

namespace TwitterTest
{
    [TestClass]
    public class Serach
    {
        [TestMethod]
        public void TestMethod1()
        {
            LoginPage loginPage = new LoginPage();
            LoginCommand.Search();
        }
    }
}
