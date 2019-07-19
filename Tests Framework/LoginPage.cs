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
       
        public void GoTo(String site)
        {
           Driver.Instance.Navigate().GoToUrl(site + "login");
        }
  
    }
}