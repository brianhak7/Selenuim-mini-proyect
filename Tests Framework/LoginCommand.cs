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
        public static readonly Random getrandom = new Random();
        int num = getrandom.Next(0, 5000);
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

        public void Login(string user,string pass, string button, string site)
        {
            if (site == "fb")
            {
                var loginInput = Driver.Instance.FindElement(By.Id(user));
                loginInput.SendKeys(userName);

                var passwordInput = Driver.Instance.FindElement(By.Id(pass));
                passwordInput.SendKeys(password);

                var loginButton = Driver.Instance.FindElement(By.Id(button));
                loginButton.Click();
            }
            else {
                var loginInput = Driver.Instance.FindElement(By.ClassName(user));
                loginInput.SendKeys(userName);

                var passwordInput = Driver.Instance.FindElement(By.ClassName(pass));
                passwordInput.SendKeys(password);

                var loginButton = Driver.Instance.FindElement(By.TagName(button));
                loginButton.Click();
                var twdelete = Driver.Instance.FindElement(By.ClassName("_2s25"));
                twdelete.Click();
                //_2s25
                var Tweet = Driver.Instance.FindElement(By.ClassName("_1mf"));
                Tweet.SendKeys("Post " + num);
                //_1mf
            }
            /*
                      //  var wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(2));


                        var Tweet = Driver.Instance.FindElement(By.Id("tweet-box-home-timeline"));
                        Tweet.SendKeys("Post " + num);

                        var wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(2));

                        var twbutton = Driver.Instance.FindElement(By.ClassName("tweet-action"));
                        twbutton.Click();
                        var wait2 = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(5));
                        // wait2.p
                        TimeSpan.FromSeconds(5);
                        var twdelete = Driver.Instance.FindElement(By.ClassName("ProfileCardStats-statValue"));
                        twdelete.Click();
                        TimeSpan.FromSeconds(5);

                        //  var wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(5));
                        //  wait.Until(d => d.SwitchTo().ActiveElement().GetAttribute("class") == "ProfileHeading-toggleLink");


                        //twdelete1.Click();

                        var wait1 = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(5));
                        // var twdelete1 = Driver.Instance.FindElement(By.XPath("//div[2]/div[4]/button[2]"));
                        // twdelete1.Click();
                        //xpath=//div[2]/div[4]/button[2]
                        //   var twdelete2 = Driver.Instance.FindElement(By.TagName("Delete"));
                        //  twdelete1.Click();

                        //ProfileHeading-toggleLink
                        // loginInput.SendKeys(userName); */
        }

    }
}
