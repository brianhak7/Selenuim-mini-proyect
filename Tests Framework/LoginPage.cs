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
    public class LoginPage
    {
        public static void GoTo()
        {
           // System.setProperty("webdriver.gecko.driver", "D:\\\\ToolsQA\\trunk\\Library\\drivers\\geckodriver.exe");
            var driver = new FirefoxDriver();
            //Driver.Instance.Navigate().GoToUrl(Driver.BaseAddress + "login");
             driver.Navigate().GoToUrl("http://twitter.com/login");

            //var wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(1));
            // wait.Until(d => d.SwitchTo().ActiveElement().GetAttribute("id") == "user_login");

        }

        public static LoginCommand LoginAs(string userName)
        {
            return new LoginCommand(userName);
        }
    }

    



}