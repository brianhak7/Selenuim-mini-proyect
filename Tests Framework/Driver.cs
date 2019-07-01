using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Opera;
using System.Threading;

namespace Tests_Framework
{
    public class Driver
    {
        public static IWebDriver Instance { get; set; }


        public static string BaseAddress
        {


            get { return "https://twitter.com/"; }



        }

        public static void Initialize()
        {

            Instance = new FirefoxDriver();
            TurnOnWait();

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
            TurnOffWait();
            action();
            TurnOnWait();

        }

        private static void TurnOffWait()
        {
            Instance.Manage().Timeouts().ImplicitWait.Add(TimeSpan.FromSeconds(0));
        }

        private static void TurnOnWait()
        {
            Instance.Manage().Timeouts().ImplicitWait.Add(TimeSpan.FromSeconds(5));
        }
    }
}
