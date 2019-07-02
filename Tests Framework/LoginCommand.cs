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

            var loginButton = Driver.Instance.FindElement(By.TagName("button"));
            loginButton.Click();

          //  var wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(2));


            var Tweet = Driver.Instance.FindElement(By.Id("tweet-box-home-timeline"));
            Tweet.SendKeys("posjgt");

            var wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(2));

            var twbutton = Driver.Instance.FindElement(By.ClassName("tweet-action"));
            twbutton.Click();
            var twdelete = Driver.Instance.FindElement(By.ClassName("ProfileTweet-actionButton"));
            twdelete.Click();
            var twdelete1 = Driver.Instance.FindElement(By.TagName("Delete Tweet"));
            twdelete1.Click();

            var twdelete2 = Driver.Instance.FindElement(By.TagName("Delete"));
            twdelete1.Click();

            
            // loginInput.SendKeys(userName);
        }
       
    }
}
