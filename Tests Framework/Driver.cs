using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Opera;
using System.Threading;
using OpenQA.Selenium.Chrome;

namespace Tests_Framework
{
    public class Driver
    {
        public static IWebDriver Instance { get; set; }



        public static void Initialize(string web)
        {
            if (web == "Chrome")
            {
                Instance = new ChromeDriver();
                TurnOnWait();
            }
            else {
                Instance = new FirefoxDriver();
                TurnOnWait();
            }
        }

        public static void Close()
        {
            Instance.Close();
        }

        internal static void Wait(TimeSpan timeSpan)
        {
            Thread.Sleep((int)(timeSpan.TotalSeconds * 1000));
        }

        public static void NoWait(Action action)
        {
            
            action();
            TurnOnWait();

        }

        

        private static void TurnOnWait()
        {
            Instance.Manage().Timeouts().ImplicitWait.Add(TimeSpan.FromSeconds(5));
        }
    }
}
