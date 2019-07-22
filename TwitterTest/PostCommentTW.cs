using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tests_Framework;

namespace TwitterTest
{
    [TestClass]
    public class Post_Comment

    {
        [TestInitialize]
        public void Init()
        {
            Driver.Initialize("Chrome");

        }
        [TestMethod]
        public void TestMethod1()
        {
            Random getrandom = new Random();
            int num = getrandom.Next(0, 5000);
            LoginPage loginPage = new LoginPage();
            Twitter_Login.Login();
            Assert.AreEqual(Driver.Instance.Title, "Home / Twitter", "Login no fue exitoso");
            LoginCommand.Postcomment("post " + num);
            Assert.IsTrue(Assert_function.Search_Comment("post " + num), "Cuenta no encontrado");
        }
    }
}