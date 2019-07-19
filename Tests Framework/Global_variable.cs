using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests_Framework
{
    public class Global_variable
    {
        public static string comment;
        public static string tab_title = Driver.Instance.Title;
        public static string Find_user;
        public static string Find_post = Driver.Instance.FindElements(By.CssSelector("p.TweetTextSize.js-tweet-text.tweet-text"))[0].Text;


    }
}