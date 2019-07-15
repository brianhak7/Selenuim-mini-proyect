using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tests_Framework;

namespace TwitterTest
{
    [TestClass]
    public class Find_profile
    {
        [TestMethod]
        public void Find()
        {
            LoginPage loginPage = new LoginPage();
         LoginCommand.Go_to_Profile();
        }
    }
}
