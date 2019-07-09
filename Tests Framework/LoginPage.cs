using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using OpenQA.Selenium.Opera;
using OpenQA.Selenium.Chrome;

namespace Tests_Framework
{
    public class LoginPage
    {
       
        public void GoTo(string site)
        {
            // System.setProperty("webdriver.gecko.driver", "D:\\\\ToolsQA\\trunk\\Library\\drivers\\geckodriver.exe");
            //IWebDriver driver = new FirefoxDriver(@"C:\Users\Intellisys\Documents\Visual Studio 2017\Projects\TwitterTest\packages\WebDriver.GeckoDriver.0.20.1\content\");
           Driver.Instance.Navigate().GoToUrl(site + "login");
            /// IWebDriver webDriver = new ChromeDriver();
            // webDriver.Navigate().GoToUrl("http://twitter.com/login");
           // Instance.Manage().Timeouts().ImplicitWait.Add(TimeSpan.FromSeconds(5));
          // var wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(5));
           
         //  wait.Until(d => d.SwitchTo().ActiveElement().GetAttribute("class") == Class);

        }
        // js-username-field email-input js-initial-focus
     /*   public static LoginCommand LoginAs(string userName)
        {
            return new LoginCommand(userName);
        } */
    }

   



}