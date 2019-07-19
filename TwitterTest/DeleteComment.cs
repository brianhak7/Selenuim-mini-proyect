using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tests_Framework;

namespace TwitterTest
{
    [TestClass]
    public class DeleteComment
    {
        [TestMethod]
       
        public void TestMethod1()
        {
            LoginPage loginPage = new LoginPage();
            Twitter_Login.Login();
            Assert.AreEqual(Global_variable.tab_title, "Twitter", "Login no fue exitoso");
            LoginCommand.Deletecommnet();
            Assert.IsTrue(Assert_function.Buscar_text(Global_variable.Find_user), "Cuenta no encontrado");
        }
    }
}
