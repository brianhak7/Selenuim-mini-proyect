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
        public static Random getrandom = new Random();
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

        public void Loginfb(string password, string userName)
        {
            var loginInput = Driver.Instance.FindElement(By.ClassName(selector.UserNameTW));
            loginInput.SendKeys(userName);

            var passwordInput = Driver.Instance.FindElement(By.ClassName(selector.Passw0rdtw));
            passwordInput.SendKeys(password);

            var loginButton = Driver.Instance.FindElement(By.Id("loginbutton"));
            loginButton.Click();
            //var twdelete = Driver.Instance.FindElement(By.ClassName("_1vp5"));
            //twdelete.Click();
            //_2s25
            var Tweet = Driver.Instance.FindElement(By.ClassName("_3ixn"));
            Tweet.Click();

            //  var Tweet1 = Driver.Instance.FindElement(By.ClassName("_2s25"));
            // Tweet1.Click();
            //_2s25 
            //  Tweet.Click();
            //_1mf } 
        }



        public static void Login(string password, string userName)
        {
            var loginInput = Driver.Instance.FindElement(By.ClassName(selector.UserNameTW));
            loginInput.SendKeys(userName);

            var passwordInput = Driver.Instance.FindElement(By.ClassName(selector.Passw0rdtw));
            passwordInput.SendKeys(password);

            var loginButton = Driver.Instance.FindElement(By.TagName(selector.ButtonLogin));
            loginButton.Click();

        }


        public static void Posttw(int num)
        {


            var Tweet = Driver.Instance.FindElement(By.Id(selector.Postid));
            Tweet.SendKeys("post " + num);


            Driver.Wait(TimeSpan.FromSeconds(5));

            var twbutton = Driver.Instance.FindElements(By.CssSelector(selector.TweetAction))[0];
            twbutton.Click();

            //  var twdelete1 = Driver.Instance.FindElement(By.TagName("Delete Tweet"));
            //twdelete1.Click();

            Driver.Wait(TimeSpan.FromSeconds(2));


        }

        public static void Search(String user) {
            //search-input

            var Searchb = Driver.Instance.FindElement(By.ClassName(selector.Search_input));
            Searchb.SendKeys(user);
            var Searchpush = Driver.Instance.FindElement(By.CssSelector(selector.button_Icon));
            Searchpush.Click();

            Driver.Wait(TimeSpan.FromSeconds(5));
        }


        public static void Go_to_Profile()
        {//AdaptiveRelatedSearches-item
            Driver.Wait(TimeSpan.FromSeconds(5));
            var Seapush = Driver.Instance.FindElements(By.CssSelector(selector.Go_to_Profile_search))[0];
            Seapush.Click();

            var tendencia = Driver.Instance.FindElements(By.CssSelector(selector.Postcomment))[0];
            tendencia.Click();
        }
            //span.u-linkComplex-target.trend-name
            //visuallyhidden}
        public static void Postcomment(int num) {
            Driver.Wait(TimeSpan.FromSeconds(8));
            //span.Icon.Icon--medium.Icon--reply
            var comment = Driver.Instance.FindElement(By.CssSelector(selector.Postcomment));
            comment.Click();
            Driver.Wait(TimeSpan.FromSeconds(3));
            var comment2 = Driver.Instance.FindElement(By.Id(selector.Postcomment_sendcomment));
            //comment2.Click();
            comment2.SendKeys("comment " + num);

            //button-text replying-text
            var clickbutton = Driver.Instance.FindElements(By.CssSelector(selector.Postcomment_Button))[1];
            clickbutton.Click();

            



        }
        

        public static void Deletecommnet() {

            Driver.Wait(TimeSpan.FromSeconds(8));
            var twdelete = Driver.Instance.FindElement(By.CssSelector(selector.Delete_Comment_Button));
            twdelete.Click();
            Driver.Wait(TimeSpan.FromSeconds(1));

            var comment1 = Driver.Instance.FindElements(By.CssSelector(selector.Delete_Comment_post))[1];
            comment1.Click();

            var comment3 = Driver.Instance.FindElements(By.CssSelector(selector.Delete_Comment))[0];
            comment3.Click();

            Driver.Wait(TimeSpan.FromSeconds(3));

            var comment4 = Driver.Instance.FindElements(By.CssSelector(selector.Delete_Comment_final))[0];
            comment4.Click();
            //original-tweet-item last-navigable-stream-item
            //Icon Icon--caretDownLight Icon--smal
            //  var commentbutton = Driver.Instance.FindElements(By.ClassName("Icon.Icon--caretDownLight.Icon--small"))[0];
            // commentbutton.Click();

        }

        public static void logout() {
            var push = Driver.Instance.FindElement(By.Id(selector.Logout_Dropdown));
            push.Click();
            var Searchpush = Driver.Instance.FindElement(By.CssSelector(selector.Logout_Button));
            Searchpush.Click();

        }

        //trend-item
        public static void tendencia()
        {
            TimeSpan.FromSeconds(5);
            var push = Driver.Instance.FindElement(By.ClassName(selector.Trends));
            push.Click();
            
        }
        }
}
