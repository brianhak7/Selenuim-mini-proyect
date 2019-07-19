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
            
         LoginCommand.Go_to_Profile();
         Assert.IsTrue(Assert_function.Buscar_text(user), "Usuario no encontrado");
        }
    }
}
