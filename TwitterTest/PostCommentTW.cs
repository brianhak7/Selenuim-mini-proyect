using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tests_Framework;

namespace TwitterTest
{
    [TestClass]
    public class PostCommentTW
    {
        [TestMethod]
        public void TestMethod1()
        {
            Random getrandom = new Random();
            int num = getrandom.Next(0, 5000);
            LoginPage loginPage = new LoginPage();
            LoginCommand.Postcomment(num);
            
        }
    }
}
