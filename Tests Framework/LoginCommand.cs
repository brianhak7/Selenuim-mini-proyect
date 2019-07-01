using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using OpenQA.Selenium.Opera;

namespace Tests_Framework
{
    public class LoginCommand
    {
        private string password;
        private readonly string userName;

        public LoginCommand(string userName)
        {
            this.userName = userName;
        }
        public LoginCommand WithPassword(string password)
        {
            this.password = password;
            return this;
        }

        public void Login()
        {

            var loginInput = Driver.Instance.FindElement(By.ClassName("js-username-field"));
            loginInput.SendKeys(userName);

            var passwordInput = Driver.Instance.FindElement(By.ClassName("js-password-field"));
            passwordInput.SendKeys(password);

            var loginButton = Driver.Instance.FindElement(By.ClassName("submit"));
            loginButton.Click();


        }

    }
}
