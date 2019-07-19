using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tests_Framework;
using OpenQA.Selenium;

namespace TwitterTest
{
    [TestClass]
    public class Search

    {
        [TestInitialize]
        public void Init()
        {
            Driver.Initialize("Chrome");

        }
        [TestMethod]
        public void TestMethod1()
        {
            string user = "Lady Gaga";
            //Global_variable.Find_user = user;
            LoginPage loginPage = new LoginPage();
            Twitter_Login.Login();
            LoginCommand.Search(user);
            Driver.Wait(TimeSpan.FromSeconds(2));

            Assert.IsTrue(Assert_function.Buscar_text(user), "Cuenta no encontrado");

           
        }
    }
}
