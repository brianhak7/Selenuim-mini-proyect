using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tests_Framework;
using OpenQA.Selenium;

namespace TwitterTest
{
    [TestClass]
    public class Find_profile
    {
        [TestMethod]
        public void Find()
        {
            var user = "Lady Gaga";
            LoginPage loginPage = new LoginPage();
            Twitter_Login.Login();
            Assert.AreEqual(Global_variable.tab_title, "Twitter", "Login no fue exitoso");
            LoginCommand.Go_to_Profile();
         Assert.IsTrue(Assert_function.Buscar_text(user), "Usuario no encontrado");
        }
    }
}
